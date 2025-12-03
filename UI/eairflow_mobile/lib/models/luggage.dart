import 'package:eairflow_mobile/models/airport.dart';
import 'package:eairflow_mobile/models/user.dart';

class Luggage {
  int? luggageId;
  String? description;
  String? status;
  int? airportId;
  int? userId;
  Airport? airport;
  User? user;
  String? stateMachine;
  String? imageUrl;

  Luggage({
    this.luggageId,
    this.description,
    this.status,
    this.airportId,
    this.userId,
    this.airport,
    this.user,
    this.stateMachine,
    this.imageUrl,
  });

  factory Luggage.fromJson(Map<String, dynamic> json) => Luggage(
        luggageId: json['luggageId'],
        description: json['description'],
        status: json['status'],
        airportId: json['airportId'],
        userId: json['userId'],
        airport: json['airport'] != null
            ? Airport.fromJson(json['airport'])
            : null,
        user: json['user'] != null
            ? User.fromJson(json['user'])
            : null,
        stateMachine: json['stateMachine'],
        imageUrl: json['imageUrl'] as String?,
      );
}
