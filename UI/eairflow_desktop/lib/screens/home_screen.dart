import 'package:eairflow_desktop/providers/auth_provider.dart';
import 'package:eairflow_desktop/providers/reservation_provider.dart';
import 'package:eairflow_desktop/screens/book_flight_card.dart';
import 'package:flutter/material.dart';
import '../widgets/stat_card.dart';
import '../../main.dart';

class HomeScreen extends StatefulWidget {
  const HomeScreen({super.key});

  @override
  State<HomeScreen> createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> with RouteAware {
  int flightsBooked = 0;
  int flightsDone = 0;
  int flightsCancelled = 0;
  double totalSpends = 0;

  @override
  void initState() {
    super.initState();
    loadStats();
  }

  @override
void didChangeDependencies() {
  super.didChangeDependencies();

  final route = ModalRoute.of(context);
  if (route is PageRoute) {
    routeObserver.subscribe(this, route);
  }
}


  @override
  void dispose() {
    routeObserver.unsubscribe(this);
    super.dispose();
  }

  @override
  void didPopNext() {
    loadStats();
  }

  Future<void> loadStats() async {
    final userId = AuthProvider.userId;
    if (userId == null) return;

    final provider = ReservationProvider();
    final reservations = await provider.getByUser(userId);

    int booked = 0;
    int done = 0;
    int cancelled = 0;
    double spends = 0;

    for (var r in reservations) {
      final flightState = r.flight?.stateMachine;
      final reservationState = r.stateMachine;

      if (r.payment != null && r.payment!.amount != null) {
        spends += r.payment!.amount!;
      }

      if (flightState == "completed") {
        done++;
        continue;
      }

      if (reservationState == "cancelled") {
        cancelled++;
        continue;
      }

      booked++;
    }

    setState(() {
      flightsBooked = booked;
      flightsDone = done;
      flightsCancelled = cancelled;
      totalSpends = spends;
    });

  }

  @override
  Widget build(BuildContext context) {
    return LayoutBuilder(
      builder: (context, c) {
        return SingleChildScrollView(
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Wrap(
                spacing: 16,
                runSpacing: 16,
                children: [
                  StatCard(
                    title: "Flights booked",
                    value: "$flightsBooked",
                    icon: Icons.book_online_rounded,
                    color: const Color(0xFF2E8BFF),
                  ),
                  StatCard(
                    title: "Flights done",
                    value: "$flightsDone",
                    icon: Icons.check_circle_rounded,
                    color: const Color(0xFF2CC990),
                  ),
                  StatCard(
                    title: "Flights cancelled",
                    value: "$flightsCancelled",
                    icon: Icons.cancel_rounded,
                    color: const Color(0xFFFF6B6B),
                  ),
                  StatCard(
                    title: "Total spends",
                    value: "\$${totalSpends.toStringAsFixed(2)}",
                    icon: Icons.payments_rounded,
                    color: const Color(0xFFFFC857),
                  ),
                ],
              ),

              const SizedBox(height: 20),
              BookFlightCard(
                onFlightBooked: loadStats,
              ),
              const SizedBox(height: 16),
            ],
          ),
        );
      },
    );
  }
}
