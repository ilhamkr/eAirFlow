import 'package:eairflow_mobile/providers/auth_provider.dart';
import 'package:flutter/material.dart';
import 'package:eairflow_mobile/providers/luggage_provider.dart';
import 'package:eairflow_mobile/models/luggage.dart';
import 'package:eairflow_mobile/providers/base_provider.dart';

class EmployeeLuggageScreen extends StatefulWidget {
  const EmployeeLuggageScreen({super.key});

  @override
  State<EmployeeLuggageScreen> createState() =>
      _EmployeeLuggageScreenMobileState();
}

class _EmployeeLuggageScreenMobileState
    extends State<EmployeeLuggageScreen> {
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
        child: Text("No missing luggage reported.",
            style: TextStyle(fontSize: 18)),
      );
    }

    return Scaffold(
      appBar: AppBar(
        title: const Text("Missing Luggage",
        style: TextStyle(
          fontWeight: FontWeight.bold
        ),),
      ),

      body: ListView.builder(
        padding: const EdgeInsets.all(14),
        itemCount: missingLuggage.length,
        itemBuilder: (_, i) => _luggageCard(context, missingLuggage[i]),
      ),
    );
  }


  Widget _luggageCard(BuildContext context, Luggage l) {
    final airportName = l.airport?.name ?? "Unknown Airport";
    final ownerName = "${l.user?.name ?? ''} ${l.user?.surname ?? ''}".trim();
    final s = (l.stateMachine ?? "").toLowerCase();

    Color statusColor = Colors.grey;
    if (s == "missing") statusColor = Colors.orange.shade600;
    if (s == "found") statusColor = Colors.green.shade600;
    if (s == "lost") statusColor = Colors.red.shade600;

    String tag = "N/A";
    String desc = "N/A";

    if (l.description != null && l.description!.contains(":")) {
      var split = l.description!.split(":");
      tag = split[0].replaceAll("Tag", "").trim();
      desc = split[1].trim();
    } else {
      desc = l.description ?? "N/A";
    }

    return Card(
      elevation: 4,
      margin: const EdgeInsets.only(bottom: 16),
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(14)),
      child: Padding(
        padding: const EdgeInsets.all(14),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text(
              airportName,
              style: const TextStyle(
                fontSize: 20,
                fontWeight: FontWeight.bold,
              ),
            ),

            const SizedBox(height: 8),

            Text("Passenger: $ownerName",
                style: const TextStyle(fontSize: 16)),

            const SizedBox(height: 8),

            Text("TAG: $tag",
                style:
                    const TextStyle(fontSize: 16, fontWeight: FontWeight.bold)),
            const SizedBox(height: 4),
            Text("Description: $desc",
                style: const TextStyle(
                  fontSize: 15,
                  fontStyle: FontStyle.italic,
                )),

            const SizedBox(height: 12),

            Container(
              padding: const EdgeInsets.symmetric(horizontal: 12, vertical: 6),
              decoration: BoxDecoration(
                color: statusColor.withOpacity(0.15),
                borderRadius: BorderRadius.circular(8),
              ),
              child: Text(
                s.toUpperCase(),
                style: TextStyle(
                  color: statusColor,
                  fontWeight: FontWeight.bold,
                ),
              ),
            ),

            const SizedBox(height: 16),

            if (l.imageUrl != null)
              ClipRRect(
                borderRadius: BorderRadius.circular(12),
                child: Image.network(
                  "${BaseProvider.baseUrl}${l.imageUrl}",
                  height: 160,
                  width: double.infinity,
                  fit: BoxFit.cover,
                ),
              ),

            const SizedBox(height: 16),

            Wrap(
              spacing: 8,
              runSpacing: 8,
              children: [
                _actionBtn("Mark Found", Colors.green, () async {
                  final ok = await LuggageProvider().markFound(l.luggageId!);
                  if (ok) {
                    _success("Marked as FOUND");
                    loadLostLuggage();
                  }
                }),

                _actionBtn("Mark Picked Up", Colors.blue, () async {
                  if (s != "found") {
                    _error("You must mark as FOUND first!");
                    return;
                  }

                  final ok =
                      await LuggageProvider().markPickedUp(l.luggageId!);
                  if (ok) {
                    _success("Marked as PICKED UP");
                    loadLostLuggage();
                  }
                }),

                _actionBtn("Mark Lost", Colors.red, () async {
                  final ok = await LuggageProvider().markLost(l.luggageId!);
                  if (ok) {
                    _success("Marked as LOST");
                    loadLostLuggage();
                  }
                }),

                _actionBtn("View Passenger", Colors.orange, () {
                  _showPassengerPopup(context, l);
                }),
              ],
            ),
          ],
        ),
      ),
    );
  }

  Widget _actionBtn(String text, Color color, VoidCallback tap) {
    return ElevatedButton(
      onPressed: tap,
      style: ElevatedButton.styleFrom(
        backgroundColor: color.withOpacity(0.15),
        foregroundColor: Colors.blue,
        elevation: 0,
        padding: const EdgeInsets.symmetric(horizontal: 12, vertical: 10),
      ),
      child: Text(text),
    );
  }

  void _showPassengerPopup(BuildContext context, Luggage l) {
    final user = l.user;

    if (user == null) {
      _error("No passenger info");
      return;
    }

    showModalBottomSheet(
      context: context,
      backgroundColor: Colors.white,
      shape: const RoundedRectangleBorder(
        borderRadius: BorderRadius.vertical(top: Radius.circular(22)),
      ),
      builder: (_) {
        return Padding(
          padding: const EdgeInsets.all(20),
          child: Column(
            mainAxisSize: MainAxisSize.min,
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Center(
                child: CircleAvatar(
                  radius: 50,
                  backgroundImage: user.profileImageUrl != null
                      ? NetworkImage(
                          "${BaseProvider.baseUrl}${user.profileImageUrl}")
                      : null,
                  child: user.profileImageUrl == null
                      ? const Icon(Icons.person, size: 40)
                      : null,
                ),
              ),

              const SizedBox(height: 20),

              _info("Name", user.name),
              _info("Surname", user.surname),
              _info("Email", user.email),
              _info("Phone", user.phoneNumber),

              const SizedBox(height: 16),

              Center(
                child: ElevatedButton(
                  onPressed: () => Navigator.pop(context),
                  style: ElevatedButton.styleFrom(
                    backgroundColor: Colors.blue.shade600,
                    padding: const EdgeInsets.symmetric(
                        horizontal: 20, vertical: 12),
                  ),
                  child: const Text("Close",
                      style: TextStyle(color: Colors.white)),
                ),
              ),
            ],
          ),
        );
      },
    );
  }

  Widget _info(String label, String? value) {
    return Padding(
      padding: const EdgeInsets.symmetric(vertical: 4),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          Text("$label:",
              style:
                  const TextStyle(fontWeight: FontWeight.bold, fontSize: 16)),
          Text(value ?? "N/A", style: const TextStyle(fontSize: 16)),
        ],
      ),
    );
  }

  void _success(String msg) {
    ScaffoldMessenger.of(context)
        .showSnackBar(SnackBar(content: Text(msg)));
  }

  void _error(String msg) {
    ScaffoldMessenger.of(context).showSnackBar(
      SnackBar(content: Text(msg), backgroundColor: Colors.red),
    );
  }
}
