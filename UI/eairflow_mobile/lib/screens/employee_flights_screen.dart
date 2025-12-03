import 'package:eairflow_mobile/providers/auth_provider.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import '../providers/flight_provider.dart';
import '../models/flight.dart';

class EmployeeFlightsScreen extends StatefulWidget {
  const EmployeeFlightsScreen({super.key});

  @override
  State<EmployeeFlightsScreen> createState() => _EmployeeFlightsScreenState();
}

class _EmployeeFlightsScreenState extends State<EmployeeFlightsScreen> {
  bool loading = true;
  List<Flight> flights = [];

  @override
  void initState() {
    super.initState();
    loadTodayFlights();
  }

  Future<void> loadTodayFlights() async {
    setState(() => loading = true);

    try {
      final provider = FlightProvider();
      int empId = AuthProvider.employeeId!;
      print("EMPLOYEE ID = $empId");

      flights = await FlightProvider().getTodayForEmployee(empId);
    } catch (e) {
      print("Error loading flights: $e");
    } finally {
      setState(() => loading = false);
    }
  }

  @override
  Widget build(BuildContext context) {
    if (loading) return const Center(child: CircularProgressIndicator());

    if (flights.isEmpty) {
      return const Center(
        child: Text(
          "No flights scheduled for today.",
          style: TextStyle(fontSize: 18),
        ),
      );
    }

    return Padding(
      padding: const EdgeInsets.all(16),
      child: ListView.builder(
        itemCount: flights.length,
        itemBuilder: (_, i) => _flightCard(context, flights[i]),
      ),
    );
  }

  Widget _flightCard(BuildContext context, Flight f) {
    String airportName =
        f.airline?.airport?.name ?? f.departureLocation ?? "Unknown Airport";
        final df = DateFormat("yyyy-MM-dd HH:mm");

    Color statusColor;
    switch (f.stateMachine?.toLowerCase()) {
      case "delayed":
        statusColor = Colors.red;
        break;
      case "boarding":
        statusColor = Colors.orange;
        break;
      case "scheduled":
        statusColor = Colors.blue;
        break;
      default:
        statusColor = Colors.green;
    }

    return Card(
      elevation: 4,
      margin: const EdgeInsets.only(bottom: 16),
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(18)),
      child: Padding(
        padding: const EdgeInsets.all(16),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text(
              airportName,
              style: const TextStyle(
                  fontSize: 22, fontWeight: FontWeight.bold),
            ),
            const SizedBox(height: 6),

          Row(
            children: [
              const Icon(Icons.flight_takeoff, color: Colors.blue, size: 20),
              const SizedBox(width: 8),
              Expanded(
                child: Text(
                  "${f.departureLocation} → ${f.arrivalLocation}",
                  style: const TextStyle(
                    fontSize: 18,
                    fontWeight: FontWeight.w600,
                  ),
                ),
              ),
            ],
          ),

          const SizedBox(height: 12),


          Row(
            children: [
              const Icon(Icons.access_time, size: 20, color: Colors.black54),
              Text(" Departure time:",
               style: TextStyle(fontSize: 16, fontWeight: FontWeight.w600),
              ),
              const SizedBox(width: 6),
              Text(
                f.departureTime != null
                    ? df.format(f.departureTime!)
                    : "N/A",
                style: const TextStyle(fontSize: 14),
              ),
            ],
          ),

          const SizedBox(height: 4),

          Row(
            children: [
              const Icon(Icons.schedule, size: 20, color: Colors.black54),
              Text(" Arrival time:",
               style: TextStyle(fontSize: 16, fontWeight: FontWeight.w600),
              ),
              const SizedBox(width: 6),
              Text(
                f.arrivalTime != null
                    ? df.format(f.arrivalTime!)
                    : "N/A",
                style: const TextStyle(fontSize: 14),
              ),
            ],
          ),

          const SizedBox(height: 4),

          Row(
            children: [
              const Icon(Icons.airlines, size: 20, color: Colors.black54),
              const SizedBox(width: 6),
              Text(
                f.airline?.name ?? "Unknown Airline",
                style: const TextStyle(fontSize: 14),
              ),
            ],
          ),

          const SizedBox(height: 4),

          Row(
            children: [
              const Icon(Icons.attach_money, size: 20, color: Colors.black54),
              const SizedBox(width: 6),
              Text(
                "${f.price ?? 'N/A'}",
                style: const TextStyle(fontSize: 14),
              ),
            ],
          ),

            const SizedBox(height: 12),

            Container(
              padding: const EdgeInsets.symmetric(horizontal: 12, vertical: 6),
              decoration: BoxDecoration(
                color: statusColor.withOpacity(0.15),
                borderRadius: BorderRadius.circular(10),
              ),
              child: Text(
                f.stateMachine ?? "Unknown",
                style: TextStyle(
                  color: statusColor,
                  fontWeight: FontWeight.bold,
                ),
              ),
            ),

            const SizedBox(height: 14),

            Row(
              mainAxisAlignment: MainAxisAlignment.end,
              children: [
                TextButton(
                  onPressed: () async {
                    if (!["scheduled", "delayed"]
                        .contains(f.stateMachine?.toLowerCase())) {
                      return _error("Flight cannot enter boarding from this state.");
                    }

                    final ok = await FlightProvider().boarding(f.flightId!);
                    if (ok) _success("Flight is now BOARDING");
                    loadTodayFlights();
                  },
                  child: const Text("Boarding"),
                ),

                const SizedBox(width: 4),

                TextButton(
                  onPressed: () async {
                    if (f.stateMachine?.toLowerCase() != "boarding") {
                      return _error("Only flights in BOARDING can be completed.");
                    }

                    final ok = await FlightProvider().complete(f.flightId!);
                    if (ok) _success("Flight completed");
                    loadTodayFlights();
                  },
                  child: const Text("Complete"),
                ),

                const SizedBox(width: 4),

                PopupMenuButton<String>(
                  icon: const Icon(Icons.more_vert),
                  onSelected: (value) {
                    if (value == "cancel") _cancel(f);
                    if (value == "delay") _showDelayPopup(f);
                  },
                  itemBuilder: (_) {
                    final state = f.stateMachine?.toLowerCase();
                
                    final isCompleted = state == "completed";
                    final isBoarding  = state == "boarding";
                
                    final disableActions = isCompleted || isBoarding;
                
                    return [
                    
                      if (!disableActions)
                        const PopupMenuItem(
                          value: "cancel",
                          child: Text("Cancel Flight"),
                        )
                      else
                        const PopupMenuItem(
                          enabled: false,
                          child: Text(
                            "Cannot cancel in this state",
                            style: TextStyle(color: Colors.grey),
                          ),
                        ),
                
                      if (!disableActions)
                        const PopupMenuItem(
                          value: "delay",
                          child: Text("Delay Flight"),
                        )
                      else
                        const PopupMenuItem(
                          enabled: false,
                          child: Text(
                            "Cannot delay in this state",
                            style: TextStyle(color: Colors.grey),
                          ),
                        ),
                    ];
                  },
                )
              ],
            ),
          ],
        ),
      ),
    );
  }

  Future<void> _cancel(Flight f) async {
    final ok = await FlightProvider().cancel(f.flightId!);
    if (ok) _success("Flight cancelled");
    loadTodayFlights();
  }

  void _success(String msg) {
    ScaffoldMessenger.of(context).showSnackBar(
      SnackBar(content: Text(msg)),
    );
  }

  void _error(String msg) {
    ScaffoldMessenger.of(context).showSnackBar(
      SnackBar(content: Text(msg), backgroundColor: Colors.red),
    );
  }

  void _showDelayPopup(Flight f) {
    final controller = TextEditingController();

    showDialog(
      context: context,
      builder: (_) => AlertDialog(
        title: const Text("Delay Flight"),
        content: TextField(
          controller: controller,
          keyboardType: TextInputType.number,
          decoration: const InputDecoration(
            labelText: "Delay in minutes",
          ),
        ),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context),
            child: const Text("Cancel"),
          ),
          ElevatedButton(
            onPressed: () async {
              final min = int.tryParse(controller.text);

              if (min == null || min <= 0) {
                _error("Enter valid minutes");
                return;
              }

              final ok = await FlightProvider()
                  .delayWithTime(f.flightId!, min);
              if (ok) _success("Flight delayed by $min minutes");

              Navigator.pop(context);
              loadTodayFlights();
            },
            child: const Text("Confirm"),
          ),
        ],
      ),
    );
  }
}
