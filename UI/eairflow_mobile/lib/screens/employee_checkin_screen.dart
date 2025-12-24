import 'dart:convert';
import 'package:eairflow_mobile/providers/auth_provider.dart';
import 'package:flutter/material.dart';
import 'package:eairflow_mobile/models/checkin.dart';
import 'package:eairflow_mobile/providers/checkin_provider.dart';
import 'package:eairflow_mobile/utils/timezone_helper.dart';

class EmployeeCheckInScreen extends StatefulWidget {
  const EmployeeCheckInScreen({super.key});

  @override
  State<EmployeeCheckInScreen> createState() =>
      _EmployeeCheckInScreenMobileState();
}

class _EmployeeCheckInScreenMobileState
    extends State<EmployeeCheckInScreen> {
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
        return Colors.grey.shade100;
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

    return ListView.builder(
      padding: const EdgeInsets.all(16),
      itemCount: checkins.length,
      itemBuilder: (context, index) {
        final c = checkins[index];
        final r = c.reservation;
        final timeZoneId = r?.airport?.timeZoneId ?? r?.flight?.airport?.timeZoneId;
        final departureText =
            formatDateInTimeZone(r?.flight?.departureTime, timeZoneId);
        final paymentDateText =
            formatDateInTimeZone(r?.payment?.transactionDate, timeZoneId);

        return Card(
          elevation: 5,
          margin: const EdgeInsets.only(bottom: 18),
          shape: RoundedRectangleBorder(
            borderRadius: BorderRadius.circular(16),
          ),
          child: Padding(
            padding: const EdgeInsets.all(16),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [

                const SizedBox(height: 12),

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
                              r?.seatNumber?.toString() ?? 'N/A',
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
                              r?.flight?.departureTime != null
                                  ? departureText
                                  : "N/A",
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
                              r?.payment?.transactionDate != null
                                  ? paymentDateText
                                  : "N/A",
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
                  padding: const EdgeInsets.symmetric(
                    horizontal: 12,
                    vertical: 6,
                  ),
                  decoration: BoxDecoration(
                    color: getCheckInBgColor(c.stateMachine),
                    borderRadius: BorderRadius.circular(10),
                  ),
                  child: Text(
                    "Check-in status: ${c.stateMachine}",
                    style: TextStyle(
                      color: getCheckInColor(c.stateMachine),
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                ),

                const SizedBox(height: 16),

                if (r?.qrCodeBase64 != null)
                  Center(
                    child: Container(
                      width: 180,
                      height: 180,
                      decoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(12),
                        border: Border.all(color: Colors.grey.shade300),
                      ),
                      child: Image.memory(
                        base64Decode(r!.qrCodeBase64!),
                        fit: BoxFit.cover,
                      ),
                    ),
                  ),

                const SizedBox(height: 20),

                if (c.stateMachine == "pending" ||
                    c.stateMachine == "confirmed")
                  SizedBox(
                    width: double.infinity,
                    child: ElevatedButton(
                      style: ElevatedButton.styleFrom(
                        backgroundColor: Colors.blue.shade700,
                        padding: const EdgeInsets.symmetric(vertical: 14),
                        shape: RoundedRectangleBorder(
                          borderRadius: BorderRadius.circular(12),
                        ),
                      ),
                      onPressed: () async {
                        setState(() => scanning = true);

                        await Future.delayed(const Duration(seconds: 4));
                        final prov = CheckInProvider();
                        await prov.complete(c.checkinId!);

                        if (mounted) {
                          ScaffoldMessenger.of(context).showSnackBar(
                            const SnackBar(
                                content: Text("Check-in completed!")),
                          );
                        }

                        await loadCheckins();
                        setState(() => scanning = false);
                      },
                      child: scanning
                          ? const SizedBox(
                              width: 20,
                              height: 20,
                              child: CircularProgressIndicator(
                                strokeWidth: 3,
                                color: Colors.white,
                              ),
                            )
                          : const Text(
                              "Scan",
                              style: TextStyle(
                                fontSize: 16,
                                color: Colors.white,
                                fontWeight: FontWeight.bold,
                              ),
                            ),
                    ),
                  ),
              ],
            ),
          ),
        );
      },
    );
  }
}
