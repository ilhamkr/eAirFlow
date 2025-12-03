import 'package:eairflow_desktop/providers/auth_provider.dart';
import 'package:eairflow_desktop/providers/base_provider.dart';
import 'package:eairflow_desktop/providers/luggage_provider.dart';
import 'package:eairflow_desktop/screens/report_lost_dialog.dart';
import 'package:flutter/material.dart';

class LuggageScreen extends StatefulWidget {
  const LuggageScreen({super.key});

  @override
  State<LuggageScreen> createState() => _LuggageScreenState();
}

class _LuggageScreenState extends State<LuggageScreen> {
  bool loading = true;
  List luggageList = [];

  @override
  void initState() {
    super.initState();
    loadData();
  }

  Future<void> loadData() async {
    final provider = LuggageProvider();
    final userId = AuthProvider.userId ?? 0;

    try {
      var result = await provider.getMyLuggage(userId);
      setState(() {
        luggageList = result;
        loading = false;
      });
    } catch (e) {
      print("LUGGAGE ERROR: $e");
      setState(() => loading = false);
    }
  }

  @override
  Widget build(BuildContext context) {
    if (loading) {
      return const Center(child: CircularProgressIndicator());
    }

    if (luggageList.isEmpty) {
      return Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            const Text(
              "You currently have no registered luggage.",
              style: TextStyle(fontSize: 18),
            ),
            const SizedBox(height: 20),
            ElevatedButton.icon(
              icon: const Icon(Icons.report_gmailerrorred),
              style: ElevatedButton.styleFrom(
                backgroundColor: Colors.red,
                padding: const EdgeInsets.symmetric(horizontal: 20, vertical: 14),
              ),
              onPressed: () {
                showDialog(
                  context: context,
                  builder: (_) => ReportLostDialog(onSubmitted: loadData),
                );
              },
              label: const Text(
                "Report Missing Luggage",
                style: TextStyle(fontSize: 16),
              ),
            ),
          ],
        ),
      );
    }

    return Padding(
      padding: const EdgeInsets.all(20),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          SizedBox(
            width: 230,
            height: 45,
            child: ElevatedButton.icon(
              icon: const Icon(Icons.add_alert),
              style: ElevatedButton.styleFrom(
                backgroundColor: Colors.red,
                shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(10),
                ),
              ),
              onPressed: () {
                showDialog(
                  context: context,
                  builder: (_) => ReportLostDialog(onSubmitted: loadData),
                );
              },
              label: const Text(
                "Report Missing Luggage",
                style: TextStyle(fontSize: 16, color: Colors.white),
              ),
            ),
          ),

          const SizedBox(height: 20),

          Expanded(
            child: ListView.builder(
              itemCount: luggageList.length,
              itemBuilder: (context, index) {
                final l = luggageList[index];

                return Card(
                  shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(16),
                  ),
                  elevation: 5,
                  margin: const EdgeInsets.only(bottom: 20),
                  child: Padding(
                    padding: const EdgeInsets.all(16),
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Row(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            ClipRRect(
                              borderRadius: BorderRadius.circular(12),
                              child: l.imageUrl != null
                                  ? Image.network(
                                      "${BaseProvider.baseUrl}${l.imageUrl!}",
                                      width: 120,
                                      height: 120,
                                      fit: BoxFit.cover,
                                    )
                                  : Container(
                                      width: 120,
                                      height: 120,
                                      color: Colors.blue.shade50,
                                      child: Icon(
                                        Icons.luggage,
                                        color: Colors.blue.shade400,
                                        size: 42,
                                      ),
                                    ),
                            ),

                            const SizedBox(width: 20),

                            Expanded(
                              child: Column(
                                crossAxisAlignment: CrossAxisAlignment.start,
                                children: [
                                  if (l.airport != null)
                                    Row(
                                      children: [
                                        Icon(Icons.location_on,
                                            size: 18, color: Colors.grey.shade700),
                                        const SizedBox(width: 6),
                                        Text(
                                          "${l.airport!.city} - ${l.airport!.name}",
                                          style: const TextStyle(
                                            fontSize: 16,
                                            fontWeight: FontWeight.w600,
                                          ),
                                        ),
                                      ],
                                    ),

                                  const SizedBox(height: 12),

                                    if (l.description != null && l.description!.contains(":"))
                                      Column(
                                        crossAxisAlignment: CrossAxisAlignment.start,
                                        children: [
                                          Text(
                                            "TAG: ${l.description!.split(":")[0].replaceFirst("Tag ", "").trim()}",
                                            style: const TextStyle(
                                              fontWeight: FontWeight.bold,
                                              fontSize: 15,
                                            ),
                                          ),
                                          const SizedBox(height: 10),
                                        ],
                                      ),


                                  Column(
                                    crossAxisAlignment: CrossAxisAlignment.start,
                                    children: [
                                      const Text(
                                        "DESCRIPTION:",
                                        style: TextStyle(
                                          fontWeight: FontWeight.bold,
                                          fontSize: 15,
                                        ),
                                      ),
                                      Text(
                                        l.description != null
                                            ? l.description!.contains(":")
                                                ? l.description!.split(":")[1].trim()
                                                : l.description!
                                            : "No description",
                                        style: const TextStyle(fontSize: 15),
                                      ),
                                    ],
                                  ),
                                ],
                              ),
                            ),
                          ],
                        ),

                        const SizedBox(height: 16),

                        Align(
                          alignment: Alignment.bottomRight,
                          child: Container(
                            padding: const EdgeInsets.symmetric(horizontal: 14, vertical: 6),
                            decoration: BoxDecoration(
                              color: Colors.grey.shade300,
                              borderRadius: BorderRadius.circular(12),
                            ),
                            child: Text(
                              "Status: ${l.stateMachine ?? 'Unknown'}",
                              style: const TextStyle(
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
            ),
          ),
        ],
      ),
    );
  }
}
