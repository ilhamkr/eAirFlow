import 'package:eairflow_mobile/layouts/employee_master_screen.dart';
import 'package:eairflow_mobile/layouts/masterscreen.dart';
import 'package:eairflow_mobile/screens/employee_home_screen.dart';
import 'package:eairflow_mobile/screens/home_screen.dart';
import 'package:eairflow_mobile/screens/register_screen.dart';
import 'package:flutter/material.dart';
import 'package:eairflow_mobile/providers/user_provider.dart';
import 'package:eairflow_mobile/providers/auth_provider.dart';

class MobileLoginScreen extends StatefulWidget {
  const MobileLoginScreen({super.key});

  @override
  State<MobileLoginScreen> createState() => _MobileLoginScreenState();
}

class _MobileLoginScreenState extends State<MobileLoginScreen> {
  final _formKey = GlobalKey<FormState>();
  final _emailCtrl = TextEditingController();
  final _passCtrl = TextEditingController();

  bool _loading = false;
  String? _error;

  Future<void> _login() async {
  if (!_formKey.currentState!.validate()) return;

  setState(() {
    _loading = true;
    _error = null;
  });

  try {
    final prov = UserProvider();
    final user = await prov.login(_emailCtrl.text, _passCtrl.text);

    if (user == null) {
      setState(() => _error = "Invalid credentials");
      return;
    }

    AuthProvider.userId = user.userId;
    AuthProvider.email = user.email;
    AuthProvider.password = _passCtrl.text;
    AuthProvider.name = user.name;
    AuthProvider.surname = user.surname;
    AuthProvider.roleId = user.roleId;
    AuthProvider.positionId = user.employee?.positionId;
    AuthProvider.employeeId = user.employee?.employeeId;
    AuthProvider.profileImageUrl = user.profileImageUrl;

    AuthProvider.notify();

    if (!mounted) return;

    if (AuthProvider.roleId == 2 && AuthProvider.positionId == 1) {
      Navigator.pushReplacement(
        context,
        MaterialPageRoute(
          builder: (_) => const EmployeeMasterScreenMobile(
            0,
            EmployeeHomeScreen(),
          ),
        ),
      );
      return;
    }

    Navigator.pushReplacement(
      context,
      MaterialPageRoute(
        builder: (_) => MasterScreenMobile(0, const HomeScreen()),
      ),
    );
  } catch (e) {
    setState(() => _error = "Error logging in");
  } finally {
    setState(() => _loading = false);
  }
}



  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Center(
        child: SingleChildScrollView(
          padding: const EdgeInsets.all(20),
          child: Card(
            elevation: 5,
            shape: RoundedRectangleBorder(
              borderRadius: BorderRadius.circular(16),
            ),
            child: Padding(
              padding: const EdgeInsets.all(20),
              child: Form(
                key: _formKey,
                child: Column(
                  children: [
                    Image.asset("assets/images/airplane-mode.png", height: 80),
                    const SizedBox(height: 20),

                    Text(
                      "Welcome to eAirFlow",
                      style: Theme.of(context).textTheme.headlineSmall,
                    ),

                    const SizedBox(height: 20),

                    TextFormField(
                      controller: _emailCtrl,
                      decoration: const InputDecoration(
                        labelText: "Email",
                        prefixIcon: Icon(Icons.email),
                      ),
                      validator: (v) => v!.isEmpty ? "Required" : null,
                    ),

                    const SizedBox(height: 16),

                    TextFormField(
                      controller: _passCtrl,
                      obscureText: true,
                      decoration: const InputDecoration(
                        labelText: "Password",
                        prefixIcon: Icon(Icons.lock),
                      ),
                      validator: (v) => v!.length < 4 ? "Min 4 chars" : null,
                    ),

                    const SizedBox(height: 20),

                    if (_error != null)
                      Text(
                        _error!,
                        style: const TextStyle(color: Colors.red),
                      ),

                    const SizedBox(height: 20),

                    ElevatedButton(
                      onPressed: _loading ? null : _login,
                      style: ElevatedButton.styleFrom(
                        minimumSize: const Size(double.infinity, 50),
                      ),
                      child: _loading
                          ? const CircularProgressIndicator(
                              color: Colors.white,
                            )
                          : const Text("Login"),
                    ),

                    const SizedBox(height: 20),

                    Row(
                      mainAxisAlignment: MainAxisAlignment.center,
                      children: [
                        const Text("Don't have an account? "),
                        GestureDetector(
                          onTap: () {
                            Navigator.push(
                              context,
                              MaterialPageRoute(
                                builder: (_) => const RegisterPage(),
                              ),
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

                    const SizedBox(height: 10),
                  ],
                ),
              ),
            ),
          ),
        ),
      ),
    );
  }
}
