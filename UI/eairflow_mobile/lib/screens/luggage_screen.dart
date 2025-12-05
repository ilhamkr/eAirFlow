import 'package:eairflow_mobile/providers/auth_provider.dart';
import 'package:eairflow_mobile/providers/base_provider.dart';
import 'package:eairflow_mobile/providers/luggage_provider.dart';
import 'package:eairflow_mobile/widgets/report_lost_luggage_dialog.dart';
import 'package:flutter/material.dart';

class LuggageScreenMobile extends StatefulWidget {
  const LuggageScreenMobile({super.key});

  @override
  State<LuggageScreenMobile> createState() => _LuggageScreenMobileState();
}

class _LuggageScreenMobileState extends State<LuggageScreenMobile> {
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

  Color statusColor(String? s) {
    switch (s?.toLowerCase()) {
      case "lost":
      case "missing":
        return Colors.red.shade400;
      case "found":
        return Colors.green.shade600;
      case "processing":
        return Colors.orange.shade700;
      default:
        return Colors.grey.shade600;
    }
  }

  Color statusBg(String? s) {
    switch (s?.toLowerCase()) {
      case "lost":
      case "missing":
        return Colors.red.shade50;
      case "found":
        return Colors.green.shade50;
      case "processing":
        return Colors.orange.shade50;
      default:
        return Colors.grey.shade200;
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
            Icon(Icons.luggage, size: 80, color: Colors.grey.shade500),
            const SizedBox(height: 20),
            const Text(
              "You currently have no registered luggage.",
              style: TextStyle(fontSize: 18),
              textAlign: TextAlign.center,
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
                  builder: (_) => Dialog(
                    insetPadding: const EdgeInsets.symmetric(horizontal: 16, vertical: 24),
                    child: ReportLostDialogMobile(onSubmitted: loadData),
                  ),
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

    return Scaffold(
      backgroundColor: Colors.white,

      floatingActionButton: FloatingActionButton.extended(
        backgroundColor: Colors.red.shade600,
        onPressed: () {
          showDialog(
            context: context,
            builder: (_) => Dialog(
              insetPadding: const EdgeInsets.symmetric(horizontal: 16, vertical: 24),
              child: ReportLostDialogMobile(onSubmitted: loadData),
            ),
          );
        },
        icon: const Icon(Icons.report),
        label: const Text("Report Missing"),
      ),

      body: SafeArea(
        child: ListView.builder(
          padding: const EdgeInsets.all(14),
          itemCount: luggageList.length,
          itemBuilder: (_, index) {
            final l = luggageList[index];

            return Card(
              margin: const EdgeInsets.only(bottom: 16),
              elevation: 3,
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(16),
              ),
              child: Padding(
                padding: const EdgeInsets.all(14),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.start,
                  children: [
                    ClipRRect(
                      borderRadius: BorderRadius.circular(12),
                      child: l.imageUrl != null
                          ? Image.network(
                              "${BaseProvider.baseUrl}${l.imageUrl}",
                              height: 150,
                              width: double.infinity,
                              fit: BoxFit.cover,
                            )
                          : Container(
                              height: 150,
                              width: double.infinity,
                              color: Colors.blue.shade50,
                              child: Icon(
                                Icons.luggage,
                                color: Colors.blue.shade400,
                                size: 60,
                              ),
                            ),
                    ),

                    const SizedBox(height: 12),

                    if (l.airport != null)
                      Row(
                        children: [
                          const Icon(Icons.location_on, size: 18),
                          const SizedBox(width: 6),
                          Expanded(
                            child: Text(
                              "${l.airport!.city}, ${l.airport!.country} – ${l.airport!.name}",
                              style: const TextStyle(
                                fontWeight: FontWeight.bold,
                                fontSize: 16,
                              ),
                            ),
                          ),
                        ],
                      ),

                    const SizedBox(height: 12),

                    if (l.description != null && l.description!.contains(":"))
                      Text(
                        "Tag: ${l.description!.split(":")[0].replaceFirst("Tag ", "").trim()}",
                        style: const TextStyle(
                          fontSize: 15,
                          fontWeight: FontWeight.w700,
                        ),
                      ),

                    const SizedBox(height: 6),

                    const Text(
                      "Description:",
                      style: TextStyle(fontWeight: FontWeight.w700),
                    ),
                    Text(
                      l.description != null
                          ? l.description!.contains(":")
                              ? l.description!.split(":")[1].trim()
                              : l.description!
                          : "No description",
                      style: const TextStyle(fontSize: 15),
                    ),

                    const SizedBox(height: 12),

                    Align(
                      alignment: Alignment.centerRight,
                      child: Container(
                        padding: const EdgeInsets.symmetric(
                          horizontal: 12,
                          vertical: 6,
                        ),
                        decoration: BoxDecoration(
                          color: statusBg(l.stateMachine),
                          borderRadius: BorderRadius.circular(12),
                        ),
                        child: Text(
                          "Status: ${l.stateMachine ?? 'Unknown'}",
                          style: TextStyle(
                            fontWeight: FontWeight.bold,
                            color: statusColor(l.stateMachine),
                          ),
                        ),
                      ),
                    )
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
