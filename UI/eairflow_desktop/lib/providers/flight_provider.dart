import 'dart:convert';
import 'package:http/http.dart' as http;
import '../models/flight.dart';
import '../providers/base_provider.dart';

class FlightProvider extends BaseProvider<Flight> {
  FlightProvider() : super("Flight");

  @override
  Flight fromJson(data) => Flight.fromJson(data);

  Future<List<Flight>> getTodayFlights() async {
    final url = Uri.parse("${BaseProvider.baseUrl}Flight/today");
    final response = await http.get(url, headers: createHeaders());

    if (response.statusCode == 200) {
      final data = jsonDecode(response.body);
      List list = data["resultList"];
      return list.map((e) => Flight.fromJson(e)).toList();
    }

    throw Exception("Failed to load today's flights");
  }

  Future<Map<String, List<String>>> getFutureLocations(int airlineId) async {
  final url = Uri.parse("${BaseProvider.baseUrl}Flight/future-locations?airlineId=$airlineId");

  final response = await http.get(url, headers: createHeaders());

  if (response.statusCode == 200) {
    final json = jsonDecode(response.body);

    return {
      "from": List<String>.from(json["from"]),
      "to": List<String>.from(json["to"]),
    };
  }

  throw Exception("Failed to load future locations");
}


  Future<bool> delay(int id) async {
    final url = Uri.parse("${BaseProvider.baseUrl}Flight/$id/delay");
    final response = await http.put(url, headers: createHeaders());
    return response.statusCode == 200;
  }

  Future<bool> cancel(int id) async {
    final url = Uri.parse("${BaseProvider.baseUrl}Flight/$id/cancel");
    final response = await http.put(url, headers: createHeaders());
    return response.statusCode == 200;
  }

  Future<bool> boarding(int id) async {
    final url = Uri.parse("${BaseProvider.baseUrl}Flight/$id/boarding");
    final response = await http.put(url, headers: createHeaders());
    return response.statusCode == 200;
  }

  Future<bool> complete(int id) async {
    final url = Uri.parse("${BaseProvider.baseUrl}Flight/$id/complete");
    final response = await http.put(url, headers: createHeaders());
    return response.statusCode == 200;
  }

  Future<bool> delayWithTime(int id, int minutes) async {
  final url = Uri.parse("${BaseProvider.baseUrl}Flight/$id/delayWithTime?minutes=$minutes");

  final response = await http.put(url, headers: createHeaders());

  return response.statusCode == 200;
  } 

  Future<bool> delete(int id) async {
  final url = Uri.parse("${BaseProvider.baseUrl}Flight/$id");

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

  throw Exception("Failed to delete flight (status ${response.statusCode})");
}

Future<Flight> insertAdmin(Map<String, dynamic> request) async {
  final url = Uri.parse("${BaseProvider.baseUrl}Flight/admin");

  print("POST -> $url");
  print("BODY -> ${jsonEncode(request)}");

  final response = await http.post(
    url,
    headers: createHeaders(),
    body: jsonEncode(request),
  );

  print("STATUS -> ${response.statusCode}");
  print("RESPONSE -> ${response.body}");

  if (response.statusCode == 200) {
    return Flight.fromJson(jsonDecode(response.body));
  } else {
    throw Exception("Failed to insert flight: ${response.statusCode}");
  }
}

Future<Map<String, dynamic>> getStats(List<int> airportIds) async {
  final ids = airportIds.join(",");
  final url = Uri.parse("${BaseProvider.baseUrl}Flight/stats?airportIds=$ids");

  final response = await http.get(url, headers: createHeaders());
  if (response.statusCode == 200) {
    print("STATS STATUS: ${response.statusCode}");
    print("STATS BODY: ${response.body}");

    return jsonDecode(response.body);
  }
  throw Exception("Failed to load dashboard stats");
}

Future<List<dynamic>> getWeeklyTrend(List<int> airportIds) async {
  final ids = airportIds.join(",");
  final url = Uri.parse("${BaseProvider.baseUrl}Flight/weekly-trend?airportIds=$ids");

  final response = await http.get(url, headers: createHeaders());

  print("TREND URL: $url");
  print("TREND STATUS: ${response.statusCode}");
  print("TREND BODY: ${response.body}");

  if (response.statusCode == 200) {
    return jsonDecode(response.body);
  }
  throw Exception("Failed to load weekly trend");
}

Future<Map<String, List<String>>> getLocations(int airlineId) async {
  final url = Uri.parse("${BaseProvider.baseUrl}Flight/locations?airlineId=$airlineId");
  final response = await http.get(url, headers: createHeaders());

  if (response.statusCode == 200) {
    final json = jsonDecode(response.body);
    return {
      "from": List<String>.from(json["from"]),
      "to": List<String>.from(json["to"]),
    };
  }
  throw Exception("Failed to load locations");
}

Future<List<String>> getDates(int airlineId, String from, String to) async {
  final url = Uri.parse(
     "${BaseProvider.baseUrl}Flight/dates?airlineId=$airlineId&from=$from&to=$to");

  final response = await http.get(url, headers: createHeaders());
  if (response.statusCode == 200) {
    return List<String>.from(jsonDecode(response.body));
  }
  throw Exception("Failed to load dates");
}

Future<List<String>> getOccupiedSeats(int flightId) async {
  final url = Uri.parse("${BaseProvider.baseUrl}Reservation/occupied/$flightId");

  final response = await http.get(
    url,
    headers: createHeaders(),
  );

  if (response.statusCode != 200) {
    throw Exception("Failed to load occupied seats");
  }

  final list = jsonDecode(response.body);
  return List<String>.from(list);
}


Future<List<Flight>> getTodayForEmployee(int empId) async {
  var url = Uri.parse("${BaseProvider.baseUrl}Flight/today/employee/$empId");
  print("GET -> $url");

  var response = await http.get(url, headers: createHeaders());

  print("STATUS -> ${response.statusCode}");
  print("BODY -> ${response.body}");

  if (response.statusCode != 200) throw Exception("Failed");

  var data = jsonDecode(response.body);
  var list = data["resultList"] as List;

  print("LIST LENGTH -> ${list.length}");

  return list.map((x) => Flight.fromJson(x)).toList();
}






}
