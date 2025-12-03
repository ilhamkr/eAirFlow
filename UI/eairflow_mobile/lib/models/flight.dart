import 'package:eairflow_mobile/models/airlines.dart';

class Flight {
  int? flightId;
  String? departureLocation;
  String? arrivalLocation;
  DateTime? departureTime;
  DateTime? arrivalTime;
  int? airlineId;
  int? airplaneId;
  int? price;
  String? stateMachine;
  Airline? airline;

  Flight({
    this.flightId,
    this.departureLocation,
    this.arrivalLocation,
    this.departureTime,
    this.arrivalTime,
    this.airlineId,
    this.airplaneId,
    this.price,
    this.stateMachine,
    this.airline,
  });

  factory Flight.fromJson(Map<String, dynamic> json) => Flight(
        flightId: json['flightId'] as int?,
        departureLocation: json['departureLocation'] as String?,
        arrivalLocation: json['arrivalLocation'] as String?,
        departureTime: json['departureTime'] != null
            ? DateTime.tryParse(json['departureTime'])
            : null,
        arrivalTime: json['arrivalTime'] != null
            ? DateTime.tryParse(json['arrivalTime'])
            : null,
        airlineId: json['airlineId'] as int?,
        airplaneId: json['airplaneId'] as int?,
        price: json['price'] as int?,
        stateMachine: json['stateMachine'] as String?,
        airline: json['airline'] != null
          ? Airline.fromJson(json['airline'])
          : null,
      );
}
