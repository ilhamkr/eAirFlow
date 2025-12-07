import 'dart:io';
import 'package:eairflow_desktop/models/airport.dart';
import 'package:eairflow_desktop/providers/airport_provider.dart';
import 'package:eairflow_desktop/providers/auth_provider.dart';
import 'package:eairflow_desktop/providers/luggage_provider.dart';
import 'package:file_picker/file_picker.dart';
import 'package:flutter/material.dart';

class ReportLostDialog extends StatefulWidget {
  final VoidCallback? onSubmitted;

  const ReportLostDialog({
    super.key,
    this.onSubmitted,
  });

  @override
  State<ReportLostDialog> createState() => _ReportLostDialogState();
}

class _ReportLostDialogState extends State<ReportLostDialog> {
  final TextEditingController descriptionController = TextEditingController();
  final TextEditingController tagController = TextEditingController();

  String? selectedImagePath;
  Airport? selectedAirport;

  bool submitting = false;
  List<Airport> airports = [];

  bool tagError = false;
  bool descriptionError = false;
  bool airportError = false;
  bool imageError = false;

  @override
  void initState() {
    super.initState();
    loadAllAirports();
  }

  Future<void> loadAllAirports() async {
    airports = await AirportProvider().getAll();
    setState(() {});
  }

  Future<void> pickImage() async {
    final result = await FilePicker.platform.pickFiles(type: FileType.image);

    if (result != null && result.files.single.path != null) {
      setState(() {
        selectedImagePath = result.files.single.path!;
        imageError = false;
      });
    }
  }

  void validate() {
    setState(() {
      tagError = tagController.text.isEmpty;
      descriptionError = descriptionController.text.isEmpty;
      airportError = selectedAirport == null;
      imageError = selectedImagePath == null;
    });
  }

  Future<void> submit() async {
  validate();

  if (tagError || descriptionError || airportError || imageError) {
    return;
  }

  final userId = AuthProvider.userId!;
  setState(() => submitting = true);

  final success = await LuggageProvider().reportLost(
    userId: userId,
    flightId: 0,
    description: "Tag ${tagController.text}: ${descriptionController.text}",
    filePath: selectedImagePath!,
    airportId: selectedAirport!.airportId!,
  );

  setState(() => submitting = false);

  if (success) {
    ScaffoldMessenger.of(context).showSnackBar(
      const SnackBar(
        content: Text("Luggage successfully reported."),
        backgroundColor: Colors.green,
        duration: Duration(seconds: 2),
      ),
    );

    Future.delayed(const Duration(milliseconds: 300), () {
      Navigator.pop(context);
      widget.onSubmitted?.call();
    });
  }
}


  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text("Report Lost Luggage"),
      content: SizedBox(
        width: 460,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            DropdownButtonFormField<Airport>(
              hint: const Text("Select Airport"),
              value: selectedAirport,
              items: airports
                  .map((a) => DropdownMenuItem(
                        value: a,
                        child: Text("${a.city} - ${a.name}"),
                      ))
                  .toList(),
              onChanged: (val) {
                setState(() {
                  selectedAirport = val;
                  airportError = false;
                });
              },
              decoration: InputDecoration(
                errorText: airportError ? "Airport is required" : null,
              ),
            ),

            const SizedBox(height: 12),

            TextField(
              controller: tagController,
              decoration: InputDecoration(
                labelText: "Tag number",
                errorText: tagError ? "Tag is required" : null,
              ),
            ),

            const SizedBox(height: 12),

            TextField(
              controller: descriptionController,
              maxLines: 3,
              decoration: InputDecoration(
                labelText: "Description",
                errorText:
                    descriptionError ? "Description is required" : null,
              ),
            ),

            const SizedBox(height: 12),

            Row(
              children: [
                ElevatedButton.icon(
                  onPressed: pickImage,
                  icon: const Icon(Icons.image),
                  label: const Text("Choose Image"),
                ),
                const SizedBox(width: 10),
                if (selectedImagePath != null)
                  Image.file(
                    File(selectedImagePath!),
                    width: 60,
                    height: 60,
                    fit: BoxFit.cover,
                  ),
              ],
            ),

            if (imageError)
              const Padding(
                padding: EdgeInsets.only(top: 6),
                child: Align(
                  alignment: Alignment.centerLeft,
                  child: Text(
                    "Image is required",
                    style: TextStyle(color: Colors.red, fontSize: 12),
                  ),
                ),
              ),
          ],
        ),
      ),
      actions: [
        TextButton(
          onPressed: submitting ? null : () => Navigator.pop(context),
          child: const Text("Cancel"),
        ),
        ElevatedButton(
          onPressed: submitting ? null : submit,
          style: ElevatedButton.styleFrom(
            backgroundColor: Colors.red,
          ),
          child: submitting
              ? const SizedBox(
                  width: 20,
                  height: 20,
                  child: CircularProgressIndicator(strokeWidth: 2),
                )
              : const Text("Submit Report"),
        ),
      ],
    );
  }
}
