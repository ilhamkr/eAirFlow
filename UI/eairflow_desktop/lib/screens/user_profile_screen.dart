import 'dart:typed_data';
import 'package:eairflow_desktop/providers/base_provider.dart';
import 'package:file_picker/file_picker.dart';
import 'package:flutter/material.dart';
import 'package:eairflow_desktop/providers/auth_provider.dart';
import 'package:eairflow_desktop/providers/user_provider.dart';
import 'package:eairflow_desktop/models/user.dart';
import 'package:eairflow_desktop/providers/reservation_provider.dart';

class UserProfilePage extends StatefulWidget {
  const UserProfilePage({super.key});

  @override
  State<UserProfilePage> createState() => _UserProfilePageState();
}

class _UserProfilePageState extends State<UserProfilePage> {
  bool _isLoading = true;
  bool _isSaving = false;
  bool _isEdit = false;
  bool _hovering = false;
  bool _hasReservation = false;

  String? _profileImageUrl;
  User? _user;

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
    setState(() => _isLoading = true);

    try {
      final userProv = UserProvider();
      final res = await userProv.get(filter: {"email": AuthProvider.email});

      if (res.result.isEmpty) throw Exception("User not found!");

      _user = res.result.first;
      AuthProvider.profileImageUrl = _user?.profileImageUrl;
      _profileImageUrl = _user?.profileImageUrl;

      _nameCtrl.text = _user?.name ?? "";
      _surnameCtrl.text = _user?.surname ?? "";
      _emailCtrl.text = _user?.email ?? "";
      _phoneCtrl.text = _user?.phoneNumber ?? "";
      _positionCtrl.text = _user?.employee?.position?.name ?? "";
      _airportCtrl.text = _user?.employee?.airport?.name ?? "";
      print("Loaded profileImageUrl: ${_user?.profileImageUrl}");

       if (AuthProvider.userId != null) {
        final reservationProvider = ReservationProvider();
        final reservations =
            await reservationProvider.getByUser(AuthProvider.userId!);
        _hasReservation = reservations.any((r) =>
            (r.flight?.stateMachine?.toLowerCase() ?? "") != "completed");
      }

    } catch (e) {
      if (mounted) {
        ScaffoldMessenger.of(context)
            .showSnackBar(SnackBar(content: Text("Failed to load user: $e")));
      }
    } finally {
      if (mounted) setState(() => _isLoading = false);
    }
  }

  Future<void> _pickAndUploadImage() async {
    print("_pickAndUploadImage called!");
    if (_user == null) return;

    final result = await FilePicker.platform.pickFiles(
      type: FileType.image,
      allowMultiple: false,
      withData: true,
    );

    if (result == null) {
      print("No file selected.");
      return;
    }

    print("Picked: ${result.files.single.name}");
    print("Bytes null? ${result.files.single.bytes == null}");

    Uint8List? bytes = result.files.single.bytes;
    String fileName = result.files.single.name;

    if (bytes == null) {
      print(" ERROR: FilePicker returned NO BYTES");
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(content: Text("Could not read file bytes")),
      );
      return;
    }

    try {
      final prov = UserProvider();
      final uploadedUrl =
          await prov.uploadProfileImage(_user!.userId!, bytes, fileName);

      print("UPLOAD SUCCESS: $uploadedUrl");

      setState(() {
        _profileImageUrl = uploadedUrl;
        AuthProvider.profileImageUrl = uploadedUrl;
      });

      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(content: Text("Profile picture updated")),
      );
    } catch (e) {
      print("UPLOAD ERROR: $e");
      ScaffoldMessenger.of(context)
          .showSnackBar(SnackBar(content: Text("Upload failed: $e")));
    }
  }

  Future<void> _save() async {
    if (!_formKey.currentState!.validate()) return;
    if (_user?.userId == null) return;

    setState(() => _isSaving = true);

    try {
      final userProv = UserProvider();

      final req = {
        "name": _nameCtrl.text.trim(),
        "surname": _surnameCtrl.text.trim(),
        "email": _emailCtrl.text.trim(),
        "phoneNumber": _phoneCtrl.text.trim(),
      };

      final updated = await userProv.update(_user!.userId!, req);

      _user = updated;
      AuthProvider.name = updated.name;
      AuthProvider.surname = updated.surname;
      AuthProvider.email = updated.email;

      if (mounted) {
        setState(() => _isEdit = false);
        ScaffoldMessenger.of(context)
            .showSnackBar(const SnackBar(content: Text("Profile updated")));
      }
    } catch (e) {
      ScaffoldMessenger.of(context)
          .showSnackBar(SnackBar(content: Text("Update failed: $e")));
    } finally {
      if (mounted) setState(() => _isSaving = false);
    }
  }

  @override
  Widget build(BuildContext context) {
    final cs = Theme.of(context).colorScheme;

    return Scaffold(
      appBar: AppBar(
        title: const Text("Your Profile"),
        actions: [
          if (!_isLoading && !_isEdit)
            TextButton.icon(
               onPressed:
                  _hasReservation ? null : () => setState(() => _isEdit = true),
              icon: const Icon(Icons.edit),
              label: const Text("Edit"),
            ),
          if (!_isLoading && _isEdit)
            TextButton.icon(
              onPressed: _isSaving ? null : _save,
              icon: _isSaving
                  ? const SizedBox(
                      width: 16,
                      height: 16,
                      child: CircularProgressIndicator(
                        strokeWidth: 2,
                        color: Colors.white,
                      ),
                    )
                  : const Icon(Icons.save),
              label: const Text("Save"),
            ),
          const SizedBox(width: 10),
        ],
      ),
      body: _isLoading
          ? const Center(child: CircularProgressIndicator())
          : Container(
              color: cs.primary,
              width: double.infinity,
              height: double.infinity,
              child: Center(
                child: ConstrainedBox(
                  constraints: const BoxConstraints(maxWidth: 900),
                  child: Card(
                    elevation: 8,
                    shape: RoundedRectangleBorder(
                      borderRadius: BorderRadius.circular(20),
                    ),
                    child: Padding(
                      padding: const EdgeInsets.all(28),
                      child: Column(
                        mainAxisSize: MainAxisSize.min,
                        children: [
                          Column(
                            children: [
                               if (_hasReservation)
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
                                      "Personal details cannot be edited after a reservation is made.",
                                      style:
                                          TextStyle(fontWeight: FontWeight.w600),
                                    ),
                                  )
                                ],
                              ),
                            ),
                              MouseRegion(
                                onEnter: (_) => setState(() => _hovering = true),
                                onExit: (_) => setState(() => _hovering = false),
                                child: GestureDetector(
                                  onTap: _pickAndUploadImage,
                                  child: Stack(
                                    alignment: Alignment.center,
                                    children: [
                                      CircleAvatar(
                                        radius: 48,
                                        backgroundImage: _profileImageUrl != null
                                            ? NetworkImage(
                                                "${BaseProvider.baseUrl}${_profileImageUrl!}")
                                            : null,
                                        backgroundColor:
                                            cs.primary.withOpacity(0.15),
                                        child: _profileImageUrl == null
                                            ? Icon(
                                                Icons.person,
                                                size: 48,
                                                color: cs.primary,
                                              )
                                            : null,
                                      ),
                                      AnimatedOpacity(
                                        opacity: _hovering ? 1 : 0,
                                        duration:
                                            const Duration(milliseconds: 200),
                                        child: Container(
                                          width: 96,
                                          height: 96,
                                          decoration: const BoxDecoration(
                                            color: Colors.black45,
                                            shape: BoxShape.circle,
                                          ),
                                          child: const Icon(
                                            Icons.camera_alt,
                                            size: 32,
                                            color: Colors.white,
                                          ),
                                        ),
                                      ),
                                    ],
                                  ),
                                ),
                              ),
                              const SizedBox(height: 12),
                              Text(
                                "${_user?.name} ${_user?.surname}",
                                style: const TextStyle(
                                  fontSize: 22,
                                  fontWeight: FontWeight.bold,
                                ),
                              ),
                            ],
                          ),
                          const SizedBox(height: 28),
                          Divider(color: cs.outlineVariant),
                          const SizedBox(height: 28),
                          Form(
                            key: _formKey,
                            child: Column(
                              children: [
                                Row(
                                  children: [
                                    Expanded(
                                      child: TextFormField(
                                        controller: _nameCtrl,
                                        enabled: _isEdit && !_hasReservation,
                                        decoration: const InputDecoration(
                                          labelText: "Name",
                                          prefixIcon:
                                              Icon(Icons.badge_outlined),
                                        ),
                                        validator: (v) =>
                                            v!.isEmpty ? "Required" : null,
                                      ),
                                    ),
                                    const SizedBox(width: 14),
                                    Expanded(
                                      child: TextFormField(
                                        controller: _surnameCtrl,
                                        enabled: _isEdit && !_hasReservation,
                                        decoration: const InputDecoration(
                                          labelText: "Surname",
                                          prefixIcon: Icon(Icons.badge),
                                        ),
                                        validator: (v) =>
                                            v!.isEmpty ? "Required" : null,
                                      ),
                                    ),
                                  ],
                                ),

                                const SizedBox(height: 14),

                                Row(
                                  children: [
                                    Expanded(
                                      child: TextFormField(
                                        controller: _emailCtrl,
                                        enabled: _isEdit && !_hasReservation,
                                        decoration: const InputDecoration(
                                          labelText: "Email",
                                          prefixIcon:
                                              Icon(Icons.email_outlined),
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
                                    ),
                                    const SizedBox(width: 14),
                                    Expanded(
                                      child: TextFormField(
                                        controller: _positionCtrl,
                                        enabled: false,
                                        decoration: const InputDecoration(
                                          labelText: "Position",
                                          prefixIcon:
                                              Icon(Icons.work_outline),
                                        ),
                                      ),
                                    ),
                                  ],
                                ),

                                const SizedBox(height: 14),

                                Row(
                                  children: [
                                    Expanded(
                                      child: TextFormField(
                                        controller: _phoneCtrl,
                                        enabled: _isEdit && !_hasReservation,
                                        decoration: const InputDecoration(
                                          labelText: "Phone",
                                          prefixIcon:
                                              Icon(Icons.phone_outlined),
                                        ),
                                      ),
                                    ),
                                    const SizedBox(width: 14),
                                    Expanded(
                                      child: TextFormField(
                                        controller: _airportCtrl,
                                        enabled: false,
                                        decoration: const InputDecoration(
                                          labelText: "Airport",
                                          prefixIcon: Icon(
                                            Icons.location_on_outlined,
                                          ),
                                        ),
                                      ),
                                    ),
                                  ],
                                ),

                                if (_isEdit) ...[
                                  const SizedBox(height: 22),
                                  Row(
                                    mainAxisAlignment: MainAxisAlignment.end,
                                    children: [
                                      TextButton(
                                        onPressed: () {
                                          _nameCtrl.text =
                                              _user?.name ?? "";
                                          _surnameCtrl.text =
                                              _user?.surname ?? "";
                                          _emailCtrl.text =
                                              _user?.email ?? "";
                                          _phoneCtrl.text =
                                              _user?.phoneNumber ?? "";
                                          setState(() => _isEdit = false);
                                        },
                                        child: const Text("Cancel"),
                                      ),
                                      const SizedBox(width: 12),
                                      ElevatedButton.icon(
                                        onPressed: _isSaving || _hasReservation
                                            ? null
                                            : _save,
                                        icon: const Icon(Icons.save),
                                        label: const Text("Save"),
                                      ),
                                    ],
                                  ),
                                ],
                              ],
                            ),
                          ),
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
