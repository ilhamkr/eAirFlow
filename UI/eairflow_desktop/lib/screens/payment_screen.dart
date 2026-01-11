import 'dart:convert';
import 'package:flutter/material.dart';
import 'package:flutter_inappwebview/flutter_inappwebview.dart';
import 'package:http/http.dart' as http;
import 'package:eairflow_desktop/layouts/master_screen.dart';
import 'package:eairflow_desktop/screens/my_trips_screen.dart';

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
    backgroundColor: const Color(0xFFF5F7FA),
    body: Center(
      child: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        children: [
          const Icon(Icons.check_circle, size: 80, color: Colors.green),
          const SizedBox(height: 16),

          const Text(
            "Payment Successful!",
            style: TextStyle(
              fontSize: 26,
              fontWeight: FontWeight.bold,
            ),
          ),

          const SizedBox(height: 10),

          Text(
            "Your flight reservation is now confirmed.",
            style: TextStyle(
              fontSize: 16,
              color: Colors.grey.shade700,
            ),
          ),

          const SizedBox(height: 24),

          Container(
            padding: const EdgeInsets.all(16),
            decoration: BoxDecoration(
              color: Colors.white,
              borderRadius: BorderRadius.circular(20),
              boxShadow: [
                BoxShadow(
                  color: Colors.black.withOpacity(0.1),
                  blurRadius: 10,
                  offset: const Offset(0, 4),
                ),
              ],
            ),
            child: Image.memory(
              base64Decode(_qrCodeBase64!),
              width: 220,
              height: 220,
            ),
          ),

          const SizedBox(height: 30),

          ElevatedButton.icon(
            icon: const Icon(Icons.airplane_ticket),
            label: const Text("See Your Ticket"),
            style: ElevatedButton.styleFrom(
              backgroundColor: Colors.blue,
              padding: const EdgeInsets.symmetric(horizontal: 32, vertical: 14),
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(12),
              ),
            ),
            onPressed: () {
               Navigator.of(context).pushAndRemoveUntil(
                MaterialPageRoute(
                  builder: (_) => MasterScreen(1, const MyTripsScreen()),
                ),
                (_) => false,
              );
            },
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
