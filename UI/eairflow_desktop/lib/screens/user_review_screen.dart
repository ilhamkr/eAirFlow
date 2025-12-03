import 'package:eairflow_desktop/models/flight_review.dart';
import 'package:eairflow_desktop/models/reservation.dart';
import 'package:eairflow_desktop/providers/flight_review_provider.dart';
import 'package:eairflow_desktop/providers/reservation_provider.dart';
import 'package:eairflow_desktop/widgets/rate_flight_dialog.dart';
import 'package:flutter/material.dart';
import '../providers/auth_provider.dart';

class UserReviewsScreen extends StatefulWidget {
  const UserReviewsScreen({super.key});

  @override
  State<UserReviewsScreen> createState() => _UserReviewsScreenState();
}

class _UserReviewsScreenState extends State<UserReviewsScreen> {
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

    final all = await reservationProv.getByUser(userId);

    completedReservations = all
        .where((r) => r.flight?.stateMachine == "completed")
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
        appBar: AppBar(
          automaticallyImplyLeading: false,
          title: const Text("My Reviews"),
          bottom: const TabBar(
            tabs: [
              Tab(text: "To Review", icon: Icon(Icons.pending_actions)),
              Tab(text: "Reviewed", icon: Icon(Icons.star)),
            ],
          ),
        ),
        body: TabBarView(
          children: [
            PendingReviewsList(
              reservations: completedReservations,
              reviews: reviews,
            ),
            CompletedReviewsList(reviews: reviews),
          ],
        ),
      ),
    );
  }
}


class PendingReviewsList extends StatelessWidget {
  final List<Reservation> reservations;
  final List<FlightReview> reviews;

  const PendingReviewsList({
    super.key,
    required this.reservations,
    required this.reviews,
  });

  @override
  Widget build(BuildContext context) {
    final pending = reservations.where((r) {
      return !reviews.any((rev) => rev.flightId == r.flightId);
    }).toList();

    if (pending.isEmpty) {
      return const Center(child: Text("All flights reviewed ✔"));
    }

    return ListView.builder(
      itemCount: pending.length,
      itemBuilder: (context, index) {
        final r = pending[index];

        return ListTile(
          title: Text("${r.flight!.departureLocation} → ${r.flight!.arrivalLocation}"),
          trailing: ElevatedButton(
            onPressed: () {
              showRateDialog(context, AuthProvider.userId!, r.flight!);
            },
            child: const Text("Rate"),
          ),
        );
      },
    );
  }
}

class CompletedReviewsList extends StatelessWidget {
  final List<FlightReview> reviews;

  const CompletedReviewsList({super.key, required this.reviews});

  @override
  Widget build(BuildContext context) {
    if (reviews.isEmpty) {
      return const Center(child: Text("No reviews yet"));
    }

    return ListView.builder(
      itemCount: reviews.length,
      itemBuilder: (context, index) {
        final rev = reviews[index];

        return ListTile(
          title: Text(
            "${rev.flight?.departureLocation ?? 'Unknown'} → ${rev.flight?.arrivalLocation ?? 'Unknown'}",
            style: const TextStyle(fontWeight: FontWeight.bold),
          ),
          subtitle: Text(rev.comment ?? ""),
          trailing: Row(
            mainAxisSize: MainAxisSize.min,
            children: List.generate(
              rev.rating ?? 0,
              (i) => const Icon(Icons.star, color: Colors.amber),
            ),
          ),
        );
      },
    );
  }
}


