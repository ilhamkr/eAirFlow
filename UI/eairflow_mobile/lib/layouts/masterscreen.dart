import 'package:eairflow_mobile/providers/auth_provider.dart';
import 'package:eairflow_mobile/providers/base_provider.dart';
import 'package:eairflow_mobile/providers/notification_provider.dart';
import 'package:eairflow_mobile/screens/user_profile_screen.dart';
import 'package:eairflow_mobile/widgets/sidebar.dart';
import 'package:flutter/material.dart';


class MasterScreenMobile extends StatefulWidget {
  final int selectedIndex;
  final Widget child;

  const MasterScreenMobile(this.selectedIndex, this.child, {super.key});

  String displayName() {
    if (AuthProvider.name != null && AuthProvider.surname != null) {
      return "${AuthProvider.name} ${AuthProvider.surname}";
    }
    if (AuthProvider.email != null) {
      return AuthProvider.email!;
    }
    return "User";
  }

  @override
  State<MasterScreenMobile> createState() => _MasterScreenMobileState();
}

class _MasterScreenMobileState extends State<MasterScreenMobile> {
  int unseenCount = 0;

  @override
  void initState() {
    super.initState();
    loadUnseenCount();
  }

  Future<void> loadUnseenCount() async {
    final p = NotificationProvider();
    final userId = AuthProvider.userId;

    if (userId == null) return;

    final unseen = await p.getUnseen(userId);

    setState(() {
      unseenCount = unseen.length;
    });
  }

  Future<void> _openNotifications(BuildContext context) async {
    final p = NotificationProvider();
    final userId = AuthProvider.userId;

    if (userId == null) return;

    final unseen = await p.getUnseen(userId);

    await showDialog(
      context: context,
      builder: (_) => AlertDialog(
        title: const Text("Notifications"),
        content: SizedBox(
          width: MediaQuery.of(context).size.width * 0.8,
          child: unseen.isEmpty
              ? const Text("No new notifications")
              : Column(
                  mainAxisSize: MainAxisSize.min,
                  children: unseen.map((n) {
                    return ListTile(
                      title: Text(n.message ?? ""),
                      subtitle: Text(n.sentAt ?? ""),
                      leading: const Icon(Icons.notifications),
                      onTap: () async {
                        await p.markSeen(n.notificationId!);
                        await loadUnseenCount();
                        Navigator.of(context).pop();
                      },
                    );
                  }).toList(),
                ),
        ),
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    final cs = Theme.of(context).colorScheme;

    return Scaffold(
      backgroundColor: Colors.white,
      drawer: MobileSidebar(selectedIndex: widget.selectedIndex),

      appBar: AppBar(
        backgroundColor: cs.surface,
        elevation: 2,
        iconTheme: IconThemeData(color: cs.primary),

        title: Text(
          "AirFlow",
          style: TextStyle(color: cs.primary, fontWeight: FontWeight.w700),
        ),

        actions: [
          Stack(
            children: [
              IconButton(
                icon: const Icon(Icons.notifications_outlined),
                onPressed: () async => await _openNotifications(context),
              ),
              if (unseenCount > 0)
                Positioned(
                  right: 6,
                  top: 8,
                  child: Container(
                    padding: const EdgeInsets.all(4),
                    decoration: const BoxDecoration(
                      color: Colors.red,
                      shape: BoxShape.circle,
                    ),
                    child: Text(
                      unseenCount.toString(),
                      style: const TextStyle(
                        color: Colors.white,
                        fontSize: 10,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                  ),
                ),
            ],
          ),

          const SizedBox(width: 6),

          InkWell(
            borderRadius: BorderRadius.circular(20),
            onTap: () async {
              await Navigator.of(context).push(
                MaterialPageRoute(
                  builder: (_) => const UserProfileMobile(), 
                ),
              );

              setState(() {});
            },
            child: Row(
              children: [
                CircleAvatar(
                  radius: 15,
                  backgroundImage: AuthProvider.profileImageUrl != null
                      ? NetworkImage(
                          "${BaseProvider.baseUrl}${AuthProvider.profileImageUrl}")
                      : null,
                  child: AuthProvider.profileImageUrl == null
                      ? Icon(Icons.person, color: cs.primary)
                      : null,
                ),
                const SizedBox(width: 8),
              ],
            ),
          ),
        ],
      ),

      body: Container(
        color: Colors.white,
        padding: const EdgeInsets.all(12),
        child: widget.child,
      ),
    );
  }
}
