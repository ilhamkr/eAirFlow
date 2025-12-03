import 'package:eairflow_desktop/providers/auth_provider.dart';
import 'package:eairflow_desktop/screens/luggage_screen.dart';
import 'package:eairflow_desktop/screens/my_trips_screen.dart';
import 'package:eairflow_desktop/screens/user_review_screen.dart';
import 'package:flutter/material.dart';
import '../layouts/master_screen.dart';
import '../screens/home_screen.dart';
import '../screens/login_screen.dart';

class AppSidebar extends StatelessWidget {
  final int selectedIndex;
  const AppSidebar({super.key, required this.selectedIndex});

  Widget _item(
    BuildContext context,
    int index,
    IconData icon,
    String label,
    Widget child,
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
            Navigator.of(context).pushReplacement(
              MaterialPageRoute(
                builder: (_) => MasterScreen(index, child),
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
                  Icon(Icons.flight_takeoff, color: Colors.white, size: 26),
                  SizedBox(width: 8),
                  Text(
                    "AirFlow",
                    style: TextStyle(
                      color: Colors.white,
                      fontSize: 18,
                      fontWeight: FontWeight.w700,
                    ),
                  ),
                ],
              ),
            ),

            const SizedBox(height: 16),


            _item(context, 0, Icons.dashboard_rounded, "Dashboard", const HomeScreen()),

            _item(
              context,
              1,
              Icons.airplane_ticket_rounded,
              "My trips",
              const MyTripsScreen(),
            ),

            _item(context, 2, Icons.luggage, "Luggage", const LuggageScreen()),

            _item(context, 3, Icons.reviews, "Reviews", const UserReviewsScreen()),

            const Spacer(),

            ListTile(
              leading: const Icon(Icons.logout_rounded, color: Colors.white),
              title: const Text("Sign out", style: TextStyle(color: Colors.white)),
              onTap: () {
                Navigator.of(context).pushAndRemoveUntil(
                  MaterialPageRoute(builder: (_) => const LoginPage()),
                  (_) => false,
                );
              },
            ),

            const SizedBox(height: 8),
          ],
        ),
      ),
    );
  }
}
