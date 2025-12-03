import 'package:eairflow_desktop/models/reservation.dart';
import 'package:eairflow_desktop/models/user.dart';

class CheckIn {
  int? checkinId;
  int? reservationId;
  int? seatId;
  String? checkinTime;
  String? stateMachine;

  Reservation? reservation;
  User? user;

  CheckIn({
    this.checkinId,
    this.reservationId,
    this.seatId,
    this.checkinTime,
    this.stateMachine,
    this.reservation,
    this.user,
  });

  factory CheckIn.fromJson(Map<String, dynamic> json) {
    return CheckIn(
      checkinId: json['checkinId'],
      reservationId: json['reservationId'],
      seatId: json['seatId'],
      checkinTime: json['checkinTime'],
      stateMachine: json['stateMachine'],
      reservation: json['reservation'] != null
          ? Reservation.fromJson(json['reservation'])
          : null,
      user: json['user'] != null
          ? User.fromJson(json['user'])
          : null,
    );
  }
}
