import 'dart:convert';
import 'package:eairflow_desktop/models/payment.dart';
import 'package:eairflow_desktop/providers/base_provider.dart';
import 'package:http/http.dart' as http;

class PaymentProvider extends BaseProvider<Payment> {
  PaymentProvider() : super("Payment");

  @override
  Payment fromJson(data) {
    return Payment.fromJson(data);
  }

  Future<Payment?> getPayment(int id) async {
    final url = Uri.parse("${BaseProvider.baseUrl}Payment/$id");

    final response = await http.get(
      url,
      headers: createHeaders(),
    );

    if (response.statusCode == 200) {
      return Payment.fromJson(jsonDecode(response.body));
    }

    return null;
  }
}
