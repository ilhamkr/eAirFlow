import 'dart:convert';
import 'package:eairflow_mobile/models/checkin.dart';
import 'package:eairflow_mobile/providers/base_provider.dart';
import 'package:http/http.dart' as http;

class CheckInProvider extends BaseProvider<CheckIn> {
  CheckInProvider() : super("CheckIn");

  @override
  CheckIn fromJson(data) => CheckIn.fromJson(data);

  @override
  Future<CheckIn> insert(dynamic data) async {
  final url = Uri.parse("${BaseProvider.baseUrl}CheckIn");

    final response = await http.post(
      url,
      headers: createHeaders(),
      body: jsonEncode(data),
    );

    return CheckIn.fromJson(jsonDecode(response.body));
  }


  Future<bool> confirm(int id) async {
    final url = Uri.parse("${BaseProvider.baseUrl}CheckIn/$id/confirm");
    final res = await http.put(url, headers: createHeaders());
    return res.statusCode == 200;
  }

  Future<bool> cancel(int id) async {
    final url = Uri.parse("${BaseProvider.baseUrl}CheckIn/$id/cancel");
    final res = await http.put(url, headers: createHeaders());
    return res.statusCode == 200;
  }

  Future<bool> complete(int id) async {
    final url = Uri.parse("${BaseProvider.baseUrl}CheckIn/$id/complete");
    final res = await http.put(url, headers: createHeaders());
    return res.statusCode == 200;
  }

  Future<List<CheckIn>> getAll() async {
  final url = Uri.parse("${BaseProvider.baseUrl}CheckIn");
  final response = await http.get(url, headers: createHeaders());

  final data = jsonDecode(response.body);
  final list = data["resultList"] as List;

  return list.map((e) => CheckIn.fromJson(e)).toList();
}

Future<List<CheckIn>> getForEmployee(int empId) async {
  var url = Uri.parse("${BaseProvider.baseUrl}CheckIn/employee/$empId");
  var response = await http.get(url, headers: createHeaders());

  if (response.statusCode != 200) {
    throw Exception("Server error: ${response.statusCode}");
  }

  try {
    var data = jsonDecode(response.body);
    var list = data["resultList"] as List;
    return list.map((x) => CheckIn.fromJson(x)).toList();
  } catch (e) {
    throw e;
  }
}

 Future<List<CheckIn>> getForUser(int userId) async {
    final url = Uri.parse("${BaseProvider.baseUrl}CheckIn?UserId=$userId");

    final response = await http.get(url, headers: createHeaders());

    if (response.statusCode != 200) {
      throw Exception("Server error: ${response.statusCode}");
    }

    final data = jsonDecode(response.body);
    final list = data["resultList"] as List;
    return list.map((e) => CheckIn.fromJson(e)).toList();
  }

}
