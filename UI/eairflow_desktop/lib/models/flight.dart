import 'package:eairflow_desktop/models/airlines.dart';
import 'package:eairflow_desktop/models/airport.dart';

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
  Airport? airport;
  String? departureTimeZone;
  String? arrivalTimeZone;

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
    this.airport,
    this.departureTimeZone,
    this.arrivalTimeZone,
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
        airport: json['airport'] != null
            ? Airport.fromJson(json['airport'])
            : null,
        departureTimeZone: json['departureTimeZone'] as String?,
        arrivalTimeZone: json['arrivalTimeZone'] as String?,
      );
}
