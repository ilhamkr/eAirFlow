import 'package:eairflow_desktop/models/airport.dart';
import 'package:eairflow_desktop/models/position.dart';
import 'package:eairflow_desktop/providers/airport_provider.dart';
import 'package:eairflow_desktop/providers/base_provider.dart';
import 'package:eairflow_desktop/providers/position_provider.dart';
import 'package:flutter/material.dart';
import 'package:eairflow_desktop/providers/user_provider.dart';
import 'package:eairflow_desktop/models/user.dart';

class AdminUserScreen extends StatefulWidget {
  const AdminUserScreen({super.key});

  @override
  State<AdminUserScreen> createState() => _AdminUserScreenState();
}

class _AdminUserScreenState extends State<AdminUserScreen> {
  final userProv = UserProvider();

  List<User> users = [];
  List<Position> positions = [];
  List<Airport> airports = [];
  bool loadingAirports = true;
  bool loading = true;

  @override
  void initState() {
    super.initState();
    loadUsers();
    loadPositions();
    loadAirports();
  }

  Future<void> loadAirports() async {
  final apProv = AirportProvider();
  final data = await apProv.getAll();

  setState(() {
    airports = data;
    loadingAirports = false;
  });
}

  Future<void> loadPositions() async {
  final posProv = PositionProvider();
  final data = await posProv.get();
  setState(() => positions = data.result);
}

  Future<void> loadUsers() async {
    try {
      final data = await userProv.getAllUsers();
      setState(() {
         users = data.where((x) => x.roleId != 3).toList();
        loading = false;
      });
    } catch (_) {}
  }

  void editUserDialog(User user) {
    final name = TextEditingController(text: user.name);
    final surname = TextEditingController(text: user.surname);
    final email = TextEditingController(text: user.email);
    final phone = TextEditingController(text: user.phoneNumber);

    showDialog(
      context: context,
      builder: (_) => AlertDialog(
        title: const Text("Edit User"),
        content: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            TextField(controller: name, decoration: const InputDecoration(labelText: "Name")),
            TextField(controller: surname, decoration: const InputDecoration(labelText: "Surname")),
            TextField(controller: email, decoration: const InputDecoration(labelText: "Email")),
            TextField(controller: phone, decoration: const InputDecoration(labelText: "Phone")),
          ],
        ),
        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context),
            child: const Text("Cancel"),
          ),
          ElevatedButton(
            child: const Text("Save"),
            onPressed: () async {
              await userProv.updateUser(user.userId!, {
                "name": name.text,
                "surname": surname.text,
                "email": email.text,
                "phoneNumber": phone.text,
                "roleId": user.roleId,
              });
              Navigator.pop(context);
              loadUsers();
            },
          ),
        ],
      ),
    );
  }

  void confirmDelete(User user) {
    showDialog(
      context: context,
      builder: (_) => AlertDialog(
        title: const Text("Delete User"),
        content: Text("Are you sure you want to delete ${user.name}?"),
        actions: [
          TextButton(onPressed: () => Navigator.pop(context), child: const Text("Cancel")),
          ElevatedButton(
            style: ElevatedButton.styleFrom(backgroundColor: Colors.red),
            onPressed: () async {
              await userProv.deleteUser(user.userId!);
              Navigator.pop(context);
              loadUsers();
            },
            child: const Text("Delete"),
          ),
        ],
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    if (loading) return const Center(child: CircularProgressIndicator());
    
    return Column(
    children: [
      Align(
        alignment: Alignment.centerRight,
        child: Padding(
          padding: const EdgeInsets.only(right: 12, top: 12),
          child: ElevatedButton.icon(
            icon: const Icon(Icons.add),
            label: const Text("Add User"),
            onPressed: () => showAddUserDialog(),
          ),
        ),
      ),

      const SizedBox(height: 10),

      Expanded(
        child: GridView.count(
          padding: const EdgeInsets.all(12),
          crossAxisCount: 3,
          childAspectRatio: 1.15,
          mainAxisSpacing: 12,
          crossAxisSpacing: 12,
          children: users.map((u) => buildUserCard(u)).toList(),
        ),
      ),
    ],
  );


    
  }

    Widget buildUserCard(User user) {
  return Card(
    elevation: 4,
    shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(12)),
    child: Padding(
      padding: const EdgeInsets.all(16),
      child: SingleChildScrollView(
        child: Column(
          children: [
            Row(
              children: [
                Expanded(
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text("${user.name} ${user.surname}",
                          style: const TextStyle(fontSize: 18, fontWeight: FontWeight.bold)),
                      Text(user.email ?? "-", style: const TextStyle(color: Colors.grey)),
                      Text(user.phoneNumber ?? "-", style: const TextStyle(color: Colors.grey)),
                    ],
                  ),
                ),

                CircleAvatar(
                  radius: 32,
                  backgroundColor: Colors.blue.shade100,
                  backgroundImage: (user.profileImageUrl != null)
                      ? NetworkImage("${BaseProvider.baseUrl}${user.profileImageUrl}")
                      : null,
                  child: (user.profileImageUrl == null)
                      ? const Icon(Icons.person, size: 32, color: Colors.white)
                      : null,
                ),
              ],
            ),

            const SizedBox(height: 10),

            DropdownButton<int>(
              value: user.roleId,
              isExpanded: true,
              items: const [
                DropdownMenuItem(value: 1, child: Text("User")),
                DropdownMenuItem(value: 2, child: Text("Employee")),
                DropdownMenuItem(value: 3, child: Text("Admin")),
              ],
              onChanged: (value) async {
              await userProv.changeRole(user.userId!, value!);


              loadUsers();
              },

            ),


            if (user.roleId == 2 && positions.isNotEmpty)
                DropdownButton<int>(
                value: user.employee?.positionId,
                isExpanded: true,
                hint: const Text("Select Position"),
                items: positions
                  .map((p) => DropdownMenuItem(
                    value: p.positionId,
                    child: Text(p.name ?? "Unknown"),
                  ))
                  .toList(),
                onChanged: (value) async {
                await userProv.updatePosition(user.userId!, value!);
                loadUsers();
                },
              ),

              if (user.roleId == 2 && airports.isNotEmpty)
                DropdownButton<int>(
                  value: user.employee?.airport?.airportId,
                  isExpanded: true,
                  hint: const Text("Select Airport"),
                  items: airports
                      .map(
                        (a) => DropdownMenuItem(
                          value: a.airportId,
                          child: Text(a.name ?? "Unknown"),
                        ),
                      )
                      .toList(),
                  onChanged: (value) async {
                    await userProv.updateEmployeeAirport(user.userId!, value!);
                    loadUsers();
                  },
                ),



            const SizedBox(height: 16),

            Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                ElevatedButton(
                  child: const Text("Edit"),
                  onPressed: () => editUserDialog(user),
                ),
                IconButton(
                  icon: const Icon(Icons.delete, color: Colors.red),
                  onPressed: () => confirmDelete(user),
                ),
              ],
            ),
          ],
        ),
      ),
    ),
  );
}

void showAddUserDialog() {
  final formKey = GlobalKey<FormState>();

  final nameCtrl = TextEditingController();
  final surnameCtrl = TextEditingController();
  final emailCtrl = TextEditingController();
  final phoneCtrl = TextEditingController();
  final passCtrl = TextEditingController();
  final passConfirmCtrl = TextEditingController();

  int selectedRole = 1;
  int? selectedPosition;
  int? selectedAirport;


  showDialog(
    context: context,
    builder: (_) {
      return StatefulBuilder(
        builder: (context, setStateDialog) {
          return AlertDialog(
            title: const Text("Add User"),
            content: SizedBox(
              width: 380,
              child: Form(
                key: formKey,
                child: SingleChildScrollView(
                  child: Column(
                    mainAxisSize: MainAxisSize.min,
                    children: [
                      TextFormField(
                        controller: nameCtrl,
                        decoration: const InputDecoration(labelText: "Name"),
                        validator: (v) =>
                            v == null || v.trim().isEmpty ? "Required" : null,
                      ),
                      TextFormField(
                        controller: surnameCtrl,
                        decoration: const InputDecoration(labelText: "Surname"),
                        validator: (v) =>
                            v == null || v.trim().isEmpty ? "Required" : null,
                      ),
                      TextFormField(
                        controller: emailCtrl,
                        decoration: const InputDecoration(labelText: "Email"),
                        validator: (v) =>
                            v == null || v.trim().isEmpty ? "Required" : null,
                      ),
                      TextFormField(
                        controller: phoneCtrl,
                        decoration:
                            const InputDecoration(labelText: "Phone Number"),
                      ),
                      TextFormField(
                        controller: passCtrl,
                        decoration: const InputDecoration(labelText: "Password"),
                        obscureText: true,
                        validator: (v) =>
                            v == null || v.trim().isEmpty ? "Required" : null,
                      ),
                      TextFormField(
                        controller: passConfirmCtrl,
                        decoration: const InputDecoration(
                            labelText: "Confirm Password"),
                        obscureText: true,
                        validator: (v) {
                          if (v == null || v.trim().isEmpty) {
                            return "Required";
                          }
                          if (v != passCtrl.text) {
                            return "Passwords do not match";
                          }
                          return null;
                        },
                      ),

                      const SizedBox(height: 12),

                      DropdownButtonFormField<int>(
                        value: selectedRole,
                        decoration:
                            const InputDecoration(labelText: "Role"),
                        items: const [
                          DropdownMenuItem(value: 1, child: Text("User")),
                          DropdownMenuItem(value: 2, child: Text("Employee")),
                        ],
                        onChanged: (value) {
                          setStateDialog(() {
                            selectedRole = value!;
                            if (selectedRole != 2) {
                              selectedPosition = null;
                            }
                          });
                        },
                      ),
                    ],
                  ),
                ),
              ),
            ),
            actions: [
              TextButton(
                  onPressed: () => Navigator.pop(context),
                  child: const Text("Cancel")),

              ElevatedButton(
                child: const Text("Save"),
                onPressed: () async {
                  if (!formKey.currentState!.validate()) return;

                  final request = {
                    "name": nameCtrl.text,
                    "surname": surnameCtrl.text,
                    "email": emailCtrl.text,
                    "phoneNumber": phoneCtrl.text,
                    "passsword": passCtrl.text,
                    "passwordConfirmation": passConfirmCtrl.text,
                    "roleId": selectedRole,
                  };

                  try {
                    final newUser = await userProv.register(request);

                    if (selectedRole == 2 && selectedPosition != null) {
                      await userProv.assignPosition(
                        newUser["userId"],
                        selectedPosition!,
                        selectedAirport!,
                      );
                    }

                    Navigator.pop(context);
                    loadUsers();
                  } catch (e) {
                    print("Add user error: $e");
                  }
                },
              ),
            ],
          );
        },
      );
    },
  );
}



}
