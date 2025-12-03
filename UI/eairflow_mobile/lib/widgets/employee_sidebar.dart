import 'package:eairflow_mobile/layouts/employee_master_screen.dart';
import 'package:eairflow_mobile/screens/employee_checkin_screen.dart';
import 'package:eairflow_mobile/screens/employee_flights_screen.dart';
import 'package:eairflow_mobile/screens/employee_home_screen.dart';
import 'package:eairflow_mobile/screens/employee_luggage_screen.dart';
import 'package:flutter/material.dart';
import 'package:eairflow_mobile/providers/auth_provider.dart';
import 'package:eairflow_mobile/screens/login_screen.dart';

class EmployeeSidebarMobile extends StatelessWidget {
  final int selectedIndex;

  const EmployeeSidebarMobile({super.key, required this.selectedIndex});

  Widget _item(
    BuildContext context,
    int index,
    IconData icon,
    String label,
    Widget page,
  ) {
    final bool selected = index == selectedIndex;

    return ListTile(
      leading: Icon(
        icon,
        color: selected ? Colors.blue.shade700 : Colors.black87,
      ),
      title: Text(
        label,
        style: TextStyle(
          color: selected ? Colors.blue.shade700 : Colors.black87,
          fontWeight: selected ? FontWeight.bold : FontWeight.normal,
        ),
      ),
      onTap: () {
        Navigator.pop(context);

        if (!selected) {
          Navigator.pushReplacement(
            context,
            MaterialPageRoute(
              builder: (_) => EmployeeMasterScreenMobile(
                index,
                page,
              ),
            ),
          );
        }
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    return Drawer(
      child: SafeArea(
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Container(
              width: double.infinity,
              padding: const EdgeInsets.all(20),
              color: Colors.blue.shade700,
              child: Row(
                children: const [
                  Icon(Icons.work, color: Colors.white, size: 30),
                  SizedBox(width: 12),
                  Text(
                    "Employee Panel",
                    style: TextStyle(
                      color: Colors.white,
                      fontSize: 20,
                      fontWeight: FontWeight.w700,
                    ),
                  )
                ],
              ),
            ),

            _item(
              context,
              0,
              Icons.dashboard,
              "Dashboard",
              const EmployeeHomeScreen(),
            ),

            _item(
              context,
              1,
              Icons.flight_takeoff,
              "Today's Flights",
              const EmployeeFlightsScreen(),
            ),

            _item(
              context,
              2,
              Icons.airplane_ticket_rounded,
              "Check-Ins",
              const EmployeeCheckInScreen(),
            ),

            _item(
              context,
              3,
              Icons.luggage,
              "Luggage",
              const EmployeeLuggageScreen(),
            ),

            const Spacer(),

            ListTile(
              leading: const Icon(Icons.logout, color: Colors.red),
              title: const Text(
                "Logout",
                style: TextStyle(color: Colors.red),
              ),
              onTap: () {
                AuthProvider.clear();

                Navigator.pushAndRemoveUntil(
                  context,
                  MaterialPageRoute(builder: (_) => const MobileLoginScreen()),
                  (_) => false,
                );
              },
            ),

            const SizedBox(height: 10),
          ],
        ),
      ),
    );
  }
}
