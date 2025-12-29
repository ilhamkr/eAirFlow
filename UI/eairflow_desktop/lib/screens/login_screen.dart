import 'package:eairflow_desktop/layouts/admin_master_screen.dart';
import 'package:eairflow_desktop/layouts/employee_master_screen.dart';
import 'package:eairflow_desktop/providers/auth_provider.dart';
import 'package:eairflow_desktop/providers/user_provider.dart';
import 'package:eairflow_desktop/screens/admin_home_screen.dart';
import 'package:flutter/material.dart';
import 'home_screen.dart';
import 'employee_home_screen.dart';
import 'package:eairflow_desktop/layouts/master_screen.dart';
import 'register_screen.dart';

class LoginPage extends StatefulWidget {
  const LoginPage({super.key});

  @override
  State<LoginPage> createState() => _LoginPageState();
}

class _LoginPageState extends State<LoginPage> {
  final _formKey = GlobalKey<FormState>();
  final _usernameController = TextEditingController();
  final _passwordController = TextEditingController();

  bool _isLoading = false;
  String? _error;

  Future<void> _login() async {
  if (!_formKey.currentState!.validate()) return;

  setState(() {
    _isLoading = true;
    _error = null;
  });

  try {
    final userProvider = UserProvider();
    final user = await userProvider.login(
      _usernameController.text,
      _passwordController.text,
    );

    if (user == null) {
      setState(() => _error = "Invalid email or password");
      return;
    }

    AuthProvider.userId = user.userId;
    AuthProvider.email = user.email;
    AuthProvider.name = user.name;
    AuthProvider.surname = user.surname;
    AuthProvider.phoneNumber = user.phoneNumber;
    AuthProvider.password = _passwordController.text;

    AuthProvider.roleId = user.roleId;
    AuthProvider.employeeId = user.employee?.employeeId;
    AuthProvider.positionId = user?.employee?.positionId;
    AuthProvider.profileImageUrl= user.profileImageUrl;
    AuthProvider.notify();

    if (!mounted) return;

    if (AuthProvider.roleId == 3) {
      Navigator.pushReplacement(
        context,
        MaterialPageRoute(
          builder: (_) => const AdminMasterScreen(
            index: 0,
            page: AdminHomeScreen(),
          ),
        ),
      );
      return;
    }

    if (AuthProvider.roleId == 2) {
      if (AuthProvider.positionId==1) {
        Navigator.pushReplacement(
          context,
          MaterialPageRoute(
            builder: (_) => const EmployeeMasterScreen(
              index: 0,
              page: EmployeeHomeScreen(),
            ),
          ),
        );
      } else {
        setState(() {
          _error = "Access Denied: Your position has no permissions.";
        });
      }
      return;
    }

    Navigator.pushReplacement(
      context,
      MaterialPageRoute(
        builder: (_) => MasterScreen(0, const HomeScreen()),
      ),
    );
  } catch (e) {
    setState(() => _error = "Login failed");
  } finally {
    setState(() => _isLoading = false);
  }
}



  @override
  Widget build(BuildContext context) {
    final theme = Theme.of(context);

    return Scaffold(
      body: Stack(
        children: [
          Container(
            decoration: const BoxDecoration(
              image: DecorationImage(
                image: AssetImage("assets/images/login-background.jpg"),
                fit: BoxFit.cover,
              ),
            ),
          ),
          Container(color: Colors.black.withOpacity(0.4)),

          Center(
            child: Card(
              elevation: 8,
              color: Colors.white.withOpacity(0.9),
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(20),
              ),
              child: Padding(
                padding: const EdgeInsets.all(28),
                child: ConstrainedBox(
                  constraints: const BoxConstraints(maxWidth: 400),
                  child: Form(
                    key: _formKey,
                    child: Column(
                      mainAxisSize: MainAxisSize.min,
                      children: [
                        Image.asset("assets/images/airplane-mode.png",
                            height: 90),
                        const SizedBox(height: 16),
                        Text(
                          "Welcome to eAirFlow",
                          style: theme.textTheme.headlineSmall?.copyWith(
                            fontWeight: FontWeight.bold,
                            color: Colors.blue.shade700,
                          ),
                        ),
                        const SizedBox(height: 24),

                        TextFormField(
                          controller: _usernameController,
                          decoration: const InputDecoration(
                            labelText: "Email",
                            prefixIcon: Icon(Icons.email),
                          ),
                          validator: (v) {
                            if (v == null || v.isEmpty) return "Required";
                            if (!v.contains("@")) return "Invalid email format";
                            return null;
                          },
                        ),

                        const SizedBox(height: 16),

                        TextFormField(
                          controller: _passwordController,
                          obscureText: true,
                          decoration: const InputDecoration(
                            labelText: "Password",
                            prefixIcon: Icon(Icons.lock),
                          ),
                          validator: (v) => v != null && v.length < 4
                              ? "Min 4 characters"
                              : null,
                        ),

                        const SizedBox(height: 24),

                        if (_error != null)
                          Text(_error!,
                              style: const TextStyle(color: Colors.red)),
                        const SizedBox(height: 8),

                        SizedBox(
                          width: double.infinity,
                          child: ElevatedButton(
                            onPressed: _isLoading ? null : _login,
                            style: ElevatedButton.styleFrom(
                              backgroundColor: Colors.blue,
                              minimumSize: const Size(double.infinity, 48),
                            ),
                            child: _isLoading
                                ? const CircularProgressIndicator(
                                    color: Colors.white)
                                : const Text(
                                    "Login",
                                    style: TextStyle(
                                        color: Colors.white,
                                        fontWeight: FontWeight.bold),
                                  ),
                          ),
                        ),

                        const SizedBox(height: 16),

                        Row(
                          mainAxisAlignment: MainAxisAlignment.center,
                          children: [
                            const Text("Don't have an account? "),
                            GestureDetector(
                              onTap: () {
                                Navigator.push(
                                  context,
                                  MaterialPageRoute(
                                      builder: (_) => const RegisterPage()),
                                );
                              },
                              child: const Text(
                                "Create one",
                                style: TextStyle(
                                  color: Colors.blue,
                                  fontWeight: FontWeight.bold,
                                  decoration: TextDecoration.underline,
                                ),
                              ),
                            ),
                          ],
                        ),
                      ],
                    ),
                  ),
                ),
              ),
            ),
          ),
        ],
      ),
    );
  }
}
