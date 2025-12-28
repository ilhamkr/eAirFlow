import 'dart:io';
import 'package:eairflow_mobile/models/airport.dart';
import 'package:eairflow_mobile/providers/airport_provider.dart';
import 'package:eairflow_mobile/providers/auth_provider.dart';
import 'package:eairflow_mobile/providers/luggage_provider.dart';
import 'package:flutter/material.dart';
import 'package:image_picker/image_picker.dart';
import 'package:eairflow_mobile/models/checkin.dart';
import 'package:eairflow_mobile/providers/checkin_provider.dart';
import 'package:intl/intl.dart';

class ReportLostDialogMobile extends StatefulWidget {
  final VoidCallback? onSubmitted;

  const ReportLostDialogMobile({super.key, this.onSubmitted});

  @override
  State<ReportLostDialogMobile> createState() => _ReportLostDialogMobileState();
}

class _ReportLostDialogMobileState extends State<ReportLostDialogMobile> {
  final _formKey = GlobalKey<FormState>();

  final TextEditingController descriptionController = TextEditingController();
  final TextEditingController tagController = TextEditingController();

  String? selectedImagePath;
  Airport? selectedAirport;
  CheckIn? selectedCheckIn;

  bool loadingData = true;
  bool submitting = false;

  List<Airport> airports = [];
  List<CheckIn> checkIns = [];

  @override
  void initState() {
    super.initState();
    loadData();
  }

   Future<void> loadData() async {
    try {
      airports = await AirportProvider().getAll();
      if (airports.isNotEmpty) {
        selectedAirport = airports.first;
      }

      final userId = AuthProvider.userId;
      if (userId != null) {
        checkIns = await CheckInProvider().getForUser(userId);

        if (checkIns.isNotEmpty) {
          selectedCheckIn = checkIns.first;
        }
      }
    } finally {
      if (mounted) setState(() => loadingData = false);
    }
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
    if (!_formKey.currentState!.validate()) return;

    if (selectedImagePath == null || selectedAirport == null) {
      setState(() {});
      return;
    }

    

    final userId = AuthProvider.userId!;
    selectedCheckIn ??= checkIns.isNotEmpty ? checkIns.first : null;
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
      Navigator.pop(context);
      widget.onSubmitted?.call();
    }
  }

  @override
  Widget build(BuildContext context) {
    String flightLabel(CheckIn c) {
      final flight = c.reservation?.flight;
      final departure = flight?.departureLocation ?? "";
      final arrival = flight?.arrivalLocation ?? "";
      final date = flight?.departureTime != null
          ? DateFormat('dd.MM.yyyy HH:mm').format(flight!.departureTime!)
          : "";
      return "$departure → $arrival ${date.isNotEmpty ? "- $date" : ""}".trim();
    }

    return AlertDialog(
      title: const Text("Report Lost Luggage"),
      content: Form(
        key: _formKey,
        child: SingleChildScrollView(
          child: SizedBox(
            width: MediaQuery.of(context).size.width * 0.85,
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [

                DropdownButtonFormField<Airport>(
                  isExpanded: true,
                  value: selectedAirport,
                  decoration: const InputDecoration(
                    border: OutlineInputBorder(),
                    labelText: "Airport",
                  ),
                  items: airports.map((a) => DropdownMenuItem(
                        value: a,
                        child: Text("${a.city} - ${a.name}"),
                      )).toList(),
                  onChanged: (val) => setState(() => selectedAirport = val),
                  validator: (v) =>
                      v == null ? "Airport is required" : null,
                ),

                const SizedBox(height: 14),

                if (loadingData)
                  const Center(child: CircularProgressIndicator())
                else if (checkIns.isEmpty)
                  const Padding(
                    padding: EdgeInsets.symmetric(vertical: 8),
                    child: Text(
                      "You need a completed check-in to report lost luggage.",
                      style: TextStyle(color: Colors.red),
                    ),
                  )
                else
                  InputDecorator(
                    decoration: const InputDecoration(
                      border: OutlineInputBorder(),
                      labelText: "Flight",
                    ),
                    child: Text(
                      selectedCheckIn != null
                          ? flightLabel(selectedCheckIn!)
                          : "No flight available",
                    ),
                  ),

                const SizedBox(height: 14),

                TextFormField(
                  controller: tagController,
                  decoration: const InputDecoration(
                    labelText: "Tag number",
                    border: OutlineInputBorder(),
                  ),
                  validator: (v) =>
                      v == null || v.trim().isEmpty ? "Tag is required" : null,
                ),

                const SizedBox(height: 14),

                TextFormField(
                  controller: descriptionController,
                  maxLines: 3,
                  decoration: const InputDecoration(
                    labelText: "Description",
                    border: OutlineInputBorder(),
                  ),
                  validator: (v) =>
                      v == null || v.trim().isEmpty ? "Description is required" : null,
                ),

                const SizedBox(height: 14),
                
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

                if (selectedImagePath == null)
                  const Padding(
                    padding: EdgeInsets.only(top: 6),
                    child: Text(
                      "Image is required",
                      style: TextStyle(color: Colors.red, fontSize: 12),
                    ),
                  ),
              ],
            ),
          ),
        ),
      ),

      actions: [
        TextButton(
          onPressed: submitting ? null : () => Navigator.pop(context),
          child: const Text("Cancel"),
        ),

        ElevatedButton(
          onPressed: submitting || loadingData || checkIns.isEmpty ? null : submit,
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

