import 'package:flutter/material.dart';
import '../widgets/employee_sidebar.dart';
import '../providers/auth_provider.dart';
import '../providers/base_provider.dart';
import '../screens/user_profile_screen.dart';

class EmployeeMasterScreen extends StatelessWidget {
  final int index;
  final Widget page;

  const EmployeeMasterScreen({
    super.key,
    required this.index,
    required this.page,
  });

  String _displayName() {
    if (AuthProvider.name != null && AuthProvider.surname != null) {
      return "${AuthProvider.name} ${AuthProvider.surname}";
    }
    return AuthProvider.email ?? "Employee";
  }

  @override
  Widget build(BuildContext context) {
    final cs = Theme.of(context).colorScheme;

    return Scaffold(
      body: Row(
        children: [
          SizedBox(
            width: 240,
            child: EmployeeSidebar(selectedIndex: index),
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
                      ),
                    ],
                  ),
                  child: Row(
                    children: [
                      const Spacer(),

                      const SizedBox(width: 8),

                      InkWell(
                        borderRadius: BorderRadius.circular(20),
                        onTap: () async {
                          await Navigator.push(
                            context,
                            MaterialPageRoute(
                              builder: (_) => const UserProfilePage(),
                            ),
                          );

                          (context as Element).markNeedsBuild();
                        },
                        child: Row(
                          children: [
                            CircleAvatar(
                              radius: 18,
                              backgroundImage: AuthProvider.profileImageUrl != null
                                  ? NetworkImage(
                                      "${BaseProvider.baseUrl}${AuthProvider.profileImageUrl}",
                                    )
                                  : null,
                              child: AuthProvider.profileImageUrl == null
                                  ? Icon(Icons.person, color: cs.primary)
                                  : null,
                            ),
                            const SizedBox(width: 8),
                            Text(
                              _displayName(),
                              style: const TextStyle(
                                fontWeight: FontWeight.w600,
                              ),
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
                    child: page,
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
