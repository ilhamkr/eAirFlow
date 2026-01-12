class Airplane {
  int? airplaneId;
  String? model;
  int? totalSeats;
  int? airlineId;

  Airplane({
    this.airplaneId,
    this.model,
    this.totalSeats,
    this.airlineId,
  });

  factory Airplane.fromJson(Map<String, dynamic> json) => Airplane(
        airplaneId: json['airplaneId'] as int?,
        model: json['model'] as String?,
        totalSeats: json['totalSeats'] as int?,
        airlineId: json['airlineId'] as int?,
      );

  Map<String, dynamic> toJson() => {
        'airplaneId': airplaneId,
        'model': model,
        'totalSeats': totalSeats,
        'airlineId': airlineId,
      };
}