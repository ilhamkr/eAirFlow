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
  bool _webLoading = true;

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
    setState(() => _loading = true);

    final url = Uri.parse("http://10.0.2.2:5239/Payment/create-order");

    try {
      final response = await http.post(
        url,
        headers: {"Content-Type": "application/json"},
        body: jsonEncode({
          "amount": widget.amount,
          "returnUrl": returnUrl,
          "cancelUrl": cancelUrl
        }),
      );

      setState(() => _loading = false);

      if (response.statusCode != 200) {
        ScaffoldMessenger.of(context)
            .showSnackBar(const SnackBar(content: Text("Failed to create order")));
        return;
      }

      final data = jsonDecode(response.body);

      setState(() {
        _approvalUrl = data["approvalUrl"];
        _paypalOrderId = data["orderId"];
      });
    } catch (e) {
      setState(() => _loading = false);
      ScaffoldMessenger.of(context)
          .showSnackBar(SnackBar(content: Text("Error: $e")));
    }
  }

  Future<void> _capturePayment() async {
    if (_paypalOrderId == null) return;

    final url = Uri.parse("http://10.0.2.2:5239/Payment/capture-order");

    try {
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
    } catch (e) {
      ScaffoldMessenger.of(context)
          .showSnackBar(SnackBar(content: Text("Error: $e")));
    }
  }

  Widget _buildSuccessView() {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Payment Success"),
        centerTitle: true,
      ),
      body: Center(
        child: SingleChildScrollView(
          child: Column(
            children: [
              const SizedBox(height: 20),

              const Text(
                "Payment Successful!",
                style: TextStyle(fontSize: 26, fontWeight: FontWeight.bold),
              ),

              const SizedBox(height: 20),

              Container(
                padding: const EdgeInsets.all(20),
                margin: const EdgeInsets.symmetric(horizontal: 20),
                decoration: BoxDecoration(
                  color: Colors.white,
                  borderRadius: BorderRadius.circular(16),
                  boxShadow: [
                    BoxShadow(
                      color: Colors.black.withOpacity(0.06),
                      blurRadius: 10,
                      offset: const Offset(0, 3),
                    )
                  ],
                ),
                child: Image.memory(
                  base64Decode(_qrCodeBase64!),
                  width: 240,
                  height: 240,
                  fit: BoxFit.contain,
                ),
              ),

              const SizedBox(height: 30),

              ElevatedButton(
                style: ElevatedButton.styleFrom(
                  padding: const EdgeInsets.symmetric(horizontal: 26, vertical: 12),
                  backgroundColor: Colors.green.shade600,
                ),
                onPressed: () {  
                  Navigator.pop(context, true); 
                },
                child: const Text(
                  "Done",
                  style: TextStyle(fontSize: 16, color: Colors.white),
                ),
              )
            ],
          ),
        ),
      ),
    );
  }

  Widget _buildWebView() {
    return Scaffold(
      appBar: AppBar(
        title: const Text("Pay with PayPal"),
        centerTitle: true,
      ),
      body: Stack(
        children: [
          InAppWebView(
            initialUrlRequest: URLRequest(url: WebUri(_approvalUrl!)),
            onWebViewCreated: (ctrl) => _webview = ctrl,
            onLoadStart: (_, __) => setState(() => _webLoading = true),
            onLoadStop: (controller, url) async {
              setState(() => _webLoading = false);

              final urlStr = url.toString();

              if (urlStr.contains("success")) {
                await _capturePayment();
              } else if (urlStr.contains("cancel")) {
                Navigator.pop(context);
              }
            },
          ),

          if (_webLoading)
            const Center(child: CircularProgressIndicator()),
        ],
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    if (_qrCodeBase64 != null) {
      return _buildSuccessView();
    }

    if (_approvalUrl != null) {
      return _buildWebView();
    }

    return Scaffold(
      appBar: AppBar(
        title: const Text("Processing Payment"),
        centerTitle: true,
      ),
      body: Center(
        child: _loading
            ? Column(
                mainAxisAlignment: MainAxisAlignment.center,
                children: const [
                  CircularProgressIndicator(),
                  SizedBox(height: 12),
                  Text("Creating PayPal order...")
                ],
              )
            : const Text("Preparing payment..."),
      ),
    );
  }
}