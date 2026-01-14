import 'dart:convert';
import 'package:eairflow_desktop/models/flight_review.dart';
import 'package:eairflow_desktop/models/reservation.dart';
import 'package:eairflow_desktop/providers/checkin_provider.dart';
import 'package:eairflow_desktop/providers/flight_review_provider.dart';
import 'package:eairflow_desktop/providers/reservation_provider.dart';
import 'package:eairflow_desktop/widgets/rate_flight_dialog.dart';
import 'package:flutter/material.dart';
import '../providers/auth_provider.dart';
import 'package:eairflow_desktop/utils/timezone_helper.dart';

class MyTripsScreen extends StatefulWidget {
  const MyTripsScreen({super.key});

  @override
  State<MyTripsScreen> createState() => _MyTripsScreenState();
}

class _MyTripsScreenState extends State<MyTripsScreen> {
  List<Reservation> reservations = [];
  bool loading = true;
  bool popupShown = false;
  List<FlightReview> userReviews = [];

  Color getFlightColor(String? state) {
    switch (state?.toLowerCase()) {
      case "delayed":
        return Colors.red.shade400;
      case "cancelled":
        return Colors.red.shade700;
      case "scheduled":
        return Colors.amber.shade700;
      case "completed":
        return Colors.green.shade600;
      case "boarding":
        return Colors.blue.shade600;
      default:
        return Colors.grey.shade500;
    }
  }

  Color getFlightBgColor(String? state) {
    switch (state?.toLowerCase()) {
      case "delayed":
        return Colors.red.shade50;
      case "cancelled":
        return Colors.red.shade100;
      case "scheduled":
        return Colors.yellow.shade50;
      case "completed":
        return Colors.green.shade50;
      case "boarding":
        return Colors.blue.shade50;
      default:
        return Colors.grey.shade200;
    }
  }

  Color getCheckInColor(String? state) {
    switch (state?.toLowerCase()) {
      case "pending":
        return Colors.amber.shade700;
      case "cancelled":
        return Colors.red.shade700;
      case "confirmed":
        return Colors.blue.shade600;
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
      case "confirmed":
        return Colors.blue.shade50;
      case "completed":
        return Colors.green.shade50;
      default:
        return Colors.grey.shade200;
    }
  }

   Widget _infoChip(IconData icon, String label, String value) {
    return Container(
      padding: const EdgeInsets.symmetric(horizontal: 10, vertical: 8),
      decoration: BoxDecoration(
        color: Colors.white,
        borderRadius: BorderRadius.circular(10),
        border: Border.all(color: Colors.grey.shade200),
        boxShadow: [
          BoxShadow(
            color: Colors.black.withOpacity(0.03),
            blurRadius: 6,
            offset: const Offset(0, 2),
          ),
        ],
      ),
      child: Row(
        mainAxisSize: MainAxisSize.min,
        children: [
          Icon(icon, size: 18, color: Colors.blueGrey.shade600),
          const SizedBox(width: 6),
          Text(
            "$label: ",
            style: const TextStyle(
              fontSize: 13,
              fontWeight: FontWeight.w600,
              color: Colors.black87,
            ),
          ),
          Flexible(
            child: Text(
              value,
              style: const TextStyle(fontSize: 13, color: Colors.black87),
              overflow: TextOverflow.ellipsis,
            ),
          ),
        ],
      ),
    );
  }

  Widget _buildPassengerDetails(List<Widget> infoItems) {
    return Container(
      width: double.infinity,
      padding: const EdgeInsets.all(14),
      decoration: BoxDecoration(
        color: Colors.blueGrey.shade50,
        borderRadius: BorderRadius.circular(14),
        border: Border.all(color: Colors.blueGrey.shade100),
      ),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          const Text(
            "Passenger details",
            style: TextStyle(
              fontSize: 16,
              fontWeight: FontWeight.bold,
              color: Colors.black87,
            ),
          ),
          const SizedBox(height: 10),
          Wrap(
            spacing: 10,
            runSpacing: 10,
            children: infoItems,
          ),
        ],
      ),
    );
  }

  Future<bool> confirmCancelReservation() async {
  return await showDialog(
    context: context,
    builder: (_) => AlertDialog(
      title: const Text("Cancel Reservation"),
      content: const Text("Are you sure you want to cancel this reservation?"),
      actions: [
        TextButton(
          onPressed: () => Navigator.pop(context, false),
          child: const Text("No"),
        ),
        ElevatedButton(
          style: ElevatedButton.styleFrom(backgroundColor: Colors.red),
          onPressed: () => Navigator.pop(context, true),
          child: const Text("Yes, cancel"),
        ),
      ],
    ),
  );
}


  @override
  void initState() {
    super.initState();
    loadReservations();
  }

  Future<void> loadReservations({bool showLoading = true}) async {
    final userId = AuthProvider.userId;

    if (userId == null) {
      setState(() => loading = false);
      return;
    }

     if (showLoading && mounted) {
      setState(() => loading = true);
    }

    final reviewProv = FlightReviewProvider();
    userReviews = await reviewProv.getByUser(userId);

    final provider = ReservationProvider();

    try {
      var result = await provider.getByUser(userId);
      setState(() {
        reservations = result;
        reservations.sort((a, b) {
        final aCompleted = a.flight?.stateMachine?.toLowerCase() == "completed";
        final bCompleted = b.flight?.stateMachine?.toLowerCase() == "completed";
      
        if (!aCompleted && bCompleted) return -1;
        if (aCompleted && !bCompleted) return 1;
      
        if (!aCompleted && !bCompleted) {
          final aDate = a.flight?.departureTime ?? DateTime.now();
          final bDate = b.flight?.departureTime ?? DateTime.now();
          return aDate.compareTo(bDate);
        }
      
        final aDate = a.flight?.departureTime ?? DateTime.now();
        final bDate = b.flight?.departureTime ?? DateTime.now();
        return bDate.compareTo(aDate);
      });
        loading = false;
      });
    } catch (e) {
      print("ERROR loading reservations: $e");
      setState(() => loading = false);
    }
  }

  Future<void> cancelReservation(int reservationId) async {
  final provider = ReservationProvider();

  try {
    await provider.deleteReservation(reservationId);

    setState(() {
      reservations.removeWhere((r) => r.reservationId == reservationId);
    });

    ScaffoldMessenger.of(context).showSnackBar(
      const SnackBar(
        content: Text("Reservation successfully cancelled."),
        backgroundColor: Colors.green,
      ),
    );
  } catch (e) {
    ScaffoldMessenger.of(context).showSnackBar(
      const SnackBar(
        content: Text("Error cancelling reservation."),
        backgroundColor: Colors.red,
      ),
    );
  }
}


  @override
  Widget build(BuildContext context) {
    if (loading) {
      return const Center(child: CircularProgressIndicator());
    }

    if (reservations.isEmpty) {
      return const Center(
        child: Text(
          "You currently have no trips.",
          style: TextStyle(fontSize: 18),
        ),
      );
    }

     return RefreshIndicator(
      onRefresh: () => loadReservations(showLoading: false),
      child: Padding(
        padding: const EdgeInsets.all(20),
        child: ListView.builder(
          physics: const AlwaysScrollableScrollPhysics(),
          itemCount: reservations.length,
          itemBuilder: (context, index) {
            final r = reservations[index];
            final timeZone = r.flight?.departureTimeZone ?? "UTC";
          final departureText = formatDateInTimeZone(r.flight?.departureTime, timeZone);
          final reservationDateText = r.reservationDate != null
              ? formatDateInTimeZone(DateTime.parse(r.reservationDate!), timeZone)
              : 'N/A';
          final addressParts = [
            r.address,
            r.city,
            r.country,
          ].where((value) => value != null && value.trim().isNotEmpty).toList();
          final addressLine = addressParts.join(", ");
          final profileName = AuthProvider.name?.trim() ?? "";
          final profileSurname = AuthProvider.surname?.trim() ?? "";
          final profileEmail = AuthProvider.email?.trim() ?? "";
          final profilePhone = AuthProvider.phoneNumber?.trim() ?? "";
          final infoItems = <Widget>[
             if (profileName.isNotEmpty)
              _infoChip(Icons.person, "Name", profileName),
            if (profileSurname.isNotEmpty)
              _infoChip(Icons.person_outline, "Surname", profileSurname),
            if (profileEmail.isNotEmpty)
              _infoChip(Icons.email, "Email", profileEmail),
            if (profilePhone.isNotEmpty)
              _infoChip(Icons.phone, "Phone", profilePhone),
            if (r.dateOfBirth != null && r.dateOfBirth!.trim().isNotEmpty)
              _infoChip(Icons.cake, "Date of birth", r.dateOfBirth!),
            if (addressLine.isNotEmpty)
              _infoChip(Icons.location_on, "Address", addressLine),
            if (r.passportNumber != null && r.passportNumber!.trim().isNotEmpty)
              _infoChip(Icons.badge, "Passport", r.passportNumber!),
            if (r.citizenship != null && r.citizenship!.trim().isNotEmpty)
              _infoChip(Icons.public, "Citizenship", r.citizenship!),
            if (r.baggageInfo != null && r.baggageInfo!.trim().isNotEmpty)
              _infoChip(Icons.luggage, "Baggage", r.baggageInfo!),
          ];

          bool alreadyReviewed = userReviews.any(
            (rev) => rev.flightId == r.flightId,
          );

          if (!popupShown &&
              r.flight?.stateMachine?.toLowerCase() == "completed" &&
              !alreadyReviewed) {
            popupShown = true;
            WidgetsBinding.instance.addPostFrameCallback((_) {
              showRateDialog(context, AuthProvider.userId!, r.flight!);
            });
          }

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
                        if (r.airport?.name != null)
                          Text(
                            r.airport!.name!,
                            style: const TextStyle(
                              fontSize: 28,
                              fontWeight: FontWeight.bold,
                            ),
                          ),

                        const SizedBox(height: 12),

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
                              departureText,
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
                              "${r.seat?.seatNumber ?? 'N/A'}",
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
                              "${r.mealType?.name ?? 'N/A'}",
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
                              reservationDateText,
                              style: const TextStyle(fontSize: 16),
                            ),
                          ],
                        ),

                        const SizedBox(height: 12),

                         if (infoItems.isNotEmpty) ...[
                          _buildPassengerDetails(infoItems),
                          const SizedBox(height: 12),
                        ],

                        Container(
                          padding: const EdgeInsets.symmetric(
                            horizontal: 12,
                            vertical: 6,
                          ),
                          decoration: BoxDecoration(
                            color: Colors.green.shade50,
                            borderRadius: BorderRadius.circular(10),
                          ),
                          child: Text(
                            "Reservation status: ${r.stateMachine ?? 'Pending'}",
                            style: const TextStyle(
                              color: Colors.green,
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                        ),

                        const SizedBox(height: 12),

                        Container(
                          padding: const EdgeInsets.symmetric(horizontal: 12, vertical: 6),
                          decoration: BoxDecoration(
                            color: getFlightBgColor(r.flight?.stateMachine),
                            borderRadius: BorderRadius.circular(10),
                          ),
                          child: Text(
                            "Flight status: ${r.flight?.stateMachine ?? 'N/A'}",
                            style: TextStyle(
                              color: getFlightColor(r.flight?.stateMachine),
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                        ),

                        const SizedBox(height: 12),

                        Container(
                          padding: const EdgeInsets.symmetric(horizontal: 12, vertical: 6),
                          decoration: BoxDecoration(
                            color: getCheckInBgColor(r.checkIn?.stateMachine),
                            borderRadius: BorderRadius.circular(10),
                          ),
                          child: Text(
                            "Check-in status: ${r.checkIn?.stateMachine ?? 'N/A'}",
                            style: TextStyle(
                              color: getCheckInColor(r.checkIn?.stateMachine),
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                        ),
                      ],
                    ),
                  ),

                  const SizedBox(width: 15),

                  Column(
                    children: [
                      if (r.qrCodeBase64 != null)
                        Container(
                          width: 200,
                          height: 200,
                          decoration: BoxDecoration(
                            borderRadius: BorderRadius.circular(8),
                            border: Border.all(color: Colors.grey.shade300),
                          ),
                          child: Image.memory(
                            base64Decode(r.qrCodeBase64!),
                            fit: BoxFit.cover,
                          ),
                        ),

                      const SizedBox(height: 50),

                      if (r.flight?.stateMachine?.toLowerCase() != "completed")
                        ElevatedButton(
                          style: ElevatedButton.styleFrom(
                            backgroundColor: Colors.red.shade400,
                            shape: RoundedRectangleBorder(
                              borderRadius: BorderRadius.circular(8),
                            ),
                          ),
                          onPressed: () async {
                            final ok = await confirmCancelReservation();
                            if (!ok) return;
                          
                            await cancelReservation(r.reservationId ?? 0);
                          },

                          child: const Text("Cancel"),
                        ),

                      const SizedBox(height: 12),

                      if (r.flight?.stateMachine?.toLowerCase() == "boarding" &&
                          r.checkIn == null)
                        ElevatedButton(
                          style: ElevatedButton.styleFrom(
                            backgroundColor: Colors.blue.shade600,
                            shape: RoundedRectangleBorder(
                              borderRadius: BorderRadius.circular(8),
                            ),
                          ),
                          onPressed: () async {
                            final checkProv = CheckInProvider();

                            await checkProv.insert({
                              "reservationId": r.reservationId,
                              "seatId": null,
                              "checkinTime": DateTime.now().toIso8601String(),
                              "userId": AuthProvider.userId
                            });

                            ScaffoldMessenger.of(context).showSnackBar(
                              const SnackBar(content: Text("Check-in requested.")),
                            );

                            await loadReservations();
                          },
                          child: const Text("Check-In"),
                        ),
                    ],
                  ),
                ],
              ),
            ),
          );
          },
        ),
      ),
    );
  }
}
