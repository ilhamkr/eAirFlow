class Payment {
  int? paymentId;
  int? userId;
  double? amount;
  String? paymentMethod;
  DateTime? transactionDate;
  String? transactionReference;

  Payment({
    this.paymentId,
    this.userId,
    this.amount,
    this.paymentMethod,
    this.transactionDate,
    this.transactionReference,
  });

  factory Payment.fromJson(Map<String, dynamic> json) {
    return Payment(
      paymentId: json['paymentId'],
      userId: json['userId'],
      amount: json['amount'] != null 
          ? (json['amount'] as num).toDouble()
          : null,
      paymentMethod: json['paymentMethod'],
      transactionDate: json['transactionDate'] != null
          ? DateTime.parse(json['transactionDate'])
          : null,
      transactionReference: json['transactionReference'],
    );
  }
}
