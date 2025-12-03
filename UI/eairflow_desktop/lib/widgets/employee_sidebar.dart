import 'package:eairflow_desktop/screens/employee_checkin_screen.dart';
import 'package:flutter/material.dart';
import '../layouts/employee_master_screen.dart';
import '../screens/employee_home_screen.dart';
import '../screens/employee_flights_screen.dart';
import '../screens/employee_luggage_screen.dart';
import '../screens/login_screen.dart';
import '../providers/auth_provider.dart';

class EmployeeSidebar extends StatelessWidget {
  final int selectedIndex;

  const EmployeeSidebar({super.key, required this.selectedIndex});

  Widget _item(
      BuildContext context, 
      int index, 
      IconData icon, 
      String label, 
      Widget page) 
  {
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
                builder: (_) => EmployeeMasterScreen(
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
                    "Employee Panel",
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

            _item(context, 0, Icons.dashboard, "Dashboard",
                const EmployeeHomeScreen()),

            _item(context, 1, Icons.flight, "Today's Flights",
                const EmployeeFlightsScreen()),
            
            _item(context, 2, Icons.airplane_ticket_rounded, "Check-Ins",
                const EmployeeCheckInScreen()),

            _item(context, 3, Icons.luggage, "Luggage",
                const EmployeeLuggageScreen()),

            const Spacer(),

            ListTile(
              leading: const Icon(Icons.logout_rounded, color: Colors.white),
              title: const Text("Logout", style: TextStyle(color: Colors.white)),
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
