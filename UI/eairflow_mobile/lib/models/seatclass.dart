class SeatClass {
  int? seatClassId;
  String? name;
  double? priceMultiplier;

  SeatClass({this.seatClassId, this.name, this.priceMultiplier});

  factory SeatClass.fromJson(Map<String, dynamic> json) {
    return SeatClass(
      seatClassId: json["seatClassId"],
      name: json["name"],
      priceMultiplier: (json["priceMultiplier"] ?? 0).toDouble(),
    );
  }
}
