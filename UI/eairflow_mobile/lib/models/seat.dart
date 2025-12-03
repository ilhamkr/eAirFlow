class Seat {
  int? seatId;
  int? airplaneId;
  String? seatNumber;
  int? seatClassId;

  Seat({this.seatId, this.airplaneId, this.seatNumber, this.seatClassId});

  factory Seat.fromJson(Map<String, dynamic> json) => Seat(
    seatId: json["seatId"],
    airplaneId: json["airplaneId"],
    seatNumber: json["seatNumber"],
    seatClassId: json["seatClassId"],
  );
}
