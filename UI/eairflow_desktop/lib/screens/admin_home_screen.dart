import 'package:fl_chart/fl_chart.dart';
import 'package:flutter/material.dart';
import '../providers/flight_provider.dart';
import '../providers/airport_provider.dart';
import '../models/airport.dart';

class AdminHomeScreen extends StatefulWidget {
  const AdminHomeScreen({super.key});

  @override
  State<AdminHomeScreen> createState() => _AdminHomeScreenState();
}

class _AdminHomeScreenState extends State<AdminHomeScreen> {
  final flightProv = FlightProvider();
  final airportProv = AirportProvider();

  List<Airport> airports = [];
  List<int> selectedAirports = [];

  Map<String, dynamic>? stats;
  bool loading = true;

  @override
  void initState() {
    super.initState();
    loadAirports();
  }

  Future<void> loadAirports() async {
    final data = await airportProv.get();
    setState(() {
      airports = data.result;
      selectedAirports = airports.map((a) => a.airportId!).toList();
    });
    loadStats();
  }

  Future<void> loadStats() async {
    setState(() => loading = true);
    stats = await flightProv.getStats(selectedAirports);
    setState(() => loading = false);
  }

  @override
  Widget build(BuildContext context) {
    if (loading || stats == null) {
      return const Center(child: CircularProgressIndicator());
    }

    return Scaffold(
      appBar: AppBar(title: const Text("Reports",
      style: TextStyle(fontWeight: FontWeight.bold),
      )),
      body: Padding(
        padding: const EdgeInsets.all(16),
        child: Column(
          children: [
            Wrap(
              children: airports.map((a) {
                return Row(
                  mainAxisSize: MainAxisSize.min,
                  children: [
                    Checkbox(
                      value: selectedAirports.contains(a.airportId),
                      onChanged: (v) {
                        setState(() {
                          if (v == false && selectedAirports.length == 1) {
                            return;
                          }

                          if (v == true) {
                            selectedAirports.add(a.airportId!);
                          } else {
                            selectedAirports.remove(a.airportId);
                          }
                        });

                        loadStats();
                      },

                    ),
                    Text(a.name ?? ""),
                    const SizedBox(width: 16),
                  ],
                );
              }).toList(),
            ),

            const SizedBox(height: 20),

            Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                kpi("Completed", stats!["completed"].toString(), Colors.green),
                kpi("Canceled", stats!["canceled"].toString(), Colors.red),
                kpi("Delayed", stats!["delayed"].toString(), Colors.orange),
                kpi("Revenue", "\$${stats!["totalRevenue"]}", Colors.blue),
              ],
            ),

            const SizedBox(height: 20),

            Expanded(
              child: Row(
                children: [
                  Expanded(
                    child: topList("Top Airlines", stats!["topAirlines"], "airline"),
                  ),
                  const SizedBox(width: 12),
                  Expanded(
                    child: topList("Top Destinations", stats!["topDestinations"], "destination"),
                  ),
                  const SizedBox(height: 20),

                  Expanded(
                    child: Card(
                      elevation: 2,
                      child: Padding(
                        padding: const EdgeInsets.all(16),
                        child: Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            const Text(
                              "Weekly Flights Breakdown",
                              style: TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
                            ),
                            const SizedBox(height: 12),
                            Expanded(child: weeklyTrendChart(stats!["weeklyTrend"])),
                          ],
                        ),
                      ),
                    ),
                  ),

                ],
              ),
            )
          ],
        ),
      ),
    );
  }

  Widget kpi(String label, String value, Color color) {
    return Expanded(
      child: Card(
        color: color.withOpacity(0.40),
        child: Padding(
          padding: const EdgeInsets.all(16),
          child: Column(
            children: [
              Text(label, style: const TextStyle(fontSize: 16)),
              const SizedBox(height: 8),
              Text(value, style: const TextStyle(fontSize: 24, fontWeight: FontWeight.bold)),
            ],
          ),
        ),
      ),
    );
  }

 Widget topList(String title, List items, String key) {
  final limited = items.take(3).toList();

    return Card(
    elevation: 3,
    margin: const EdgeInsets.only(bottom: 16),
    shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(16)),
    child: Padding(
      padding: const EdgeInsets.all(16),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Row(
            children: [
              const Icon(Icons.bar_chart, color: Colors.blue, size: 22),
              const SizedBox(width: 8),
              Text(
                title,
                style: const TextStyle(
                  fontSize: 18,
                  fontWeight: FontWeight.w700,
                ),
              ),
            ],
          ),

          const SizedBox(height: 14),

          ...limited.map((e) {
            final label = e[key]?.toString() ?? "";
            final count = e["count"]?.toString() ?? "0";

            return Container(
              margin: const EdgeInsets.only(bottom: 10),
              child: Row(
                children: [
                  Container(
                    width: 36,
                    height: 36,
                    decoration: BoxDecoration(
                      color: Colors.blue.shade50,
                      borderRadius: BorderRadius.circular(50),
                    ),
                    child: const Icon(
                      Icons.flight_takeoff,
                      size: 20,
                      color: Colors.blue,
                    ),
                  ),

                  const SizedBox(width: 12),

                  Expanded(
                    child: Text(
                      label,
                      style: const TextStyle(
                        fontSize: 15,
                        fontWeight: FontWeight.w600,
                      ),
                    ),
                  ),

                  Container(
                    padding: const EdgeInsets.symmetric(
                      horizontal: 10,
                      vertical: 6,
                    ),
                    decoration: BoxDecoration(
                      color: Colors.blue.shade100,
                      borderRadius: BorderRadius.circular(12),
                    ),
                    child: Text(
                      "$count flights",
                      style: const TextStyle(
                        color: Colors.blue,
                        fontWeight: FontWeight.bold,
                        fontSize: 13,
                      ),
                    ),
                  ),
                ],
              ),
            );
          }),
        ],
      ),
    ),
  );

  }

  Widget weeklyTrendChart(List trend) {
  return Card(
    elevation: 3,
    child: Padding(
      padding: const EdgeInsets.all(16.0),
      child: SizedBox(
        height: 260,
        child: LineChart(
          LineChartData(
            minY: 0,
            titlesData: FlTitlesData(
              leftTitles: AxisTitles(
                sideTitles: SideTitles(showTitles: true, reservedSize: 32),
              ),
              bottomTitles: AxisTitles(
                sideTitles: SideTitles(
                  showTitles: true,
                  getTitlesWidget: (value, meta) {
                    int i = value.toInt();
                    if (i < trend.length) {
                      return Text(trend[i]["day"]);
                    }
                    return const Text("");
                  },
                ),
              ),
            ),
            lineBarsData: [
              LineChartBarData(
                isCurved: true,
                color: Colors.green,
                barWidth: 3,
                spots: List.generate(
                  trend.length,
                  (i) => FlSpot(i.toDouble(), trend[i]["completed"].toDouble()),
                ),
              ),
              LineChartBarData(
                isCurved: true,
                color: Colors.red,
                barWidth: 3,
                spots: List.generate(
                  trend.length,
                  (i) => FlSpot(i.toDouble(), trend[i]["canceled"].toDouble()),
                ),
              ),
              LineChartBarData(
                isCurved: true,
                color: Colors.orange,
                barWidth: 3,
                spots: List.generate(
                  trend.length,
                  (i) => FlSpot(i.toDouble(), trend[i]["delayed"].toDouble()),
                ),
              ),
            ],
            gridData: FlGridData(show: true),
            borderData: FlBorderData(show: true),
          ),
        ),
      ),
    ),
  );
}



}



