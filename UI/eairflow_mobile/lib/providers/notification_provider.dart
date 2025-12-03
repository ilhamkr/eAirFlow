import 'dart:convert';
import 'package:eairflow_mobile/models/notification.dart';
import 'package:eairflow_mobile/providers/base_provider.dart';
import 'package:http/http.dart' as http;

class NotificationProvider extends BaseProvider<NotificationModel> {
  NotificationProvider() : super("Notification");

  @override
  NotificationModel fromJson(data) => NotificationModel.fromJson(data);

  Future<List<NotificationModel>> getUnseen(int userId) async {
    final url = Uri.parse("${BaseProvider.baseUrl}Notification/unseen/$userId");
    final response = await http.get(url, headers: createHeaders());
    final data = jsonDecode(response.body);
    List list = data["resultList"];
    return list.map((e) => NotificationModel.fromJson(e)).toList();
  }

  Future<bool> markSeen(int id) async {
    final url = Uri.parse("${BaseProvider.baseUrl}Notification/seen/$id");
    print("PUT -> $url");
    final response = await http.put(url, headers: createHeaders());
    print("Status: ${response.statusCode}");
    print("Body: ${response.body}");
    return response.statusCode == 200;
  }

  Future<List<NotificationModel>> getAll() async {
    final url = Uri.parse("${BaseProvider.baseUrl}Notification");
    final response = await http.get(url, headers: createHeaders());

    if (response.statusCode == 200) {
      final data = jsonDecode(response.body);
      List list = data["resultList"];
      return list.map((e) => NotificationModel.fromJson(e)).toList();
    }

    throw Exception("Failed loading notifications");
  }
  
}
