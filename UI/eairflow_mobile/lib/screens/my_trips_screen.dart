import 'dart:convert';
import 'package:eairflow_mobile/widgets/rate_flight_dialog.dart';
import 'package:flutter/material.dart';
import 'package:eairflow_mobile/providers/auth_provider.dart';
import 'package:eairflow_mobile/providers/reservation_provider.dart';
import 'package:eairflow_mobile/providers/checkin_provider.dart';
import 'package:eairflow_mobile/providers/flight_review_provider.dart';
import 'package:eairflow_mobile/models/reservation.dart';
import 'package:eairflow_mobile/models/flight_review.dart';
import 'package:intl/intl.dart';

class MyTripsMobile extends StatefulWidget {
  const MyTripsMobile({super.key});

  @override
  State<MyTripsMobile> createState() => _MyTripsMobileState();
}

class _MyTripsMobileState extends State<MyTripsMobile> {
  List<Reservation> reservations = [];
  List<FlightReview> userReviews = [];

  bool loading = true;
  bool popupShown = false;

  @override
  void initState() {
    super.initState();
    loadReservations();
  }

  Future<void> loadReservations() async {
    final userId = AuthProvider.userId;
    if (userId == null) return;

    try {
      final reviewProv = FlightReviewProvider();
      userReviews = await reviewProv.getByUser(userId);

      final rProv = ReservationProvider();
      reservations = await rProv.getByUser(userId);
    } catch (e) {
      print("ERROR loading trips: $e");
    }

    if (mounted) {
      setState(() => loading = false);
    }
  }

  Color statusColor(String type, String? state) {
    final s = state?.toLowerCase() ?? "";
    switch (type) {
      case "flight":
        return {
          "delayed": Colors.red.shade400,
          "cancelled": Colors.red.shade700,
          "scheduled": Colors.amber.shade700,
          "completed": Colors.green.shade600,
          "boarding": Colors.blue.shade600,
        }[s] ?? Colors.grey;
      case "checkin":
        return {
          "pending": Colors.amber.shade700,
          "cancelled": Colors.red.shade700,
          "confirmed": Colors.blue.shade600,
          "completed": Colors.green.shade600,
        }[s] ?? Colors.grey;
      default:
        return Colors.grey;
    }
  }

  Color statusBg(String type, String? state) {
    final s = state?.toLowerCase() ?? "";
    switch (type) {
      case "flight":
        return {
          "delayed": Colors.red.shade50,
          "cancelled": Colors.red.shade100,
          "scheduled": Colors.yellow.shade50,
          "completed": Colors.green.shade50,
          "boarding": Colors.blue.shade50,
        }[s] ?? Colors.grey.shade200;
      case "checkin":
        return {
          "pending": Colors.amber.shade50,
          "cancelled": Colors.red.shade100,
          "confirmed": Colors.blue.shade50,
          "completed": Colors.green.shade50,
        }[s] ?? Colors.grey.shade200;
      default:
        return Colors.grey.shade200;
    }
  }

  Future<void> cancelReservation(int id) async {
    try {
      final prov = ReservationProvider();
      await prov.deleteReservation(id);

      setState(() {
        reservations.removeWhere((x) => x.reservationId == id);
      });
    } catch (e) {
      print("Cancel Error: $e");
    }
  }

  @override
  Widget build(BuildContext context) {
    if (loading) return const Center(child: CircularProgressIndicator());

    if (reservations.isEmpty) {
      return const Center(
        child: Text("You currently have no trips.",
            style: TextStyle(fontSize: 18)),
      );
    }

    return SingleChildScrollView(
      padding: const EdgeInsets.all(12),
      child: Column(
        children: reservations.map((r) {
          bool alreadyReviewed =
              userReviews.any((rev) => rev.flightId == r.flightId);

          final df = DateFormat("yyyy-MM-dd HH:mm");
          if (!popupShown &&
              r.flight?.stateMachine?.toLowerCase() == "completed" &&
              !alreadyReviewed) {
            popupShown = true;
            WidgetsBinding.instance.addPostFrameCallback((_) {
              showRateDialog(context, AuthProvider.userId!, r.flight!);
            });
          }

          return Card(
            margin: const EdgeInsets.only(bottom: 18),
            shape: RoundedRectangleBorder(
              borderRadius: BorderRadius.circular(16),
            ),
            elevation: 4,
            child: Padding(
              padding: const EdgeInsets.all(14),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  if (r.airport?.name != null)
                    Text(
                      r.airport!.name!,
                      style: const TextStyle(
                        fontSize: 20,
                        fontWeight: FontWeight.w800,
                      ),
                    ),

                  const SizedBox(height: 8),

                  Text(
                          "${r.flight?.departureLocation ?? 'Unknown'} → ${r.flight?.arrivalLocation ?? 'Unknown'}",
                          style: const TextStyle(
                            fontSize: 22,
                            fontWeight: FontWeight.bold,
                          ),
                        ),

                        const SizedBox(height: 12),

                        Row(
                          children: [
                            const Icon(Icons.access_time, size: 20, color: Colors.black54),
                            Text(
                              " Departure time:",
                              style: TextStyle(fontSize: 16, fontWeight: FontWeight.w600),
                            ),
                            const SizedBox(width: 6),
                            Text(
                              r.flight?.departureTime != null
                                ? df.format(r.flight!.departureTime!)
                                : 'N/A',
                              style: const TextStyle(fontSize: 16),
                            )

                          ],
                        ),

                        const SizedBox(height: 6),

                        Row(
                          children: [
                            const Icon(Icons.airline_seat_recline_normal, size: 20, color: Colors.black54),
                            const SizedBox(width: 6),
                            Text(
                              r.seatNumber ?? 'N/A',
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
                              r.mealType?.name ?? 'N/A',
                              style: const TextStyle(fontSize: 16),
                            ),
                          ],
                        ),

                        const SizedBox(height: 6),

                        Row(
                          children: [
                            const Icon(Icons.attach_money, size: 20, color: Colors.black54),
                            const SizedBox(width: 6),
                            Text(
                              "${r.flight?.price ?? 'N/A'}",
                              style: const TextStyle(fontSize: 16),

                            ),
                          ],
                        ),

                        const SizedBox(height: 6),

                        Row(
                          children: [
                            const Icon(Icons.calendar_today, size: 20, color: Colors.black54),
                            Text(
                              " Reservation made:",
                              style: TextStyle(fontSize: 16, fontWeight: FontWeight.w600),
                            ),
                            const SizedBox(width: 6),
                            Text(
                              r.reservationDate != null
                                ? df.format(DateTime.parse(r.reservationDate!))
                                : 'N/A',
                              style: const TextStyle(fontSize: 16),
                            ),
                          ],
                        ),

                  const SizedBox(height: 10),

                  Container(
                    padding:
                        const EdgeInsets.symmetric(horizontal: 10, vertical: 6),
                    decoration: BoxDecoration(
                      color: Colors.green.shade50,
                      borderRadius: BorderRadius.circular(10),
                    ),
                    child: Text(
                      "Reservation: ${r.stateMachine ?? 'N/A'}",
                      style: const TextStyle(
                        color: Colors.green,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                  ),

                  const SizedBox(height: 10),

                  Container(
                    padding:
                        const EdgeInsets.symmetric(horizontal: 10, vertical: 6),
                    decoration: BoxDecoration(
                      color: statusBg("flight", r.flight?.stateMachine),
                      borderRadius: BorderRadius.circular(10),
                    ),
                    child: Text(
                      "Flight: ${r.flight?.stateMachine ?? 'N/A'}",
                      style: TextStyle(
                        color:
                            statusColor("flight", r.flight?.stateMachine),
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                  ),

                  const SizedBox(height: 10),

                  Container(
                    padding:
                        const EdgeInsets.symmetric(horizontal: 10, vertical: 6),
                    decoration: BoxDecoration(
                      color: statusBg("checkin", r.checkIn?.stateMachine),
                      borderRadius: BorderRadius.circular(10),
                    ),
                    child: Text(
                      "Check-in: ${r.checkIn?.stateMachine ?? 'N/A'}",
                      style: TextStyle(
                        color:
                            statusColor("checkin", r.checkIn?.stateMachine),
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                  ),

                  const SizedBox(height: 16),

                  if (r.qrCodeBase64 != null)
                    Center(
                      child: Container(
                        width: 170,
                        height: 170,
                        padding: const EdgeInsets.all(8),
                        decoration: BoxDecoration(
                          borderRadius: BorderRadius.circular(12),
                          border: Border.all(color: Colors.grey.shade300),
                        ),
                        child: Image.memory(
                          base64Decode(r.qrCodeBase64!),
                          fit: BoxFit.cover,
                        ),
                      ),
                    ),

                  const SizedBox(height: 16),

                  Row(
                    children: [
                      if (r.flight?.stateMachine?.toLowerCase() != "completed")
                        Expanded(
                          child: ElevatedButton(
                            onPressed: () =>
                                cancelReservation(r.reservationId ?? 0),
                            style: ElevatedButton.styleFrom(
                              backgroundColor: Colors.red.shade400,
                            ),
                            child: const Text("Cancel"),
                          ),
                        ),
                  
                      if (r.flight?.stateMachine?.toLowerCase() != "completed")
                        const SizedBox(width: 10),
                  
                      if (r.flight?.stateMachine?.toLowerCase() == "boarding" &&
                          r.checkIn == null)
                        Expanded(
                          child: ElevatedButton(
                            onPressed: () async {
                              final cProv = CheckInProvider();
                              await cProv.insert({
                                "reservationId": r.reservationId,
                                "checkinTime": DateTime.now().toIso8601String(),
                                "userId": AuthProvider.userId,
                                "seatId": null,
                              });
                  
                              ScaffoldMessenger.of(context).showSnackBar(
                                const SnackBar(content: Text("Check-in requested")),
                              );
                  
                              await loadReservations();
                            },
                            style: ElevatedButton.styleFrom(
                              backgroundColor: Colors.blue,
                            ),
                            child: const Text("Check-In"),
                          ),
                        ),
                    ],
                  ),

                ],
              ),
            ),
          );
        }).toList(),
      ),
    );
  }
}
