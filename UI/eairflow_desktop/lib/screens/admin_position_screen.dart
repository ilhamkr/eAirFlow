import 'package:eairflow_desktop/models/position.dart';
import 'package:eairflow_desktop/providers/position_provider.dart';
import 'package:flutter/material.dart';

class AdminPositionScreen extends StatefulWidget {
  const AdminPositionScreen({super.key});

  @override
  State<AdminPositionScreen> createState() => _AdminPositionScreenState();
}

class _AdminPositionScreenState extends State<AdminPositionScreen> {
  final posProv = PositionProvider();
  List<Position> positions = [];
  bool loading = true;

  @override
  void initState() {
    super.initState();
    loadPositions();
  }

  Future<void> loadPositions() async {
    final result = await posProv.get();
    setState(() {
      positions = result.result;
      loading = false;
    });
  }

  void showPositionDialog({Position? position}) {
  final nameCtrl = TextEditingController(text: position?.name);
  final descCtrl = TextEditingController(text: position?.description);

  final formKey = GlobalKey<FormState>();

  showDialog(
    context: context,
    builder: (_) => AlertDialog(
      title: Text(position == null ? "Add Position" : "Edit Position"),
      content: SizedBox(
        width: 350,
        child: Form(
          key: formKey,
          child: Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              TextFormField(
                controller: nameCtrl,
                decoration: const InputDecoration(labelText: "Name"),
                validator: (value) {
                  if (value == null || value.trim().isEmpty) {
                    return "Name cannot be empty";
                  }
                  return null;
                },
              ),
              TextFormField(
                controller: descCtrl,
                decoration: const InputDecoration(labelText: "Description"),
                validator: (value) {
                  if (value == null || value.trim().isEmpty) {
                    return "Description cannot be empty";
                  }
                  return null;
                },
              ),
            ],
          ),
        ),
      ),
      actions: [
        TextButton(
          child: const Text("Cancel"),
          onPressed: () => Navigator.pop(context),
        ),
        ElevatedButton(
          child: Text(position == null ? "Add" : "Save"),
          onPressed: () async {
            if (!formKey.currentState!.validate()) return;

            if (position == null) {
              await posProv.insert({
                "name": nameCtrl.text,
                "description": descCtrl.text,
              });
            } else {
              await posProv.update(position.positionId!, {
                "name": nameCtrl.text,
                "description": descCtrl.text,
              });
            }

            Navigator.pop(context);
            loadPositions();
          },
        )
      ],
    ),
  );
}


  void deletePosition(Position p) {
    showDialog(
      context: context,
      builder: (_) => AlertDialog(
        title: const Text("Delete Position"),
        content: Text("Are you sure you want to delete '${p.name}'?"),
        actions: [
          TextButton(
            child: const Text("Cancel"),
            onPressed: () => Navigator.pop(context),
          ),
          ElevatedButton(
            style: ElevatedButton.styleFrom(backgroundColor: Colors.red),
            child: const Text("Delete"),
            onPressed: () async {
              await posProv.delete(p.positionId!);
              Navigator.pop(context);
              loadPositions();
            },
          )
        ],
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    if (loading) {
      return const Center(child: CircularProgressIndicator());
    }

    return Column(
      children: [
        const SizedBox(height: 14),

        Align(
          alignment: Alignment.centerRight,
          child: Padding(
            padding: const EdgeInsets.only(right: 16),
            child: ElevatedButton.icon(
              icon: const Icon(Icons.add),
              label: const Text("Add Position"),
              onPressed: () => showPositionDialog(),
            ),
          ),
        ),

        const SizedBox(height: 10),

        Expanded(
          child: ListView.builder(
            itemCount: positions.length,
            itemBuilder: (_, index) {
              final p = positions[index];
              return Card(
                margin: const EdgeInsets.symmetric(horizontal: 16, vertical: 8),
                child: ListTile(
                  title: Text(
                    p.name ?? "",
                    style: const TextStyle(fontWeight: FontWeight.bold),
                  ),
                  subtitle: Text(p.description ?? "-"),
                  trailing: Row(
                    mainAxisSize: MainAxisSize.min,
                    children: [
                      IconButton(
                        icon: const Icon(Icons.edit, color: Colors.blue),
                        onPressed: () => showPositionDialog(position: p),
                      ),
                      IconButton(
                        icon: const Icon(Icons.delete, color: Colors.red),
                        onPressed: () => deletePosition(p),
                      ),
                    ],
                  ),
                ),
              );
            },
          ),
        ),
      ],
    );
  }
}
