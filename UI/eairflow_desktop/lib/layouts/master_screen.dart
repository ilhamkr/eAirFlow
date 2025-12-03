import 'package:eairflow_desktop/providers/base_provider.dart';
import 'package:eairflow_desktop/providers/notification_provider.dart';
import 'package:flutter/material.dart';
import '../widgets/sidebar.dart';
import '../providers/auth_provider.dart';
import '../screens/user_profile_screen.dart';

class MasterScreen extends StatefulWidget {
  final int selectedIndex;
  final Widget child;

  const MasterScreen(this.selectedIndex, this.child, {super.key});

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
  State<MasterScreen> createState() => _MasterScreenState();
}

class _MasterScreenState extends State<MasterScreen> {
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
          width: 400,
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
      body: Row(
        children: [
          SizedBox(
            width: 240,
            child: AppSidebar(selectedIndex: widget.selectedIndex),
          ),

          Expanded(
            child: Column(
              children: [
                Container(
                  height: 64,
                  padding: const EdgeInsets.symmetric(horizontal: 16),
                  decoration: BoxDecoration(
                    color: cs.surface,
                    boxShadow: [
                      BoxShadow(
                        color: Colors.black.withOpacity(0.05),
                        blurRadius: 8,
                        offset: const Offset(0, 2),
                      )
                    ],
                  ),
                  child: Row(
                    children: [
                      const SizedBox(width: 12),
                      const Spacer(),

                      Stack(
                        children: [
                          IconButton(
                            onPressed: () async {
                              await _openNotifications(context);
                            },
                            icon: const Icon(Icons.notifications_outlined),
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

                      const SizedBox(width: 8),

                      InkWell(
                        borderRadius: BorderRadius.circular(20),
                        onTap: () async {
                          await Navigator.of(context).push(
                            MaterialPageRoute(
                              builder: (_) => const UserProfilePage(),
                            ),
                          );

                          setState(() {});
                        },
                        child: Row(
                          children: [
                            CircleAvatar(
                              radius: 18,
                              backgroundImage: AuthProvider.profileImageUrl != null
                                  ? NetworkImage("${BaseProvider.baseUrl}${AuthProvider.profileImageUrl}")
                                  : null,
                              child: AuthProvider.profileImageUrl == null
                                  ? Icon(Icons.person, color: cs.primary)
                                  : null,
                            ),
                            const SizedBox(width: 8),
                            Text(
                              widget.displayName(),
                              style: const TextStyle(fontWeight: FontWeight.w600),
                            ),
                          ],
                        ),
                      ),
                    ],
                  ),
                ),

                Expanded(
                  child: Container(
                    color: cs.surfaceVariant.withOpacity(0.06),
                    padding: const EdgeInsets.all(16),
                    child: widget.child,
                  ),
                ),
              ],
            ),
          ),
        ],
      ),
    );
  }
}
