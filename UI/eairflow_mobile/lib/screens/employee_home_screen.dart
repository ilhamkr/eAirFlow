import 'package:eairflow_mobile/providers/auth_provider.dart';
import 'package:flutter/material.dart';
import 'package:eairflow_mobile/models/flight.dart';
import 'package:eairflow_mobile/models/luggage.dart';
import 'package:eairflow_mobile/providers/flight_provider.dart';
import 'package:eairflow_mobile/providers/luggage_provider.dart';
import 'package:intl/intl.dart';

class EmployeeHomeScreen extends StatefulWidget {
  const EmployeeHomeScreen({super.key});

  @override
  State<EmployeeHomeScreen> createState() =>
      _EmployeeHomeScreenMobileState();
}

class _EmployeeHomeScreenMobileState extends State<EmployeeHomeScreen> {
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
      delayedCount =
          flights.where((f) => f.stateMachine == "delayed").length;
      boardingCount =
          flights.where((f) => f.stateMachine == "boarding").length;

      activeOperations = flights.where((f) {
        return f.stateMachine == "boarding" ||
            f.stateMachine == "delayed" ||
            f.stateMachine == "scheduled";
      }).toList();

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

    return Scaffold(
      backgroundColor: Colors.white,
      body: SingleChildScrollView(
        padding: const EdgeInsets.all(14),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text(
              "Today's Overview",
              style: TextStyle(
                fontSize: 20,
                fontWeight: FontWeight.bold,
                color: cs.primary,
              ),
            ),
            const SizedBox(height: 16),

            GridView.count(
              shrinkWrap: true,
              physics: const NeverScrollableScrollPhysics(),
              crossAxisCount: 2,
              crossAxisSpacing: 12,
              mainAxisSpacing: 12,
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
                  icon: Icons.airline_seat_flat_angled,
                  color: Colors.green,
                  title: "Boarding",
                  value: boardingCount.toString(),
                ),
                _statCard(
                  icon: Icons.luggage,
                  color: Colors.red,
                  title: "Luggage Issues",
                  value: luggageIssues.toString(),
                ),
              ],
            ),


            const SizedBox(height: 30),

            Text(
              "Active Operations",
              style: TextStyle(
                fontSize: 18,
                fontWeight: FontWeight.bold,
                color: cs.primary,
              ),
            ),
            const SizedBox(height: 12),

            if (activeOperations.isEmpty)
              const Text("No active operations at the moment"),

            ...activeOperations.map((f) {
              String subtitle = "";
              final df = DateFormat("yyyy-MM-dd HH:mm");

              switch (f.stateMachine) {
                case "boarding":
                  subtitle =
                      "Boarding now • ${f.departureLocation} → ${f.arrivalLocation}";
                  break;
                case "delayed":
                  subtitle = "New departure: ${f.departureTime != null ? df.format(f.departureTime!) : 'N/A'}";
                  break;
                case "scheduled":
                  subtitle = "Departure: ${f.departureTime != null ? df.format(f.departureTime!) : 'N/A'}";
                  break;
              }

              return _operationItem(
                icon: Icons.flight,
                title:
                    "${f.airline?.airport?.name ?? 'Unknown Airport'} – ${f.stateMachine!.toUpperCase()}",
                subtitle: subtitle,
              );
            }).toList(),
          ],
        ),
      ),
    );
  }

  Widget _statCard({
    required IconData icon,
    required Color color,
    required String title,
    required String value,
  }) {
    return SizedBox(
      width: MediaQuery.of(context).size.width / 2 - 20,
      child: Container(
        padding: const EdgeInsets.all(16),
        decoration: BoxDecoration(
          color: color.withOpacity(0.12),
          borderRadius: BorderRadius.circular(14),
          border: Border.all(color: color.withOpacity(0.25)),
        ),
        child: Column(
          children: [
            Icon(icon, size: 30, color: color),
            const SizedBox(height: 6),
            Text(
              value,
              style: const TextStyle(
                fontSize: 20,
                fontWeight: FontWeight.bold,
              ),
            ),
            Text(
              title,
              style: const TextStyle(fontSize: 12),
              textAlign: TextAlign.center,
            ),
          ],
        ),
      ),
    );
  }

  Widget _operationItem({
    required IconData icon,
    required String title,
    required String subtitle,
  }) {
    return Card(
      margin: const EdgeInsets.only(bottom: 12),
      child: ListTile(
        leading: Icon(icon, color: Colors.blue.shade700),
        title: Text(
          title,
          style: const TextStyle(fontWeight: FontWeight.bold),
        ),
        subtitle: Text(subtitle),
      ),
    );
  }
}
