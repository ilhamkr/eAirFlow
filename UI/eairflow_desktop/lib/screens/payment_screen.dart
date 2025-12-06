import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:flutter_inappwebview/flutter_inappwebview.dart';
import 'package:http/http.dart' as http;

class PaymentScreen extends StatefulWidget {
  final int reservationId;
  final int userId;
  final int amount;

  const PaymentScreen({
    super.key,
    required this.reservationId,
    required this.userId,
    required this.amount,
  });

  @override
  State<PaymentScreen> createState() => _PaymentScreenState();
}

class _PaymentScreenState extends State<PaymentScreen> {
  bool _loading = false;
  String? _approvalUrl;
  String? _paypalOrderId;
  String? _qrCodeBase64;

  InAppWebViewController? _webview;

  final String returnUrl = "https://www.sandbox.paypal.com/checkoutnow/success";
  final String cancelUrl = "https://www.sandbox.paypal.com/checkoutnow/cancel";

   @override
  void initState() {
    super.initState();
    _startPayment();
  }

  Future<void> _startPayment() async {
  print("=== STARTING PAYPAL PAYMENT ===");
  print("Sending request to backend...");
  print("Amount: ${widget.amount}");
  print("Return URL: $returnUrl");
  print("Cancel URL: $cancelUrl");

  setState(() => _loading = true);

  final url = Uri.parse("http://localhost:5239/Payment/create-order");

  final response = await http.post(
    url,
    headers: {"Content-Type": "application/json"},
    body: jsonEncode({
      "amount": widget.amount,
      "returnUrl": returnUrl,
      "cancelUrl": cancelUrl
    }),
  );

  print("Create Order Status: ${response.statusCode}");
  print("Create Order Body: ${response.body}");

  setState(() => _loading = false);

  if (response.statusCode != 200) {
    ScaffoldMessenger.of(context).showSnackBar(
      const SnackBar(content: Text("Failed to create order")),
    );
    return;
  }

  final data = jsonDecode(response.body);

  setState(() {
    _approvalUrl = data["approvalUrl"];
    _paypalOrderId = data["orderId"];
  });

  print("Approval URL = $_approvalUrl");
  print("PayPal Order ID = $_paypalOrderId");
}

  Future<void> _capturePayment() async {
    print("=== CAPTURING PAYMENT ===");
    print("Order ID: $_paypalOrderId");
    print("Reservation ID: ${widget.reservationId}");
    if (_paypalOrderId == null) return;

    final url = Uri.parse("http://localhost:5239/Payment/capture-order");

    final response = await http.post(
      url,
      headers: {"Content-Type": "application/json"},
      body: jsonEncode({
        "orderId": _paypalOrderId,
        "reservationId": widget.reservationId,
        "userId": widget.userId,
        "amount": widget.amount
      }),
    );

    print("Capture Status: ${response.statusCode}");
    print("Capture Body: ${response.body}");

    if (response.statusCode != 200) {
      ScaffoldMessenger.of(context)
          .showSnackBar(const SnackBar(content: Text("Capture failed")));
      return;
    }

    final data = jsonDecode(response.body);

    if (mounted) {
  setState(() {
    _qrCodeBase64 = data["qrCode"];
    _approvalUrl = null;
  });
}

  }

  @override
Widget build(BuildContext context) {
  if (_qrCodeBase64 != null) {
    return Scaffold(
      appBar: AppBar(title: const Text("Payment Success")),
      body: Center(
        child: Column(
          children: [
            const SizedBox(height: 24),
            const Text("Payment Successful!",
                style: TextStyle(fontSize: 24, fontWeight: FontWeight.bold)),
            const SizedBox(height: 24),
            Container(
              padding: const EdgeInsets.all(20),
              decoration: BoxDecoration(
                color: Colors.white,
                borderRadius: BorderRadius.circular(16),
              ),
              child: Image.memory(
                base64Decode(_qrCodeBase64!),
                width: 220,
                height: 220,
              ),
            ),
          ],
        ),
      ),
    );
  }


  if (_approvalUrl != null) {
    return Scaffold(
      appBar: AppBar(title: const Text("Complete Payment")),
      body: InAppWebView(
        initialUrlRequest: URLRequest(url: WebUri(_approvalUrl!)),
        onLoadStop: (controller, url) async {
          final urlStr = url.toString();
          if (urlStr.contains("success")) {
            await _capturePayment();
          } else if (urlStr.contains("cancel")) {
            Navigator.pop(context);
          }
        },
      ),
    );
  }

  return Scaffold(
    body: Center(child: CircularProgressIndicator()),
  );
}

}
