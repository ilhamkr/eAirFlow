class TimeZoneInfo {
  String? timeZoneId;
  String? displayName;

  TimeZoneInfo({
    this.timeZoneId,
    this.displayName,
  });

  factory TimeZoneInfo.fromJson(Map<String, dynamic> json) => TimeZoneInfo(
        timeZoneId: json['timeZoneId'] as String?,
        displayName: json['displayName'] as String?,
      );
}