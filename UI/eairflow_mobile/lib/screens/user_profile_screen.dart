import 'dart:typed_data';
import 'package:eairflow_mobile/providers/auth_provider.dart';
import 'package:eairflow_mobile/providers/base_provider.dart';
import 'package:eairflow_mobile/providers/user_provider.dart';
import 'package:eairflow_mobile/models/user.dart';
import 'package:flutter/material.dart';
import 'package:image_picker/image_picker.dart';
import 'package:eairflow_mobile/providers/reservation_provider.dart';

class UserProfileMobile extends StatefulWidget {
  const UserProfileMobile({super.key});

  @override
  State<UserProfileMobile> createState() => _UserProfileMobileState();
}

class _UserProfileMobileState extends State<UserProfileMobile> {
  bool _loadingUser = true;
  bool _isEdit = false;
  bool _saving = false;
  bool _hasActiveReservation = false;

  User? _user;
  String? _profileImageUrl;

  final _nameCtrl = TextEditingController();
  final _surnameCtrl = TextEditingController();
  final _emailCtrl = TextEditingController();
  final _phoneCtrl = TextEditingController();
  final _positionCtrl = TextEditingController();
  final _airportCtrl = TextEditingController();


  final _formKey = GlobalKey<FormState>();

  @override
  void initState() {
    super.initState();
    _loadUser();
  }

  Future<void> _loadUser() async {
    try {
      final prov = UserProvider();
      final res = await prov.get(filter: {"email": AuthProvider.email});

      if (res.result.isEmpty) throw Exception("User not found");

      _user = res.result.first;

      _nameCtrl.text = _user?.name ?? "";
      _surnameCtrl.text = _user?.surname ?? "";
      _emailCtrl.text = _user?.email ?? "";
      _phoneCtrl.text = _user?.phoneNumber ?? "";
      _profileImageUrl = _user?.profileImageUrl;
      _positionCtrl.text = _user?.employee?.position?.name ?? "";
      _airportCtrl.text = _user?.employee?.airport?.name ?? "";


      AuthProvider.profileImageUrl = _profileImageUrl;

      if (AuthProvider.userId != null) {
        final reservationProvider = ReservationProvider();
        final reservations =
            await reservationProvider.getByUser(AuthProvider.userId!);
        _hasActiveReservation = reservations.any((r) =>
            (r.flight?.stateMachine?.toLowerCase() ?? "") != "completed");
      }
    } catch (e) {
      if (mounted) {
        ScaffoldMessenger.of(context).showSnackBar(
          SnackBar(content: Text("Failed to load profile: $e")),
        );
      }
    } finally {
      if (mounted) setState(() => _loadingUser = false);
    }
  }

  Future<void> _pickImage() async {
    if (_user == null) return;

    final picker = ImagePicker();
    final picked = await picker.pickImage(source: ImageSource.gallery);

    if (picked == null) return;

    Uint8List bytes = await picked.readAsBytes();

    try {
      final prov = UserProvider();
      final uploadedUrl = await prov.uploadProfileImage(
        _user!.userId!,
        bytes,
        picked.name,
      );

      setState(() {
        _profileImageUrl = uploadedUrl;
        AuthProvider.profileImageUrl = uploadedUrl;
      });

      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(content: Text("Profile image updated")),
      );
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text("Upload failed: $e")),
      );
    }
  }

  Future<void> _save() async {
    if (!_formKey.currentState!.validate()) return;
    if (_user == null) return;

    setState(() => _saving = true);

    try {
      final prov = UserProvider();

      final req = {
        "name": _nameCtrl.text.trim(),
        "surname": _surnameCtrl.text.trim(),
        "email": _emailCtrl.text.trim(),
        "phoneNumber": _phoneCtrl.text.trim(),
      };

      final updated = await prov.update(_user!.userId!, req);

      setState(() {
        _user = updated;
        _isEdit = false;
      });

      AuthProvider.name = updated.name;
      AuthProvider.surname = updated.surname;
      AuthProvider.email = updated.email;

      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(content: Text("Profile updated")),
      );
    } catch (e) {
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text("Update failed: $e")),
      );
    } finally {
      setState(() => _saving = false);
    }
  }

  @override
  Widget build(BuildContext context) {
    final cs = Theme.of(context).colorScheme;

    return Scaffold(
      appBar: AppBar(
        title: const Text("Profile"),
        backgroundColor: cs.surface,
        elevation: 1,
        actions: [
           if (!_loadingUser && !_isEdit)
        IconButton(
          icon: const Icon(Icons.edit),
          onPressed:
                  _hasActiveReservation ? null : () => setState(() => _isEdit = true),
        ),
      if (_isEdit)
        IconButton(
              icon: _saving
                  ? const SizedBox(
                      width: 18,
                      height: 18,
                      child: CircularProgressIndicator(strokeWidth: 2),
                    )
                  : const Icon(Icons.save),
              onPressed: _saving ? null : _save,
            ),
        ],
      ),

      body: _loadingUser
          ? const Center(child: CircularProgressIndicator())
          : SingleChildScrollView(
              padding: const EdgeInsets.all(16),
              child: Column(
                children: [
                   if (_hasActiveReservation)
                            Container(
                              width: double.infinity,
                              padding: const EdgeInsets.all(12),
                              margin: const EdgeInsets.only(bottom: 12),
                              decoration: BoxDecoration(
                                color: cs.secondaryContainer,
                                borderRadius: BorderRadius.circular(12),
                              ),
                              child: Row(
                                children: const [
                                  Icon(Icons.info_outline,
                                      color: Colors.deepOrange),
                                  SizedBox(width: 12),
                                  Expanded(
                                    child: Text(
                                      "Personal details are locked until the booked flight is completed.",
                                      style:
                                          TextStyle(fontWeight: FontWeight.w600),
                                    ),
                                  )
                                ],
                              ),
                            ),
                  GestureDetector(
                    onTap: _pickImage,
                    child: CircleAvatar(
                      radius: 55,
                      backgroundImage: _profileImageUrl != null
                          ? NetworkImage(
                              "${BaseProvider.baseUrl}${_profileImageUrl!}")
                          : null,
                      backgroundColor: cs.primary.withOpacity(0.1),
                      child: _profileImageUrl == null
                          ? Icon(Icons.person,
                              size: 50, color: cs.primary)
                          : null,
                    ),
                  ),

                  const SizedBox(height: 14),
                  Text(
                    "${_user?.name} ${_user?.surname}",
                    style: const TextStyle(
                      fontSize: 22,
                      fontWeight: FontWeight.bold,
                    ),
                  ),

                  const SizedBox(height: 24),

                  Form(
                    key: _formKey,
                    child: Column(
                      children: [
                        TextFormField(
                          controller: _nameCtrl,
                           enabled: _isEdit && !_hasActiveReservation,
                          decoration: const InputDecoration(
                            labelText: "Name",
                            prefixIcon: Icon(Icons.person),
                          ),
                          validator: (v) =>
                              v!.isEmpty ? "Required" : null,
                        ),
                        const SizedBox(height: 12),

                        TextFormField(
                          controller: _surnameCtrl,
                           enabled: _isEdit && !_hasActiveReservation,
                          decoration: const InputDecoration(
                            labelText: "Surname",
                            prefixIcon: Icon(Icons.person_outline),
                          ),
                          validator: (v) =>
                              v!.isEmpty ? "Required" : null,
                        ),

                        const SizedBox(height: 12),
                        TextFormField(
                          controller: _emailCtrl,
                           enabled: _isEdit && !_hasActiveReservation,
                          decoration: const InputDecoration(
                            labelText: "Email",
                            prefixIcon: Icon(Icons.email),
                          ),
                          validator: (v) {
                            if (v == null || v.isEmpty) {
                              return "Required";
                            }
                            if (!v.contains("@")) {
                              return "Invalid email";
                            }
                            return null;
                          },
                        ),

                        const SizedBox(height: 12),
                        TextFormField(
                          controller: _phoneCtrl,
                           enabled: _isEdit && !_hasActiveReservation,
                          decoration: const InputDecoration(
                            labelText: "Phone",
                            prefixIcon: Icon(Icons.phone),
                          ),
                        ),

                        if (_user?.roleId == 2 && _user?.employee != null) ...[
                          const SizedBox(height: 20),

                           TextFormField(
                            controller: _positionCtrl,
                            enabled: false,
                            decoration: const InputDecoration(
                             labelText: "Position",
                             prefixIcon: Icon(Icons.work),
                           ),
                         ),

                         const SizedBox(height: 12),

                         TextFormField(
                           controller: _airportCtrl,
                           enabled: false,
                           decoration: const InputDecoration(
                             labelText: "Airport",
                             prefixIcon: Icon(Icons.location_on),
                           ),
                         ),

                        ],


                        if (_isEdit) ...[
                          const SizedBox(height: 24),
                          SizedBox(
                            width: double.infinity,
                            child: ElevatedButton(
                               onPressed:
                                  _saving || !_hasActiveReservation ? null : _save,
                              child: _saving
                                  ? const CircularProgressIndicator(
                                      color: Colors.white)
                                  : const Text("Save changes"),
                            ),
                          )
                        ],
                      ],
                    ),
                  )
                ],
              ),
            ),
    );
  }
}
