import 'dart:convert';
import 'package:eairflow_desktop/models/checkin.dart';
import 'package:eairflow_desktop/providers/auth_provider.dart';
import 'package:eairflow_desktop/providers/checkin_provider.dart';
import 'package:eairflow_desktop/widgets/animated_scanline.dart';
import 'package:flutter/material.dart';
import 'package:eairflow_desktop/utils/timezone_helper.dart';

class EmployeeCheckInScreen extends StatefulWidget {
  const EmployeeCheckInScreen({super.key});

  @override
  State<EmployeeCheckInScreen> createState() => _EmployeeCheckInScreenState();
}

class _EmployeeCheckInScreenState extends State<EmployeeCheckInScreen> {
  List<CheckIn> checkins = [];
  bool loading = true;
  bool scanning = false;


  @override
  void initState() {
    super.initState();
    loadCheckins();
  }

  Future<void> loadCheckins() async {
  final prov = CheckInProvider();

  try {
    int employeeId = AuthProvider.employeeId!;

    final result = await prov.getForEmployee(employeeId);

    setState(() {
      checkins = result;
      loading = false;
    });
  } catch (e) {
    print("Error loading check-ins: $e");
    setState(() => loading = false);
  }
}


  Color getCheckInColor(String? state) {
    switch (state?.toLowerCase()) {
      case "pending":
        return Colors.amber.shade700;
      case "cancelled":
        return Colors.red.shade700;
      case "completed":
        return Colors.green.shade600;
      default:
        return Colors.grey.shade500;
    }
  }

  Color getCheckInBgColor(String? state) {
    switch (state?.toLowerCase()) {
      case "pending":
        return Colors.amber.shade50;
      case "cancelled":
        return Colors.red.shade100;
      case "completed":
        return Colors.green.shade50;
      default:
        return Colors.grey.shade200;
    }
  }

  @override
  Widget build(BuildContext context) {
    if (loading) return const Center(child: CircularProgressIndicator());

    final visibleCheckins = checkins
      .where((c) => c.stateMachine != "completed")
      .toList();

  if (visibleCheckins.isEmpty) {
    return const Center(
      child: Text(
        "No check-in requests found.",
        style: TextStyle(fontSize: 18),
      ),
    );
  }

    return Padding(
      padding: const EdgeInsets.all(20),
      child: ListView.builder(
        itemCount: checkins.length,
        itemBuilder: (context, index) {
          final c = checkins[index];
          final r = c.reservation;
          final timeZone = r?.airport?.timeZone ?? r?.flight?.airport?.timeZone;
          final departureText =
              formatDateInTimeZone(r?.flight?.departureTime, timeZone);
          final paymentDateText =
              formatDateInTimeZone(r?.payment?.transactionDate, timeZone);

          return Card(
            elevation: 6,
            margin: const EdgeInsets.only(bottom: 20),
            shape: RoundedRectangleBorder(
              borderRadius: BorderRadius.circular(18),
            ),
            child: Padding(
              padding: const EdgeInsets.all(18),
              child: Row(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Expanded(
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(
                          "Reservation - ${r?.airport?.name ?? '-'}",
                          style: const TextStyle(
                            fontSize: 22,
                            fontWeight: FontWeight.bold,
                          ),
                        ),

                        const SizedBox(height: 12),

                        Row(
                          children: [
                            const Icon(Icons.person, size: 20, color: Colors.black54),
                            const SizedBox(width: 6),
                            Text(
                              "Passenger: ${c.user?.name ?? ''} ${c.user?.surname ?? ''}",
                              style: const TextStyle(fontSize: 16),
                            ),
                          ],
                        ),

                        const SizedBox(height: 6),

                        Row(
                          children: [
                            const Icon(Icons.event_seat, size: 20, color: Colors.black54),
                            const SizedBox(width: 6),
                            Text(
                              "${r?.seat?.seatNumber ?? 'N/A'}",
                              style: const TextStyle(fontSize: 16),
                            ),
                          ],
                        ),
                        
                        const SizedBox(height: 6),
                        Row(
                          children: [
                            const Icon(Icons.restaurant, size: 20, color: Colors.black54),
                            const SizedBox(width: 6),
                            Text(
                              "${r?.mealType?.name ?? 'N/A'}",
                              style: const TextStyle(fontSize: 16),
                            ),
                          ],
                        ),

                        const SizedBox(height: 6),

                        Row(
                          children: [
                            const Icon(Icons.flight_takeoff, size: 20, color: Colors.black54),
                            const SizedBox(width: 6),
                            Text(
                              "${r?.flight?.departureLocation} → ${r?.flight?.arrivalLocation}",
                              style: const TextStyle(fontSize: 16),
                            ),
                          ],
                        ),

                        const SizedBox(height: 6),

                        Row(
                          children: [
                            const Icon(Icons.access_time, size: 20, color: Colors.black54),
                            Text(" Departure time:",
                              style: TextStyle(fontSize: 16, fontWeight: FontWeight.w600),
                            ),
                            const SizedBox(width: 6),
                            Text(
                              departureText,
                              style: const TextStyle(fontSize: 16),
                            ),
                          ],
                        ),

                        const SizedBox(height: 12),

                        Row(
                          children: [
                            const Icon(Icons.attach_money, size: 20),
                            const SizedBox(width: 6),
                            const Text(
                              "Amount:",
                              style: TextStyle(fontSize: 16, fontWeight: FontWeight.w600),
                            ),
                            const SizedBox(width: 6),
                            Text("${r?.payment!.amount!.toStringAsFixed(2)}",
                        
                              style: const TextStyle(fontSize: 16),
                            ),
                          ],
                        ),
                        
                        const SizedBox(height: 6),
                        
                        Row(
                          children: [
                            const Icon(Icons.payment, size: 20, color: Colors.black54),
                            const SizedBox(width: 6),
                            const Text(
                              "Method:",
                              style: TextStyle(fontSize: 16, fontWeight: FontWeight.w600),
                            ),
                            const SizedBox(width: 6),
                            Text(
                              r?.payment?.paymentMethod ?? "N/A",
                              style: const TextStyle(fontSize: 16),
                            ),
                          ],
                        ),
                        
                        const SizedBox(height: 6),
                        
                        Row(
                          children: [
                            const Icon(Icons.confirmation_number, size: 20, color: Colors.black54),
                            const SizedBox(width: 6),
                            const Text(
                              "Reference:",
                              style: TextStyle(fontSize: 16, fontWeight: FontWeight.w600),
                            ),
                            const SizedBox(width: 6),
                            Expanded(
                              child: Text(
                                r?.payment?.transactionReference ?? "N/A",
                                style: const TextStyle(fontSize: 16),
                                overflow: TextOverflow.ellipsis,
                              ),
                            ),
                          ],
                        ),
                        
                        const SizedBox(height: 6),
                        
                        Row(
                          children: [
                            const Icon(Icons.calendar_today, size: 20, color: Colors.black54),
                            const SizedBox(width: 6),
                            const Text(
                              "Paid on:",
                              style: TextStyle(fontSize: 16, fontWeight: FontWeight.w600),
                            ),
                            const SizedBox(width: 6),
                            Text(
                              paymentDateText,
                              style: const TextStyle(fontSize: 16),
                            ),
                          ],
                        ),
                        
                        
                        const SizedBox(height: 12),
                        
                        Container(
                          padding: const EdgeInsets.symmetric(horizontal: 12, vertical: 6),
                          decoration: BoxDecoration(
                            color: Colors.blue.shade50,
                            borderRadius: BorderRadius.circular(10),
                          ),
                          child: Text(
                            "Reservation status: ${r?.stateMachine ?? 'N/A'}",
                            style: const TextStyle(
                              color: Colors.blue,
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                        ),

                        const SizedBox(height: 12),

                        Container(
                          padding: const EdgeInsets.all(8),
                          decoration: BoxDecoration(
                            color: getCheckInBgColor(c.stateMachine),
                            borderRadius: BorderRadius.circular(8),
                          ),
                          child: Text(
                            "Check-in status: ${c.stateMachine}",
                            style: TextStyle(
                              color: getCheckInColor(c.stateMachine),
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                        ),

                        
                      ],
                    ),
                  ),

                  const SizedBox(width: 20),

                  Column(
                    children: [
                      if (r?.qrCodeBase64 != null)
                        Stack(
                          children: [
                            Container(
                              width: 200,
                              height: 200,
                              decoration: BoxDecoration(
                                borderRadius: BorderRadius.circular(8),
                                border: Border.all(color: Colors.grey.shade300),
                              ),
                              child: Image.memory(
                                base64Decode(r!.qrCodeBase64!),
                                fit: BoxFit.cover,
                              ),
                            ),

                            AnimatedScanLine(active: scanning,),
                          ],
                        ),

                      const SizedBox(height: 15),

                      if (c.stateMachine == "pending" || c.stateMachine == "confirmed")
                        ElevatedButton(
                          style: ElevatedButton.styleFrom(
                            backgroundColor: Colors.blue.shade600,
                            shape: RoundedRectangleBorder(
                              borderRadius: BorderRadius.circular(8),
                            ),
                          ),
                          onPressed: () async {
                            setState(() => scanning = true);

                            await Future.delayed(const Duration(seconds: 6));
                            final prov = CheckInProvider();
                            await prov.complete(c.checkinId!);

                            ScaffoldMessenger.of(context).showSnackBar(
                              const SnackBar(content: Text("Check-in completed!")),
                            );

                            await loadCheckins();
                            setState(() => scanning = false);
                          },
                          child: const Text("Scan",
                          style: TextStyle(
                            color: Colors.white,
                            fontWeight: FontWeight.bold
                          ),
                          ),
                        ),
                    ],
                  ),
                ],
              ),
            ),
          );
        },
      ),
    );
  }
}

