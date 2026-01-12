import 'dart:convert';

import 'package:eairflow_desktop/models/time_zone.dart';
import 'package:eairflow_desktop/providers/base_provider.dart';
import 'package:http/http.dart' as http;

class TimeZoneProvider extends BaseProvider<TimeZoneInfo> {
  TimeZoneProvider() : super("TimeZone");

  @override
  TimeZoneInfo fromJson(data) => TimeZoneInfo.fromJson(data);

  Future<List<TimeZoneInfo>> getAll() async {
    final url = Uri.parse("${BaseProvider.baseUrl}TimeZone");
    final response = await http.get(url, headers: createHeaders());

    if (isValidResponse(response)) {
      final data = jsonDecode(response.body) as List<dynamic>;
      return data.map((item) => TimeZoneInfo.fromJson(item)).toList();
    } else {
      throw Exception("Unknown error");
    }
  }
}