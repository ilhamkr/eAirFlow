import 'dart:convert';
import 'package:eairflow_mobile/models/luggage.dart';
import 'package:eairflow_mobile/providers/base_provider.dart';
import 'package:http/http.dart' as http;

class LuggageProvider extends BaseProvider<Luggage> {
  LuggageProvider() : super("Luggage");

  @override
  Luggage fromJson(data) {
    return Luggage.fromJson(data);
  }

  Future<List<Luggage>> getMyLuggage(int userId) async {
    final url = Uri.parse("${BaseProvider.baseUrl}Luggage/my?userId=$userId");

    final response = await http.get(url, headers: createHeaders());

    if (response.statusCode == 200) {
      final data = jsonDecode(response.body);
      List list = data["resultList"];
      return list.map((e) => Luggage.fromJson(e)).toList();
    }

    throw Exception("Failed loading luggage");
  }

Future<List<Luggage>> getAllLuggage() async {
  final url = Uri.parse("${BaseProvider.baseUrl}Luggage");

  print("GET /Luggage");
  print("URL: $url");

  final response = await http.get(url, headers: createHeaders());

  print("STATUS: ${response.statusCode}");
  print("BODY: ${response.body}");

  if (response.statusCode == 200) {
    final data = jsonDecode(response.body);

    List list = data["resultList"] ?? [];

    return list.map((e) => Luggage.fromJson(e)).toList();
  }

  throw Exception("Failed to load luggage (status ${response.statusCode})");
}



  Future<bool> reportLost({
    required int userId,
    required int flightId,
    required String description,
    required String filePath,
    required int airportId,
  }) async {
    final url = Uri.parse("${BaseProvider.baseUrl}Luggage/report");

    var request = http.MultipartRequest("POST", url);

    request.headers.addAll(createHeaders());
    request.fields['userId'] = userId.toString();
    request.fields['flightId'] = flightId.toString();
    request.fields['description'] = description;
    request.fields['airportId'] = airportId.toString();

    request.files.add(await http.MultipartFile.fromPath("image", filePath));

    var response = await request.send();

    print("UPLOAD STATUS: ${response.statusCode}");

    return response.statusCode == 200;
  }

  Future<bool> markFound(int id) async {
  final url = Uri.parse("${BaseProvider.baseUrl}Luggage/found/$id");
  final response = await http.put(url, headers: createHeaders());

  print("PUT /Luggage/found/$id → ${response.statusCode}");

  return response.statusCode == 200;
}

Future<bool> markPickedUp(int id) async {
  final url = Uri.parse("${BaseProvider.baseUrl}Luggage/pickedup/$id");
  final response = await http.put(url, headers: createHeaders());

  print("PUT /Luggage/pickedup/$id → ${response.statusCode}");

  return response.statusCode == 200;
}

Future<bool> markLost(int id) async {
  final url = Uri.parse("${BaseProvider.baseUrl}Luggage/markLost/$id");
  final response = await http.put(url, headers: createHeaders());

  print("PUT /Luggage/markLost/$id → ${response.statusCode}");

  return response.statusCode == 200;
}

Future<List<Luggage>> getForEmployee(int empId) async {
  final url = Uri.parse("${BaseProvider.baseUrl}Luggage/employee/$empId");

  final response = await http.get(url, headers: createHeaders());

  if (response.statusCode == 200) {
    final data = jsonDecode(response.body);
    List list = data["resultList"];
    return list.map((e) => Luggage.fromJson(e)).toList();
  }

  throw Exception("Failed to load employee luggage");
}

}
