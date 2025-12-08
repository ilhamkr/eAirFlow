import 'package:eairflow_mobile/models/airlines.dart';
import 'package:eairflow_mobile/models/airport.dart';

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
  int? airportId;
  Airport? airport;


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
    this.airportId,
    this.airport,
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
        airportId: json['airportId'] as int?,
        airport: json['airport'] != null
            ? Airport.fromJson(json['airport'])
            : null,
      );
}
