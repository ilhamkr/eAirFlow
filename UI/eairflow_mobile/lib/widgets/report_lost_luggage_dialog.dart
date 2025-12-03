import 'dart:io';
import 'package:eairflow_mobile/models/airport.dart';
import 'package:eairflow_mobile/providers/airport_provider.dart';
import 'package:eairflow_mobile/providers/auth_provider.dart';
import 'package:eairflow_mobile/providers/luggage_provider.dart';
import 'package:flutter/material.dart';
import 'package:image_picker/image_picker.dart';

class ReportLostDialogMobile extends StatefulWidget {
  final VoidCallback? onSubmitted;

  const ReportLostDialogMobile({super.key, this.onSubmitted});

  @override
  State<ReportLostDialogMobile> createState() => _ReportLostDialogMobileState();
}

class _ReportLostDialogMobileState extends State<ReportLostDialogMobile> {
  final TextEditingController descriptionController = TextEditingController();
  final TextEditingController tagController = TextEditingController();

  String? selectedImagePath;
  Airport? selectedAirport;

  bool submitting = false;
  List<Airport> airports = [];

  @override
  void initState() {
    super.initState();
    loadAirports();
  }

  Future<void> loadAirports() async {
    airports = await AirportProvider().getAll();
    if (mounted) setState(() {});
  }

  Future<void> pickImage() async {
  final ImagePicker picker = ImagePicker();
  final XFile? file = await picker.pickImage(source: ImageSource.gallery);

  if (file != null) {
    setState(() {
      selectedImagePath = file.path;
    });
  }
}

  Future<void> submit() async {
    if (tagController.text.isEmpty ||
        descriptionController.text.isEmpty ||
        selectedAirport == null ||
        selectedImagePath == null) {
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
      ScaffoldMessenger.of(context)
          .showSnackBar(const SnackBar(content: Text("Report submitted")));
    } else {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(content: Text("Failed to submit report")),
      );
    }
  }

    @override
    Widget build(BuildContext context) {
    return AlertDialog(
      title: const Text("Report Lost Luggage"),
      content: SingleChildScrollView(
        child: SizedBox(
          width: MediaQuery.of(context).size.width * 0.8,
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              SizedBox(
    width: double.infinity,
    child: DropdownButtonFormField<Airport>(
      isExpanded: true,
      value: selectedAirport,
      decoration: const InputDecoration(
        border: OutlineInputBorder(),
        labelText: "Airport",
      ),
      hint: const Text("Select Airport"),
      items: airports
          .map(
            (a) => DropdownMenuItem(
              value: a,
              child: Text(
                "${a.city} - ${a.name}",
                overflow: TextOverflow.ellipsis,
              ),
            ),
          )
          .toList(),
      onChanged: (val) => setState(() => selectedAirport = val),
    ),
  ),


            const SizedBox(height: 16),

            TextField(
              controller: tagController,
              decoration: const InputDecoration(
                labelText: "Tag number",
                border: OutlineInputBorder(),
              ),
            ),

            const SizedBox(height: 16),

            TextField(
              controller: descriptionController,
              maxLines: 3,
              decoration: const InputDecoration(
                labelText: "Description",
                border: OutlineInputBorder(),
              ),
            ),

            const SizedBox(height: 16),

            Row(
              children: [
                ElevatedButton.icon(
                  onPressed: pickImage,
                  icon: const Icon(Icons.image),
                  label: const Text("Choose Image"),
                ),
                const SizedBox(width: 12),
                if (selectedImagePath != null)
                  ClipRRect(
                    borderRadius: BorderRadius.circular(8),
                    child: Image.file(
                      File(selectedImagePath!),
                      width: 70,
                      height: 70,
                      fit: BoxFit.cover,
                    ),
                  )
              ],
            ),
          ],
        ),
      ),
    ),
    actions: [
      TextButton(
        onPressed: submitting ? null : () => Navigator.pop(context),
        child: const Text("Cancel"),
      ),
      ElevatedButton(
        onPressed: submitting ? null : submit,
        style: ElevatedButton.styleFrom(backgroundColor: Colors.red),
        child: submitting
            ? const SizedBox(
                width: 20,
                height: 20,
                child: CircularProgressIndicator(
                  strokeWidth: 2,
                  color: Colors.white,
                ),
              )
            : const Text("Submit"),
      ),
    ],
  );
}

}
