import 'package:eairflow_desktop/providers/user_provider.dart';
import 'package:eairflow_desktop/screens/login_screen.dart';
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
  final _phoneCtrl = TextEditingController();


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
        "phoneNumber": _phoneCtrl.text.trim(),
        "password": _passwordCtrl.text.trim(),
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
        MaterialPageRoute(builder: (_) => const LoginPage()),
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

          Container(color: Colors.black.withOpacity(0.4)),

          Center(
            child: Card(
              elevation: 10,
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
                        Image.asset("assets/images/airplane-mode.png", height: 40),
                        const SizedBox(height: 12),
                        const Text(
                          "Create Your Account",
                          style: TextStyle(
                            fontSize: 22,
                            fontWeight: FontWeight.bold,
                            color: Colors.blue,
                          ),
                        ),
                        const SizedBox(height: 20),

                        TextFormField(
                          controller: _nameCtrl,
                          decoration: const InputDecoration(
                            labelText: "Name",
                            prefixIcon: Icon(Icons.badge),
                          ),
                          validator: (v) {
                            if (v == null || v.trim().isEmpty) {
                              return "Name is required";
                            }

                            if (!RegExp(r"^[A-Za-zČĆŽŠĐčćžšđ ]{2,}$").hasMatch(v)) {
                              return "Only letters allowed";
                            }

                            return null;
                          },

                        ),
                        const SizedBox(height: 12),

                        TextFormField(
                          controller: _surnameCtrl,
                          decoration: const InputDecoration(
                            labelText: "Surname",
                            prefixIcon: Icon(Icons.badge_outlined),
                          ),
                          validator: (v) {
                            if (v == null || v.trim().isEmpty) {
                              return "Surname is required";
                            }

                            if (!RegExp(r"^[A-Za-zČĆŽŠĐčćžšđ ]{2,}$").hasMatch(v)) {
                              return "Only letters allowed";
                            }

                            return null;
                          },

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

                          final emailRegex = RegExp(r"^[\w\.-]+@[\w\.-]+\.\w+$");
                          if (!emailRegex.hasMatch(v)) return "Invalid email format";

                          return null;
                        },

                        ),
                        const SizedBox(height: 12),

                        TextFormField(
                          controller: _phoneCtrl,
                          keyboardType: TextInputType.phone,
                          decoration: const InputDecoration(
                            labelText: "Phone Number",
                            prefixIcon: Icon(Icons.phone),
                          ),
                          validator: (v) {
                            if (v == null || v.trim().isEmpty) {
                              return "Phone number is required";
                            }

                            if (!RegExp(r"^\+?[0-9]+$").hasMatch(v)) {
                              return "Only numbers are allowed";
                            }

                            final digits = v.replaceAll("+", "");

                            if (digits.length < 6) {
                              return "Minimum 6 digits required";
                            }

                            if (digits.length > 15) {
                              return "Maximum 15 digits allowed";
                            }

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
                          validator: (v) {
                            if (v == null || v.trim().isEmpty) {
                              return "Password is required";
                            }

                            if (v.length < 4) {
                              return "Minimum 4 characters";
                            }

                            return null;
                          },

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
                            if (v == null || v.trim().isEmpty) {
                              return "Confirm password is required";
                            }
                          
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

                        const SizedBox(height: 12),

                        SizedBox(
                          width: double.infinity,
                          child: ElevatedButton(
                            onPressed: _loading ? null : _register,
                            style: ElevatedButton.styleFrom(
                              backgroundColor: Colors.blue,
                              minimumSize: const Size(double.infinity, 48),
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

                        const SizedBox(height: 12),

                        GestureDetector(
                          onTap: () {
                            Navigator.pushReplacement(
                              context,
                              MaterialPageRoute(
                                  builder: (_) => const LoginPage()),
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
          )
        ],
      ),
    );
  }
}
