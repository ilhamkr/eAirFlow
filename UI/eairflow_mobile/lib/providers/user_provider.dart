import 'dart:convert';
import 'dart:typed_data';
import 'package:eairflow_mobile/models/flight.dart';
import 'package:eairflow_mobile/models/user.dart';
import 'package:eairflow_mobile/providers/auth_provider.dart';
import 'package:eairflow_mobile/providers/base_provider.dart';
import 'package:http/http.dart' as http;

class UserProvider extends BaseProvider<User> {
  UserProvider() : super("User");

  @override
  User fromJson(data) {
    return User.fromJson(data);
  }

  Future<dynamic> register(Map<String, dynamic> data) async {
    var url = "${BaseProvider.baseUrl}User/register";

    print("📩 Register POST → $url");
    print("DATA: $data");

    var response = await http.post(
      Uri.parse(url),
      headers: {"Content-Type": "application/json"},
      body: jsonEncode(data),
    );

    print("STATUS: ${response.statusCode}");
    print("BODY: ${response.body}");

    if (response.statusCode >= 200 && response.statusCode < 300) {
      return jsonDecode(response.body);
    }

    throw Exception("Registration failed: ${response.statusCode} - ${response.body}");
  }

  Future<String> uploadProfileImage(int userId, Uint8List bytes, String fileName) async {
    var url = "${BaseProvider.baseUrl}User/$userId/upload-profile";

    print("📤 Uploading to: $url");

    var request = http.MultipartRequest("POST", Uri.parse(url));

    String basicAuth =
        'Basic ${base64Encode(utf8.encode("${AuthProvider.email}:${AuthProvider.password}"))}';

    request.headers['Authorization'] = basicAuth;

    request.files.add(
      http.MultipartFile.fromBytes(
        'File',
        bytes,
        filename: fileName,
      ),
    );


    var response = await request.send();

    final resBody = await response.stream.bytesToString();

    if (response.statusCode >= 200 && response.statusCode < 300) {
      return resBody.replaceAll('"', '').trim();
    }

    throw Exception("Upload failed: ${response.statusCode} - $resBody");
  }

  Future<List<User>> getAllUsers() async {
    final url = Uri.parse("${BaseProvider.baseUrl}User");
    final response = await http.get(url, headers: createHeaders());

    if (response.statusCode == 200) {
      final json = jsonDecode(response.body);
      List list = json["resultList"];
      return list.map((e) => User.fromJson(e)).toList();
    }

    throw Exception("Failed to load users");
  }

  Future<User> updateUser(int id, Map<String, dynamic> request) async {
    final url = Uri.parse("${BaseProvider.baseUrl}User/$id");

    final response = await http.put(
      url,
      headers: createHeaders(),
      body: jsonEncode(request),
    );

    if (response.statusCode == 200) {
      return User.fromJson(jsonDecode(response.body));
    }

    throw Exception("Failed to update user");
  }

  Future<bool> deleteUser(int id) async {
    final url = Uri.parse("${BaseProvider.baseUrl}User/$id");

    final response = await http.delete(
      url,
      headers: createHeaders(),
    );

    return response.statusCode == 200;
  }

  Future<bool> changeRole(int userId, int newRoleId) async {
  final url = Uri.parse("${BaseProvider.baseUrl}User/change-role/$userId");

  final response = await http.put(
    url,
    headers: createHeaders(),
    body: jsonEncode({"roleId": newRoleId}),
  );

  print("CHANGE ROLE STATUS: ${response.statusCode}");
  print("BODY: ${response.body}");

  return response.statusCode == 200;
}

Future<User?> login(String email, String password) async {
  final url = Uri.parse("${BaseProvider.baseUrl}User/login");

  final response = await http.post(
    url,
    headers: {"Content-Type": "application/json"},
    body: jsonEncode({
      "email": email,
      "password": password,
    }),
  );
  
  print("LOGIN STATUS: ${response.statusCode}");
  print("LOGIN BODY: ${response.body}");

  if (response.statusCode == 200) {
    return User.fromJson(jsonDecode(response.body));
  }

  return null;
}

Future<bool> assignPosition(int userId, int positionId, int airportId) async {
  final url = Uri.parse("${BaseProvider.baseUrl}Employee/assign");

  final response = await http.post(
    url,
    headers: createHeaders(),
    body: jsonEncode({
      "userId": userId,
      "positionId": positionId,
      "airportId": airportId,
    }),
  );

  return response.statusCode == 200;
}

Future<bool> updatePosition(int userId, int positionId) async {
  final url = Uri.parse("${BaseProvider.baseUrl}Employee/change-position/$userId");

  final response = await http.put(
    url,
    headers: createHeaders(),
    body: jsonEncode({
      "userId": userId,
      "positionId": positionId,
    }),
  );

  print("UPDATE POSITION STATUS: ${response.statusCode}");
  print("UPDATE BODY: ${response.body}");

  return response.statusCode == 200;
}

Future<List<Flight>> getForUser(int userId) async {
    final url = Uri.parse("${BaseProvider.baseUrl}User/recommender/$userId");

    final response = await http.get(url, headers: createHeaders());

    if (response.statusCode == 200) {
      final list = jsonDecode(response.body) as List;
      return list.map((e) => Flight.fromJson(e)).toList();
    } else {
      throw Exception("Failed to load recommendations");
    }
  }

  Future<bool> updateEmployeeAirport(int userId, int newAirportId) async {
    final url =
        Uri.parse("${BaseProvider.baseUrl}Employee/change-airport/$userId");

    final response = await http.put(
      url,
      headers: createHeaders(),
      body: jsonEncode({
        "userId": userId,
        "airportId": newAirportId,
      }),
    );

    print("UPDATE AIRPORT STATUS: ${response.statusCode}");
    print("BODY: ${response.body}");

    return response.statusCode == 200;
  }


}

