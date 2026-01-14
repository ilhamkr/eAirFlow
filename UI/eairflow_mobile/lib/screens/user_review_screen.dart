import 'package:eairflow_mobile/models/flight_review.dart';
import 'package:eairflow_mobile/models/reservation.dart';
import 'package:eairflow_mobile/providers/auth_provider.dart';
import 'package:eairflow_mobile/providers/flight_review_provider.dart';
import 'package:eairflow_mobile/providers/reservation_provider.dart';
import 'package:eairflow_mobile/widgets/rate_flight_dialog.dart';
import 'package:flutter/material.dart';

class UserReviewsScreenMobile extends StatefulWidget {
  const UserReviewsScreenMobile({super.key});

  @override
  State<UserReviewsScreenMobile> createState() => _UserReviewsScreenMobileState();
}

class _UserReviewsScreenMobileState extends State<UserReviewsScreenMobile> {
  List<Reservation> completedReservations = [];
  List<FlightReview> reviews = [];
  bool loading = true;

  @override
  void initState() {
    super.initState();
    loadData();
  }

  Future<void> loadData() async {
    final userId = AuthProvider.userId!;
    final reservationProv = ReservationProvider();
    final reviewProv = FlightReviewProvider();

    final allReservations = await reservationProv.getByUser(userId);

    completedReservations = allReservations
        .where((r) => r.flight?.stateMachine?.toLowerCase() == "completed")
        .toList();

    reviews = await reviewProv.getByUser(userId);

    setState(() => loading = false);
  }

  @override
  Widget build(BuildContext context) {
    if (loading) return const Center(child: CircularProgressIndicator());

    return DefaultTabController(
      length: 2,
      child: Scaffold(
        backgroundColor: Colors.white,
        appBar: AppBar(
          title: const Text("My Reviews"),
          bottom: const TabBar(
            indicatorColor: Colors.blue,
            tabs: [
              Tab(icon: Icon(Icons.pending_actions), text: "To Review"),
              Tab(icon: Icon(Icons.star), text: "Reviewed"),
            ],
          ),
        ),
        body: TabBarView(
          children: [
            PendingReviewsMobile(
              reservations: completedReservations,
              reviews: reviews,
              refresh: loadData,
            ),
            CompletedReviewsMobile(reviews: reviews),
          ],
        ),
      ),
    );
  }
}


class PendingReviewsMobile extends StatelessWidget {
  final List<Reservation> reservations;
  final List<FlightReview> reviews;
  final Future<void> Function() refresh;

  const PendingReviewsMobile({
    super.key,
    required this.reservations,
    required this.reviews,
    required this.refresh,
  });

  @override
  Widget build(BuildContext context) {
    final pending = reservations.where(
      (r) => !reviews.any((rev) => rev.flightId == r.flightId),
    ).toList();

    if (pending.isEmpty) {
      return const Center(
        child: Text(
          "All flights reviewed ✔",
          style: TextStyle(fontSize: 18),
        ),
      );
    }

    return ListView.builder(
      padding: const EdgeInsets.all(14),
      itemCount: pending.length,
      itemBuilder: (context, index) {
        final r = pending[index];

        return Card(
          shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(14)),
          elevation: 3,
          margin: const EdgeInsets.only(bottom: 16),
          child: Padding(
            padding: const EdgeInsets.all(14),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text(
                  "${r.flight?.departureLocation} → ${r.flight?.arrivalLocation}",
                  style: const TextStyle(
                    fontSize: 18,
                    fontWeight: FontWeight.bold,
                  ),
                ),

                const SizedBox(height: 6),

                Text(
                  "Departure: ${r.flight?.departureTime}",
                  style: TextStyle(color: Colors.grey.shade700),
                ),

                const SizedBox(height: 12),

                Align(
                  alignment: Alignment.centerRight,
                  child: ElevatedButton(
                    style: ElevatedButton.styleFrom(
                      backgroundColor: Colors.blue.shade600,
                      padding: const EdgeInsets.symmetric(
                        horizontal: 22, vertical: 12),
                      shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(8),
                      ),
                    ),
                    onPressed: () async {
                      final submitted = await showRateDialog(
                        context,
                        AuthProvider.userId!,
                        r.flight!,
                      );
                      if (submitted == true) {
                        await refresh();
                      }
                    },
                    child: const Text("Rate Flight"),
                  ),
                )
              ],
            ),
          ),
        );
      },
    );
  }
}


class CompletedReviewsMobile extends StatelessWidget {
  final List<FlightReview> reviews;

  const CompletedReviewsMobile({super.key, required this.reviews});

  @override
  Widget build(BuildContext context) {
    if (reviews.isEmpty) {
      return const Center(
        child: Text("No reviews yet"),
      );
    }

    return ListView.builder(
      padding: const EdgeInsets.all(14),
      itemCount: reviews.length,
      itemBuilder: (context, index) {
        final rev = reviews[index];

        return Card(
          shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(14)),
          elevation: 3,
          margin: const EdgeInsets.only(bottom: 16),
          child: Padding(
            padding: const EdgeInsets.all(12),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text(
                  "${rev.flight?.departureLocation ?? 'Unknown'} → ${rev.flight?.arrivalLocation ?? 'Unknown'}",
                  style: const TextStyle(
                    fontWeight: FontWeight.bold,
                    fontSize: 18,
                  ),
                ),

                const SizedBox(height: 6),

                Row(
                  children: List.generate(
                    rev.rating ?? 0,
                    (i) => const Icon(Icons.star, color: Colors.amber, size: 22),
                  ),
                ),

                if (rev.comment != null && rev.comment!.isNotEmpty) ...[
                  const SizedBox(height: 10),
                  Text(
                    rev.comment!,
                    style: TextStyle(color: Colors.grey.shade800),
                  )
                ],
              ],
            ),
          ),
        );
      },
    );
  }
}
