import 'dart:convert';
import 'package:eairflow_desktop/models/position.dart';
import 'package:eairflow_desktop/providers/base_provider.dart';
import 'package:http/http.dart' as http;

class PositionProvider extends BaseProvider<Position> {
  PositionProvider() : super("Position");

  @override
  Position fromJson(data) => Position.fromJson(data);

  @override
  Future<Position> insert(dynamic request) async {
    final url = Uri.parse("${BaseProvider.baseUrl}Position");

    final response = await http.post(
      url,
      headers: createHeaders(),
      body: jsonEncode(request),
    );

    if (response.statusCode == 200) {
      return Position.fromJson(jsonDecode(response.body));
    }
    throw Exception("Failed to insert position");
  }

  @override
  Future<Position> update(int id, [dynamic request]) async {
    final url = Uri.parse("${BaseProvider.baseUrl}Position/$id");

    final response = await http.put(
      url,
      headers: createHeaders(),
      body: jsonEncode(request),
    );

    if (response.statusCode == 200) {
      return Position.fromJson(jsonDecode(response.body));
    }
    throw Exception("Failed to update position");
  }

  Future<bool> delete(int id) async {
    final url = Uri.parse("${BaseProvider.baseUrl}Position/$id");

    final response = await http.delete(url, headers: createHeaders());

    return response.statusCode == 200;
  }
}
