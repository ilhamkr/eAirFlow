import 'package:eairflow_desktop/layouts/admin_master_screen.dart';
import 'package:eairflow_desktop/screens/admin_flight_screen.dart';
import 'package:eairflow_desktop/screens/admin_home_screen.dart';
import 'package:eairflow_desktop/screens/admin_position_screen.dart';
import 'package:eairflow_desktop/screens/admin_users_screen.dart';
import 'package:flutter/material.dart';
import '../screens/login_screen.dart';
import '../providers/auth_provider.dart';

class AdminSidebar extends StatelessWidget {
  final int selectedIndex;

  const AdminSidebar({super.key, required this.selectedIndex});

  Widget _item(
    BuildContext context,
    int index,
    IconData icon,
    String label,
    Widget page,
  ) {
    final bool selected = index == selectedIndex;

    return Container(
      margin: const EdgeInsets.symmetric(horizontal: 8, vertical: 4),
      decoration: BoxDecoration(
        color: selected ? Colors.white.withOpacity(0.12) : Colors.transparent,
        borderRadius: BorderRadius.circular(12),
      ),
      child: ListTile(
        leading: Icon(icon, color: Colors.white),
        title: Text(
          label,
          style: TextStyle(
            color: Colors.white,
            fontWeight: selected ? FontWeight.bold : FontWeight.normal,
          ),
        ),
        onTap: () {
          if (!selected) {
            Navigator.pushReplacement(
              context,
              MaterialPageRoute(
                builder: (_) => AdminMasterScreen(
                  index: index,
                  page: page,
                ),
              ),
            );
          }
        },
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    final cs = Theme.of(context).colorScheme;

    return Container(
      width: 240,
      color: cs.primary,
      child: SafeArea(
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            const SizedBox(height: 16),

            Padding(
              padding: const EdgeInsets.symmetric(horizontal: 16),
              child: Row(
                children: const [
                  Icon(Icons.work, color: Colors.white, size: 26),
                  SizedBox(width: 8),
                  Text(
                    "Admin Panel",
                    style: TextStyle(
                      color: Colors.white,
                      fontSize: 18,
                      fontWeight: FontWeight.w700,
                    ),
                  ),
                ],
              ),
            ),

            const SizedBox(height: 20),

            _item(
              context,
              0,
              Icons.dashboard,
              "Dashboard",
              const AdminHomeScreen(),
            ),

            _item(
              context,
              1,
              Icons.flight,
              "Flights Panel",
              const AdminFlightsScreen(),
            ),

            _item(
              context,
              2,
              Icons.people_alt,
              "Users Panel",
              const AdminUserScreen(),
            ),

            _item(
              context,
              3,
              Icons.work,
              "Positions Panel",
              const AdminPositionScreen(),
            ),

            const Spacer(),

            ListTile(
              leading: const Icon(Icons.logout_rounded, color: Colors.white),
              title:
                  const Text("Logout", style: TextStyle(color: Colors.white)),
              onTap: () {
                AuthProvider.clear();
                Navigator.pushAndRemoveUntil(
                  context,
                  MaterialPageRoute(builder: (_) => const LoginPage()),
                  (_) => false,
                );
              },
            ),

            const SizedBox(height: 12),
          ],
        ),
      ),
    );
  }
}
