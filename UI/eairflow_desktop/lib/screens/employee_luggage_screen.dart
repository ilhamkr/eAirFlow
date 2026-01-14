import 'package:eairflow_desktop/providers/auth_provider.dart';
import 'package:eairflow_desktop/providers/base_provider.dart';
import 'package:flutter/material.dart';
import '../providers/luggage_provider.dart';
import '../models/luggage.dart';

class EmployeeLuggageScreen extends StatefulWidget {
  const EmployeeLuggageScreen({super.key});

  @override
  State<EmployeeLuggageScreen> createState() => _EmployeeLuggageScreenState();
}

class _EmployeeLuggageScreenState extends State<EmployeeLuggageScreen> {
  bool loading = true;
  List<Luggage> missingLuggage = [];

  @override
  void initState() {
    super.initState();
    loadLostLuggage();
  }

  Future<void> loadLostLuggage() async {
  setState(() => loading = true);

  try {
    final provider = LuggageProvider();
    int empId = AuthProvider.employeeId!;

    List<Luggage> list = await provider.getForEmployee(empId);

    missingLuggage = list.where((l) {
      final s = (l.stateMachine ?? "").toLowerCase();
      return s == "missing" || s == "found";
    }).toList();

  } catch (e) {
    print("Error loading luggage: $e");
  } finally {
    setState(() => loading = false);
  }
}


  @override
  Widget build(BuildContext context) {
    if (loading) return const Center(child: CircularProgressIndicator());

    if (missingLuggage.isEmpty) {
      return const Center(
        child: Text(
          "No missing luggage reported.",
          style: TextStyle(fontSize: 18),
        ),
      );
    }

    return Padding(
      padding: const EdgeInsets.all(20),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          const Text(
            "Missing Luggage",
            style: TextStyle(fontSize: 26, fontWeight: FontWeight.bold),
          ),
          const SizedBox(height: 20),

          Expanded(
            child: ListView.builder(
              itemCount: missingLuggage.length,
              itemBuilder: (_, i) => _luggageTile(context, missingLuggage[i]),
            ),
          ),
        ],
      ),
    );
  }


  Widget _luggageTile(BuildContext context, Luggage l) {
    final airportName = l.airport?.name ?? "Unknown Airport";
    final ownerName = "${l.user?.name ?? ''} ${l.user?.surname ?? ''}".trim();
    final state = (l.stateMachine ?? "").toLowerCase();

    Color statusColor = Colors.grey;
    if (state == "missing") statusColor = Colors.orange.shade400;
    if (state == "found") statusColor = Colors.green.shade600;
    if (state == "lost") statusColor = Colors.red.shade600;

    String? raw = l.description;
    String tag = "N/A";
    String desc = "N/A";

    if (raw != null && raw.contains(":")) {
      var split = raw.split(":");
      tag = split[0].replaceAll("Tag", "").trim();
      desc = split.length > 1 ? split[1].trim() : "";
    } else {
      desc = raw ?? "N/A";
    }

    return Container(
      margin: const EdgeInsets.only(bottom: 20),
      padding: const EdgeInsets.all(16),
      decoration: BoxDecoration(
        borderRadius: BorderRadius.circular(12),
        border: Border.all(color: Colors.black12),
      ),
      child: Row(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Expanded(
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text("Airport: $airportName",
                    style: const TextStyle(
                        fontSize: 20, fontWeight: FontWeight.bold)),
                const SizedBox(height: 12),

                Text("Passenger: $ownerName",
                    style: const TextStyle(fontSize: 16)),
                const SizedBox(height: 12),

                Text("TAG: $tag",
                    style: const TextStyle(
                        fontSize: 16, fontWeight: FontWeight.bold)),
                const SizedBox(height: 6),

                Text("Description: $desc",
                    style: const TextStyle(
                        fontSize: 16, fontStyle: FontStyle.italic)),
                const SizedBox(height: 12),

                Container(
                  padding:
                      const EdgeInsets.symmetric(horizontal: 12, vertical: 6),
                  decoration: BoxDecoration(
                    color: statusColor.withOpacity(0.15),
                    borderRadius: BorderRadius.circular(8),
                  ),
                  child: Text(
                    state.toUpperCase(),
                    style: TextStyle(
                      color: statusColor,
                      fontWeight: FontWeight.bold,
                      fontSize: 16,
                    ),
                  ),
                ),

                const SizedBox(height: 25),

                Row(
                  children: [
                    TextButton(
                      onPressed: () async {
                        final provider = LuggageProvider();
                        bool ok = await provider.markFound(l.luggageId!);

                        if (!ok) return;
                        ScaffoldMessenger.of(context).showSnackBar(
                          const SnackBar(content: Text("Marked as FOUND")),
                        );
                        loadLostLuggage();
                      },
                      child: const Text("Mark Found"),
                    ),

                    TextButton(
                      onPressed: () async {
                        if (state != "found") {
                          ScaffoldMessenger.of(context).showSnackBar(
                              const SnackBar(
                                  content:
                                      Text("You must mark as FOUND first!")));
                          return;
                        }

                        final provider = LuggageProvider();
                        bool ok = await provider.markPickedUp(l.luggageId!);

                        if (!ok) return;
                        ScaffoldMessenger.of(context).showSnackBar(
                            const SnackBar(
                                content: Text("Marked as PICKED UP")));
                        loadLostLuggage();
                      },
                      child: const Text("Mark Picked Up"),
                    ),

                    TextButton(
                      onPressed: () async {
                        final provider = LuggageProvider();
                        bool ok = await provider.markLost(l.luggageId!);

                        if (!ok) return;
                        ScaffoldMessenger.of(context).showSnackBar(
                            const SnackBar(content: Text("Marked as LOST")));
                        loadLostLuggage();
                      },
                      child: const Text("Mark Lost"),
                    ),

                    TextButton(
                      onPressed: () => _showPassengerPopup(context, l),
                      child: const Text("View Passenger"),
                    ),
                  ],
                ),
              ],
            ),
          ),

          const SizedBox(width: 20),

          if (l.imageUrl != null)
            ClipRRect(
              borderRadius: BorderRadius.circular(12),
              child: Image.network(
                "${BaseProvider.baseUrl}${l.imageUrl!}",
                width: 220,
                height: 220,
                fit: BoxFit.cover,
              ),
            ),
        ],
      ),
    );
  }
}


void _showPassengerPopup(BuildContext context, Luggage l) {
  final user = l.user;

  if (user == null) {
    ScaffoldMessenger.of(context)
        .showSnackBar(const SnackBar(content: Text("No passenger info")));
    return;
  }

  showDialog(
    context: context,
    builder: (_) => Dialog(
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(20)),
      child: Container(
        width: 420,
        padding: const EdgeInsets.all(20),
        child: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            ClipRRect(
              borderRadius: BorderRadius.circular(80),
               child: user.profileImageUrl == null
                  ? CircleAvatar(
                      radius: 70,
                      backgroundColor: Colors.grey.shade200,
                      child: const Icon(
                        Icons.person,
                        size: 64,
                        color: Colors.grey,
                      ),
                    )
                  : Image.network(
                      "${BaseProvider.baseUrl}${user.profileImageUrl}",
                      width: 140,
                      height: 140,
                      fit: BoxFit.cover,
                    ),
            ),

            const SizedBox(height: 20),

            _infoRow("Name", user.name),
            _infoRow("Surname", user.surname),
            _infoRow("Email", user.email),
            _infoRow("Phone", user.phoneNumber),

            const SizedBox(height: 25),

            ElevatedButton(
              onPressed: () => Navigator.pop(context),
              style: ElevatedButton.styleFrom(
                backgroundColor: Colors.blue.shade600,
                padding:
                    const EdgeInsets.symmetric(horizontal: 30, vertical: 12),
                shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(12)),
              ),
              child: const Text("Close", style: TextStyle(color: Colors.white)),
            ),
          ],
        ),
      ),
    ),
  );
}

Widget _infoRow(String label, String? value) {
  return Padding(
    padding: const EdgeInsets.symmetric(vertical: 4),
    child: Row(
      mainAxisAlignment: MainAxisAlignment.spaceBetween,
      children: [
        Text("$label:",
            style: const TextStyle(
                fontWeight: FontWeight.bold, fontSize: 16)),
        Text(value ?? "N/A", style: const TextStyle(fontSize: 16)),
      ],
    ),
  );
}
