import 'dart:io';
import 'package:eairflow_desktop/models/airport.dart';
import 'package:eairflow_desktop/providers/airport_provider.dart';
import 'package:eairflow_desktop/providers/auth_provider.dart';
import 'package:eairflow_desktop/providers/luggage_provider.dart';
import 'package:file_picker/file_picker.dart';
import 'package:flutter/material.dart';
import 'package:eairflow_desktop/models/checkin.dart';
import 'package:eairflow_desktop/providers/checkin_provider.dart';
import 'package:intl/intl.dart';

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
  CheckIn? selectedCheckIn;

  bool submitting = false;
  List<Airport> airports = [];
  List<CheckIn> checkIns = [];

  bool tagError = false;
  bool descriptionError = false;
  bool airportError = false;
  bool imageError = false;
  bool flightError = false;
  bool loadingData = true;

  @override
  void initState() {
    super.initState();
    loadData();
  }

   Future<void> loadData() async {
    try {
      final userId = AuthProvider.userId;
      if (userId != null) {
        checkIns = await CheckInProvider().getForUser(userId);
        final seenReservations = <int>{};
        checkIns = checkIns
            .where((c) =>
                c.reservationId != null && seenReservations.add(c.reservationId!))
            .toList();
        if (checkIns.isNotEmpty) {
          selectedCheckIn = checkIns.first;
          selectedAirport = selectedCheckIn?.reservation?.airport ??
              selectedCheckIn?.reservation?.flight?.airport;
        }
      }
      airportError = checkIns.isNotEmpty && selectedAirport == null;
    } finally {
      setState(() => loadingData = false);
    }
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
      flightError = checkIns.isNotEmpty && selectedCheckIn == null;
      imageError = selectedImagePath == null;
    });
  }

  Future<void> submit() async {
  validate();

  if (tagError || descriptionError || airportError || flightError || imageError) {
    return;
  }

  final userId = AuthProvider.userId!;
  setState(() => submitting = true);

  final success = await LuggageProvider().reportLost(
    userId: userId,
    flightId: selectedCheckIn?.reservation?.flightId ?? 0,
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
   String flightLabel(CheckIn c) {
      final flight = c.reservation?.flight;
      final departure = flight?.departureLocation ?? "";
      final arrival = flight?.arrivalLocation ?? "";
      final airport = c.reservation?.airport?.name ??
          flight?.airport?.name ??
          "";
      final date = flight?.departureTime != null
          ? DateFormat('dd.MM.yyyy HH:mm').format(flight!.departureTime!)
          : "";
      return "$departure → $arrival ${date.isNotEmpty ? "- $date" : ""} - $airport".trim();
    }

    return AlertDialog(
      title: const Text("Report Lost Luggage"),
      content: SizedBox(
        width: 460,
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
           if (loadingData)
              const Center(child: CircularProgressIndicator())
            else if (checkIns.isEmpty)
              const Align(
                alignment: Alignment.centerLeft,
                child: Padding(
                  padding: EdgeInsets.symmetric(vertical: 8),
                ),
              ),
           

            if (selectedAirport != null)
              Padding(
                padding: const EdgeInsets.only(top: 12),
                child: Align(
                  alignment: Alignment.centerLeft,
                  child: Text(
                    "Airport: ${selectedAirport!.city} - ${selectedAirport!.name}",
                    style: const TextStyle(fontWeight: FontWeight.w600),
                  ),
                ),
              ),

            const SizedBox(height: 12),

            if (loadingData)
              const Center(child: CircularProgressIndicator())
            else if (checkIns.isEmpty)
              const Align(
                alignment: Alignment.centerLeft,
                child: Padding(
                  padding: EdgeInsets.symmetric(vertical: 8),
                  child: Text(
                    "You need a completed check-in to report lost luggage.",
                    style: TextStyle(color: Colors.red),
                  ),
                ),
              )
            else
              DropdownButtonFormField<CheckIn>(
                hint: const Text("Select Flight"),
                value: selectedCheckIn,
                items: checkIns
                    .map((c) => DropdownMenuItem(
                          value: c,
                          child: Text(flightLabel(c)),
                        ))
                    .toList(),
                onChanged: (val) {
                  setState(() {
                    selectedCheckIn = val;
                    flightError = false;
                  });
                },
                decoration: InputDecoration(
                  errorText: flightError ? "Flight is required" : null,
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
          onPressed: submitting || loadingData || checkIns.isEmpty ? null : submit,
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
