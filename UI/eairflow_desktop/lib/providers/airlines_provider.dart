import 'dart:convert';
import 'package:eairflow_desktop/models/airlines.dart';
import 'package:eairflow_desktop/providers/base_provider.dart';
import 'package:http/http.dart' as http;

class AirlinesProvider extends BaseProvider<Airline> {
  AirlinesProvider(): super("Airline");

  @override
  Airline fromJson(data) {
    return Airline.fromJson(data);
  }

  Future<List<Airline>> getByAirport(int airportId) async {
  var url = "${BaseProvider.baseUrl}Airline?airportId=$airportId";

  final uri = Uri.parse(url);
  final response = await http.get(uri, headers: createHeaders());

  if (response.statusCode >= 200 && response.statusCode < 300) {
    final data = jsonDecode(response.body);
    List list = data['resultList'];
    return list.map((e) => Airline.fromJson(e)).toList();
  } else {
    throw Exception("Failed to load airlines for airport");
  }
}

Future<bool> delete(int id) async {
  final url = Uri.parse("${BaseProvider.baseUrl}Airline/$id");

  print("DELETE -> $url");

  final response = await http.delete(
    url,
    headers: createHeaders(),
  );

  print("Status: ${response.statusCode}");
  print("Body: ${response.body}");

  if (response.statusCode == 200) {
    return true;
  }

  throw Exception("Failed to delete airline (status ${response.statusCode})");
}




}