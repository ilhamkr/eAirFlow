import 'package:eairflow_desktop/models/airport.dart';
import 'package:eairflow_desktop/models/search_result.dart';
import 'package:eairflow_desktop/providers/base_provider.dart';
import 'package:http/http.dart' as http;

class AirportProvider extends BaseProvider<Airport> {
  AirportProvider() : super("Airport");

  @override
  Airport fromJson(data) {
    return Airport.fromJson(data);
  }

  Future<List<Airport>> getAll({String? name, String? city}) async {
    Map<String, dynamic> filter = {};

    if (name != null && name.isNotEmpty) filter['name'] = name;
    if (city != null && city.isNotEmpty) filter['city'] = city;

    SearchResult<Airport> result = await get(filter: filter);

    return result.result;
  }

  Future<bool> delete(int id) async {
  final url = Uri.parse("${BaseProvider.baseUrl}Airport/$id");

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

  throw Exception("Failed to delete airport (status ${response.statusCode})");
}

}
