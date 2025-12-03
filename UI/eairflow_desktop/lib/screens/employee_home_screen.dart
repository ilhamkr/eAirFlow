import 'package:eairflow_desktop/providers/auth_provider.dart';
import 'package:eairflow_desktop/widgets/notification_feed.dart';
import 'package:flutter/material.dart';
import 'package:eairflow_desktop/providers/flight_provider.dart';
import 'package:eairflow_desktop/providers/luggage_provider.dart';
import 'package:eairflow_desktop/models/flight.dart';
import 'package:eairflow_desktop/models/luggage.dart';
import 'package:intl/intl.dart';

class EmployeeHomeScreen extends StatefulWidget {
  const EmployeeHomeScreen({super.key});

  @override
  State<EmployeeHomeScreen> createState() => _EmployeeHomeScreenState();
}

class _EmployeeHomeScreenState extends State<EmployeeHomeScreen> {
  bool loading = true;

  int flightsToday = 0;
  int delayedCount = 0;
  int boardingCount = 0;
  int luggageIssues = 0;

  List<Flight> activeOperations = [];

  @override
  void initState() {
    super.initState();
    loadDashboard();
  }

  Future<void> loadDashboard() async {
    try {
      final flightProv = FlightProvider();
      final luggageProv = LuggageProvider();
      int employeeId = AuthProvider.employeeId!;
      List<Flight> flights = await flightProv.getTodayForEmployee(employeeId);

      flightsToday = flights.length;
      delayedCount = flights.where((f) => f.stateMachine == "delayed").length;
      boardingCount = flights.where((f) => f.stateMachine == "boarding").length;

      activeOperations = flights
          .where((f) =>
              f.stateMachine == "boarding" ||
              f.stateMachine == "delayed" ||
              f.stateMachine == "scheduled")
          .toList();

      List<Luggage> allLuggage = await luggageProv.getAllLuggage();
      luggageIssues =
          allLuggage.where((l) => l.stateMachine != "pickedup").length;

      setState(() => loading = false);
    } catch (e) {
      print("Dashboard load error: $e");
      setState(() => loading = false);
    }
  }

  @override
  Widget build(BuildContext context) {
    final cs = Theme.of(context).colorScheme;

    if (loading) {
      return const Center(child: CircularProgressIndicator());
    }

    return SingleChildScrollView(
      padding: const EdgeInsets.all(16),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(
            "Today's Overview",
            style: TextStyle(
              fontSize: 22,
              fontWeight: FontWeight.bold,
              color: cs.primary,
            ),
          ),
          const SizedBox(height: 16),

          Row(
            children: [
              _statCard(
                icon: Icons.flight_takeoff,
                color: Colors.blue,
                title: "Flights Today",
                value: flightsToday.toString(),
              ),
              _statCard(
                icon: Icons.access_time_filled,
                color: Colors.orange,
                title: "Delayed",
                value: delayedCount.toString(),
              ),
              _statCard(
                icon: Icons.luggage,
                color: Colors.green,
                title: "Luggage Issues",
                value: luggageIssues.toString(),
              ),
            ],
          ),

          const SizedBox(height: 30),

          Text(
            "Active Operations",
            style: TextStyle(
              fontSize: 20,
              fontWeight: FontWeight.bold,
              color: cs.primary,
            ),
          ),

          const SizedBox(height: 12),

          ...activeOperations.map((f) {
            final df = DateFormat("yyyy-MM-dd HH:mm");

           String subtitle = switch (f.stateMachine) {
              "boarding" =>
                  "Flight - ${f.departureLocation ?? ""} → ${f.arrivalLocation ?? ""} • Boarding now",
            
              "delayed" =>
                  "New departure: ${f.departureTime != null ? df.format(f.departureTime!) : 'N/A'}",
            
              "scheduled" =>
                  "Departure: ${f.departureTime != null ? df.format(f.departureTime!) : 'N/A'}",
            
              _ => "",
            };


            return _operationItem(
              icon: Icons.flight,
              title: "${f.airline?.airport?.name} – ${f.stateMachine!.toUpperCase()}",
              subtitle: subtitle,
            );
          }).toList(),

          const SizedBox(height: 30),

          EmployeeNotificationFeed(),
        ],
      ),
    );
  }


  Widget _statCard({
    required IconData icon,
    required Color color,
    required String title,
    required String value,
  }) {
    return Expanded(
      child: Container(
        margin: const EdgeInsets.only(right: 12),
        padding: const EdgeInsets.all(18),
        decoration: BoxDecoration(
          color: color.withOpacity(0.1),
          borderRadius: BorderRadius.circular(16),
          border: Border.all(color: color.withOpacity(0.3)),
        ),
        child: Column(
          children: [
            Icon(icon, size: 30, color: color),
            const SizedBox(height: 8),
            Text(value,
                style: const TextStyle(
                    fontSize: 22, fontWeight: FontWeight.bold)),
            Text(title, style: const TextStyle(fontSize: 12)),
          ],
        ),
      ),
    );
  }

  Widget _operationItem(
      {required IconData icon,
      required String title,
      required String subtitle}) {
    return Card(
      child: ListTile(
        leading: Icon(icon, color: Colors.blue),
        title:
            Text(title, style: const TextStyle(fontWeight: FontWeight.bold)),
        subtitle: Text(subtitle),
      ),
    );
  }
}
