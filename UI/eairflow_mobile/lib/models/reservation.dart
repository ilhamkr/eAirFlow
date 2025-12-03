import 'package:eairflow_mobile/models/airport.dart';
import 'package:eairflow_mobile/models/checkin.dart';
import 'package:eairflow_mobile/models/flight.dart';
import 'package:eairflow_mobile/models/mealtype.dart';
import 'package:eairflow_mobile/models/payment.dart';
import 'package:eairflow_mobile/models/seat.dart';

class Reservation {
  int? reservationId;
  int? userId;
  int? flightId;
  Flight? flight;

  String? reservationDate;
  int? paymentId;

  String? stateMachine;
  Seat? seat;
  String? get seatNumber => seat?.seatNumber;
  int? seatClassId;
  int? adults;
  int? children;
  MealType? mealType;
  String? luggageOption;
  String? qrCodeBase64;

  Airport? airport;
  CheckIn? checkIn;
  Payment? payment;


  Reservation();

  factory Reservation.fromJson(Map<String, dynamic> json) {
    return Reservation()
      ..reservationId = json['reservationId']
      ..userId = json['userId']
      ..flightId = json['flightId']
      ..reservationDate = json['reservationDate']
      ..paymentId = json['paymentId']
      ..stateMachine = json['stateMachine']
      ..seat = json['seat'] != null ? Seat.fromJson(json['seat']) : null
      ..seatClassId = json['seatClassId']
      ..adults = json['adults']
      ..children = json['children']
      ..mealType = json['mealType'] != null
          ? MealType.fromJson(json['mealType'])
          : null
      ..luggageOption = json['luggageOption']
      ..qrCodeBase64 = json['qrCodeBase64']
      ..flight =
          json['flight'] != null ? Flight.fromJson(json['flight']) : null
      ..airport = json['airport'] != null ? Airport.fromJson(json['airport']) : null
      ..checkIn = json['checkIn'] != null 
     ? CheckIn.fromJson(json['checkIn']) 
     : null
     ..payment = json['payment'] != null
    ? Payment.fromJson(json['payment'])
    : null;


          
  }
}
