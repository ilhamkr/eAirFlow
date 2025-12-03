import 'dart:convert';

import 'package:eairflow_desktop/models/seat.dart';
import 'package:eairflow_desktop/providers/base_provider.dart';
import 'package:http/http.dart' as http;

class SeatProvider extends BaseProvider<Seat> {
  SeatProvider() : super("Seat");

  @override
  Seat fromJson(data) => Seat.fromJson(data);

  Future<List<Seat>> getByAirplane(int airplaneId) async {
    final url = Uri.parse("${BaseProvider.baseUrl}Seat/byAirplane/$airplaneId");
    final response = await http.get(url, headers: createHeaders());

    List list = jsonDecode(response.body);
    return list.map((e) => Seat.fromJson(e)).toList();
  }
}
