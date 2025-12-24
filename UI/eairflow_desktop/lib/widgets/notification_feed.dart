import 'package:flutter/material.dart';
import 'package:eairflow_desktop/providers/notification_provider.dart';
import 'package:eairflow_desktop/models/notification.dart';
import 'package:eairflow_desktop/utils/timezone_helper.dart';

class EmployeeNotificationFeed extends StatefulWidget {
  const EmployeeNotificationFeed({super.key});

  @override
  State<EmployeeNotificationFeed> createState() => _EmployeeNotificationFeedState();
}

class _EmployeeNotificationFeedState extends State<EmployeeNotificationFeed> {
  List<NotificationModel> notifications = [];
  bool loading = true;

  @override
  void initState() {
    super.initState();
    loadNotifications();
  }

  Future<void> loadNotifications() async {
    final prov = NotificationProvider();
    try {
      final data = await prov.getAll();
      setState(() {
        notifications = data.take(10).toList();
        loading = false;
      });
    } catch (e) {
      print("ERR: $e");
      loading = false;
    }
  }

  int extractMinutes(String msg) {
    final regex = RegExp(r'(\d+)\s*minute');
    final match = regex.firstMatch(msg);
    return match != null ? int.parse(match.group(1)!) : 0;
  }

  String extractRoute(String msg) {
    final regex = RegExp(
      r'from\s+([A-Za-z\s]+)\s+to\s+([A-Za-z\s]+)',
      caseSensitive: false,
    );

    final match = regex.firstMatch(msg);

    if (match != null) {
      final from = match.group(1)!.trim();
      final to = match.group(2)!.trim();
      return "$from → $to";
    }

    return "Flight";
  }

  String buildReadableMessage(NotificationModel n) {
    final msg = n.message ?? "";
    final lower = msg.toLowerCase();

    if (lower.contains("cancel")) {
      final route = extractRoute(msg);
      return "$route has been cancelled.";
    }
    return msg;
  }

  Color getNotificationColor(String msg) {
    msg = msg.toLowerCase();
    if (msg.contains("delay")) return Colors.orange;
    if (msg.contains("cancel")) return Colors.red;
    if (msg.contains("check-in")) return Colors.blue;
    if (msg.contains("luggage")) return Colors.purple;
    return Colors.grey;
  }

  @override
  Widget build(BuildContext context) {
    if (loading) return const CircularProgressIndicator();

    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        const Text(
          "Live Notifications",
          style: TextStyle(fontSize: 20, fontWeight: FontWeight.bold),
        ),
        const SizedBox(height: 12),

        ...notifications.map((n) {
          final prettyMsg = buildReadableMessage(n);

          DateTime? sentTime;
          if (n.sentAt != null) {
            try {
              sentTime = DateTime.parse(n.sentAt!);
            } catch (_) {}
          }

          return Card(
            elevation: 2,
            child: ListTile(
              leading: CircleAvatar(
                backgroundColor: getNotificationColor(n.message ?? ""),
                child: const Icon(Icons.notifications, color: Colors.white),
              ),
              title: Text(prettyMsg),
              subtitle: Text(
                 sentTime != null
                    ? formatDateInTimeZone(sentTime, null)
                    : "Unknown date",
              ),
              trailing: n.isSeen == true
                  ? const Icon(Icons.check, color: Colors.green)
                  : const Icon(Icons.circle, size: 10, color: Colors.orange),
            ),
          );
        })
      ],
    );
  }
}
