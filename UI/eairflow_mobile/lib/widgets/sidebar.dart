import 'package:eairflow_mobile/layouts/masterscreen.dart';
import 'package:eairflow_mobile/screens/luggage_screen.dart';
import 'package:eairflow_mobile/screens/my_trips_screen.dart';
import 'package:eairflow_mobile/screens/user_review_screen.dart';
import 'package:flutter/material.dart';
import '../screens/home_screen.dart';
import '../screens/login_screen.dart';

class MobileSidebar extends StatelessWidget {
  final int selectedIndex;
  const MobileSidebar({super.key, required this.selectedIndex});

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
        color: selected ? Colors.blue.withOpacity(0.15) : Colors.transparent,
        borderRadius: BorderRadius.circular(12),
      ),
      child: ListTile(
        leading: Icon(icon, color: Colors.blue.shade700),
        title: Text(
          label,
          style: TextStyle(
            color: Colors.blue.shade900,
            fontWeight: selected ? FontWeight.bold : FontWeight.normal,
          ),
        ),
        onTap: () {
          Navigator.pop(context);

          if (!selected) {
            Navigator.of(context).pushReplacement(
              MaterialPageRoute(
                builder: (_) => MasterScreenMobile(index, child),
              ),
            );
          }
        },
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    return Drawer(
      child: SafeArea(
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            const SizedBox(height: 16),

            Padding(
              padding: const EdgeInsets.symmetric(horizontal: 16),
              child: Row(
                children: [
                  Icon(Icons.flight_takeoff,
                      color: Colors.blue.shade700, size: 26),
                  const SizedBox(width: 8),
                  Text(
                    "AirFlow",
                    style: TextStyle(
                      color: Colors.blue.shade800,
                      fontSize: 18,
                      fontWeight: FontWeight.w700,
                    ),
                  ),
                ],
              ),
            ),

            const SizedBox(height: 16),

            _item(context, 0, Icons.dashboard_rounded, "Dashboard",
                const HomeScreen()),

            _item(context, 1, Icons.airplane_ticket_rounded, "My trips",
                const MyTripsMobile()),

            _item(context, 2, Icons.luggage, "Luggage", const LuggageScreenMobile()),

            _item(context, 3, Icons.reviews, "Reviews",
                const UserReviewsScreenMobile()),

            const Spacer(),

            ListTile(
              leading: const Icon(Icons.logout_rounded, color: Colors.red),
              title: const Text(
                "Sign out",
                style: TextStyle(color: Colors.red),
              ),
              onTap: () {
                Navigator.of(context).pushAndRemoveUntil(
                  MaterialPageRoute(builder: (_) => const MobileLoginScreen()),
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
