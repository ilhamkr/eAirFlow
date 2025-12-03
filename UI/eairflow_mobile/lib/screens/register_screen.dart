import 'package:eairflow_mobile/providers/user_provider.dart';
import 'package:eairflow_mobile/screens/login_screen.dart';
import 'package:flutter/material.dart';

class RegisterPage extends StatefulWidget {
  const RegisterPage({super.key});

  @override
  State<RegisterPage> createState() => _RegisterPageState();
}

class _RegisterPageState extends State<RegisterPage> {
  final _formKey = GlobalKey<FormState>();

  final _nameCtrl = TextEditingController();
  final _surnameCtrl = TextEditingController();
  final _emailCtrl = TextEditingController();
  final _passwordCtrl = TextEditingController();
  final _confirmCtrl = TextEditingController();

  bool _loading = false;
  String? _error;

  Future<void> _register() async {
    if (!_formKey.currentState!.validate()) return;

    setState(() => _loading = true);

    try {
      final userProv = UserProvider();

      await userProv.register({
        "name": _nameCtrl.text.trim(),
        "surname": _surnameCtrl.text.trim(),
        "email": _emailCtrl.text.trim(),
        "passsword": _passwordCtrl.text.trim(),
        "passwordConfirmation": _confirmCtrl.text.trim(),
        "roleId": 1,
      });

      if (!mounted) return;

      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(
          content: Text("Account created! Please check your email to confirm."),
        ),
      );

      Navigator.pushReplacement(
        context,
        MaterialPageRoute(builder: (_) => const MobileLoginScreen()),
      );
    } catch (e) {
      setState(() => _error = "Registration failed: $e");
    } finally {
      setState(() => _loading = false);
    }
  }

  @override
  Widget build(BuildContext context) {
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

          Container(color: Colors.black.withOpacity(0.45)),

          Center(
            child: SingleChildScrollView(
              padding: const EdgeInsets.symmetric(horizontal: 18, vertical: 24),
              child: Card(
                elevation: 10,
                color: Colors.white.withOpacity(0.92),
                shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(18),
                ),
                child: Padding(
                  padding: const EdgeInsets.symmetric(
                    horizontal: 22,
                    vertical: 26,
                  ),
                  child: Form(
                    key: _formKey,
                    child: Column(
                      mainAxisSize: MainAxisSize.min,
                      children: [
                        Image.asset(
                          "assets/images/airplane-mode.png",
                          height: 70,
                        ),

                        const SizedBox(height: 12),

                        const Text(
                          "Create Your Account",
                          style: TextStyle(
                            fontSize: 20,
                            fontWeight: FontWeight.bold,
                            color: Colors.blue,
                          ),
                        ),

                        const SizedBox(height: 18),

                        TextFormField(
                          controller: _nameCtrl,
                          decoration: const InputDecoration(
                            labelText: "Name",
                            prefixIcon: Icon(Icons.badge),
                          ),
                          validator: (v) =>
                              v == null || v.isEmpty ? "Required" : null,
                        ),
                        const SizedBox(height: 12),

                        TextFormField(
                          controller: _surnameCtrl,
                          decoration: const InputDecoration(
                            labelText: "Surname",
                            prefixIcon: Icon(Icons.person),
                          ),
                          validator: (v) =>
                              v == null || v.isEmpty ? "Required" : null,
                        ),
                        const SizedBox(height: 12),

                        TextFormField(
                          controller: _emailCtrl,
                          decoration: const InputDecoration(
                            labelText: "Email",
                            prefixIcon: Icon(Icons.email),
                          ),
                          validator: (v) {
                            if (v == null || v.isEmpty) return "Required";
                            if (!v.contains("@")) return "Invalid email";
                            return null;
                          },
                        ),
                        const SizedBox(height: 12),

                        TextFormField(
                          controller: _passwordCtrl,
                          obscureText: true,
                          decoration: const InputDecoration(
                            labelText: "Password",
                            prefixIcon: Icon(Icons.lock),
                          ),
                          validator: (v) =>
                              v != null && v.length < 4
                                  ? "Minimum 4 characters"
                                  : null,
                        ),
                        const SizedBox(height: 12),

                        TextFormField(
                          controller: _confirmCtrl,
                          obscureText: true,
                          decoration: const InputDecoration(
                            labelText: "Confirm Password",
                            prefixIcon: Icon(Icons.lock_outline),
                          ),
                          validator: (v) {
                            if (v != _passwordCtrl.text) {
                              return "Passwords must match";
                            }
                            return null;
                          },
                        ),

                        const SizedBox(height: 16),

                        if (_error != null)
                          Text(
                            _error!,
                            style: const TextStyle(color: Colors.red),
                          ),

                        const SizedBox(height: 14),

                        SizedBox(
                          width: double.infinity,
                          child: ElevatedButton(
                            onPressed: _loading ? null : _register,
                            style: ElevatedButton.styleFrom(
                              backgroundColor: Colors.blue,
                              minimumSize: const Size(double.infinity, 48),
                              shape: RoundedRectangleBorder(
                                borderRadius: BorderRadius.circular(10),
                              ),
                            ),
                            child: _loading
                                ? const CircularProgressIndicator(
                                    color: Colors.white)
                                : const Text(
                                    "Create Account",
                                    style: TextStyle(
                                      color: Colors.white,
                                      fontWeight: FontWeight.bold,
                                    ),
                                  ),
                          ),
                        ),

                        const SizedBox(height: 14),

                        GestureDetector(
                          onTap: () {
                            Navigator.pushReplacement(
                              context,
                              MaterialPageRoute(
                                  builder: (_) => const MobileLoginScreen()),
                            );
                          },
                          child: const Text(
                            "Already have an account? Login",
                            style: TextStyle(
                              color: Colors.blue,
                              decoration: TextDecoration.underline,
                            ),
                          ),
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
