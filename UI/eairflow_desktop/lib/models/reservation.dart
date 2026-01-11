import 'package:eairflow_desktop/models/airport.dart';
import 'package:eairflow_desktop/models/checkin.dart';
import 'package:eairflow_desktop/models/flight.dart';
import 'package:eairflow_desktop/models/mealtype.dart';
import 'package:eairflow_desktop/models/payment.dart';
import 'package:eairflow_desktop/models/seat.dart';

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

  String? dateOfBirth;
  String? address;
  String? city;
  String? country;
  String? passportNumber;
  String? citizenship;
  String? baggageInfo;


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
      ..dateOfBirth = json['dateOfBirth']
      ..address = json['address']
      ..city = json['city']
      ..country = json['country']
      ..passportNumber = json['passportNumber']
      ..citizenship = json['citizenship']
      ..baggageInfo = json['baggageInfo']
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
