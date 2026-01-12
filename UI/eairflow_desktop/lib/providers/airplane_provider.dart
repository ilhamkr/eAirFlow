import 'dart:convert';
import 'package:eairflow_desktop/models/airplane.dart';
import 'package:eairflow_desktop/providers/base_provider.dart';
import 'package:http/http.dart' as http;

class AirplaneProvider extends BaseProvider<Airplane> {
  AirplaneProvider() : super("Airplane");

  @override
  Airplane fromJson(data) {
    return Airplane.fromJson(data);
  }

  Future<List<Airplane>> getByAirline(int airlineId) async {
    final url = Uri.parse("${BaseProvider.baseUrl}Airplane?airlineId=$airlineId");
    final response = await http.get(url, headers: createHeaders());

    if (response.statusCode >= 200 && response.statusCode < 300) {
      final data = jsonDecode(response.body);
      List list = data['resultList'];
      return list.map((e) => Airplane.fromJson(e)).toList();
    } else {
      throw Exception("Failed to load airplanes for airline");
    }
  }

  Future<List<Airplane>> getUnassigned() async {
    final result = await get(filter: {"unassignedOnly": true});
    return result.result.cast<Airplane>();
  }

  Future<List<Airplane>> getAll() async {
    final result = await get();
    return result.result.cast<Airplane>();
  }
}