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
      });
    }
  }

  Future<void> submit() async {
    if (tagController.text.isEmpty ||
        descriptionController.text.isEmpty ||
        selectedImagePath == null ||
        selectedAirport == null) {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(content: Text("All fields are required")),
      );
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
      Navigator.pop(context);
      widget.onSubmitted?.call();
    } else {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(content: Text("Failed to report luggage")),
      );
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
              onChanged: (val) => setState(() => selectedAirport = val),
            ),

            const SizedBox(height: 12),

            TextField(
              controller: tagController,
              decoration: const InputDecoration(
                labelText: "Tag number",
              ),
            ),

            const SizedBox(height: 12),

            TextField(
              controller: descriptionController,
              maxLines: 3,
              decoration: const InputDecoration(
                labelText: "Description",
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
                  width: 20, height: 20,
                  child: CircularProgressIndicator(strokeWidth: 2),
                )
              : const Text("Submit Report"),
        ),
      ],
    );
  }
}
