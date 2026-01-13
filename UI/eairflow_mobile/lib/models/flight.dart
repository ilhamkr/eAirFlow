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
  String? departureTimeZone;
  String? arrivalTimeZone;

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
    this.airport,
    this.departureTimeZone,
    this.arrivalTimeZone,
  });

  factory Flight.fromJson(Map<String, dynamic> json) => Flight(
        flightId: json['flightId'] as int?,
        departureLocation: json['departureLocation'] as String?,
        arrivalLocation: json['arrivalLocation'] as String?,
        departureTime: _parseUtcDateTime(json['departureTime']),
        arrivalTime: _parseUtcDateTime(json['arrivalTime']),
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

DateTime? _parseUtcDateTime(dynamic value) {
  if (value == null) return null;
  final parsed = DateTime.tryParse(value.toString());
  if (parsed == null) return null;
  if (parsed.isUtc) return parsed;
  return DateTime.utc(
    parsed.year,
    parsed.month,
    parsed.day,
    parsed.hour,
    parsed.minute,
    parsed.second,
    parsed.millisecond,
    parsed.microsecond,
  );
}
