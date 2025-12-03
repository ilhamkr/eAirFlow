class NotificationModel {
  int? notificationId;
  int? userId;
  String? message;
  String? sentAt;
  bool? isSeen;

  NotificationModel({
    this.notificationId,
    this.userId,
    this.message,
    this.sentAt,
    this.isSeen,
  });

  factory NotificationModel.fromJson(Map<String, dynamic> json) {
    return NotificationModel(
      notificationId: json["notificationId"],
      userId: json["userId"],
      message: json["message"],
      sentAt: json["sentAt"],
      isSeen: json["isSeen"],
    );
  }
}
