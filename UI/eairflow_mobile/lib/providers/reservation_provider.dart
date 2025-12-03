import 'dart:convert';
import 'package:eairflow_mobile/models/reservation.dart';
import 'package:eairflow_mobile/providers/base_provider.dart';
import 'package:http/http.dart' as http;

class ReservationProvider extends BaseProvider<Reservation> {
  ReservationProvider() : super("Reservation");

  @override
  Reservation fromJson(data) {
    return Reservation.fromJson(data);
  }

  Future<List<Reservation>> getByUser(int userId) async {
    final url = Uri.parse("${BaseProvider.baseUrl}Reservation/user/$userId");

    final response = await http.get(
      url,
      headers: createHeaders(),
    );

    if (response.statusCode == 200) {
      List list = jsonDecode(response.body);
      return list.map((e) => Reservation.fromJson(e)).toList();
    } else {
      throw Exception("Failed loading reservations");
    }
  }

  Future<void> deleteReservation(int id) async {
  final url = Uri.parse("${BaseProvider.baseUrl}Reservation/$id");

  final response = await http.delete(url, headers: createHeaders());

  if (response.statusCode >= 400) {
    throw Exception("Failed to delete reservation");
  }
}


}
