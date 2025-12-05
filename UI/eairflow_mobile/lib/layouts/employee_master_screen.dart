import 'package:eairflow_mobile/widgets/employee_sidebar.dart';
import 'package:flutter/material.dart';
import 'package:eairflow_mobile/providers/auth_provider.dart';
import 'package:eairflow_mobile/providers/base_provider.dart';
import 'package:eairflow_mobile/screens/user_profile_screen.dart';

class EmployeeMasterScreenMobile extends StatefulWidget {
  final int selectedIndex;
  final Widget child;

  const EmployeeMasterScreenMobile(this.selectedIndex, this.child, {super.key});

  @override
  State<EmployeeMasterScreenMobile> createState() =>
      _EmployeeMasterScreenMobileState();
}

class _EmployeeMasterScreenMobileState
    extends State<EmployeeMasterScreenMobile> {

  String displayName() {
    if ((AuthProvider.name ?? "").isNotEmpty &&
        (AuthProvider.surname ?? "").isNotEmpty) {
      return "${AuthProvider.name} ${AuthProvider.surname}";
    }
    return AuthProvider.email ?? "Employee";
  }

  @override
  Widget build(BuildContext context) {
    final cs = Theme.of(context).colorScheme;

    return ValueListenableBuilder(
      valueListenable: AuthProvider.notifier,
      builder: (context, _, __) {
        return Scaffold(
          backgroundColor: Colors.white,
          drawer: EmployeeSidebarMobile(selectedIndex: widget.selectedIndex),

          appBar: AppBar(
            backgroundColor: Colors.white,
            elevation: 2,
            iconTheme: IconThemeData(color: cs.primary),

            title: Text(
              "Employee Panel",
              style: TextStyle(
                color: cs.primary,
                fontWeight: FontWeight.bold,
              ),
            ),

            actions: [
              InkWell(
                borderRadius: BorderRadius.circular(20),
                onTap: () async {
                  await Navigator.push(
                    context,
                    MaterialPageRoute(
                      builder: (_) => const UserProfileMobile(),
                    ),
                  );
                  AuthProvider.notifier.value++;
                },
                child: Padding(
                  padding: const EdgeInsets.only(right: 12),
                  child: CircleAvatar(
                    radius: 16,
                    backgroundImage: AuthProvider.profileImageUrl != null
                        ? NetworkImage(
                            "${BaseProvider.baseUrl}${AuthProvider.profileImageUrl}")
                        : null,
                    child: AuthProvider.profileImageUrl == null
                        ? Icon(Icons.person, color: cs.primary)
                        : null,
                  ),
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
      },
    );
  }
}
