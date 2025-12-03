import 'package:eairflow_mobile/models/airport.dart';

import 'position.dart';

class Employee {
  int? employeeId;
  int? userId;
  int? positionId;
  Position? position;
  Airport? airport;

  Employee();

  Employee.fromJson(Map<String, dynamic> json) {
    employeeId = json['employeeId'];
    userId = json['userId'];
    positionId = json['positionId'];
    position = json['position'] != null
        ? Position.fromJson(json['position'])
        : null;
    airport = json['airport'] != null
        ? Airport.fromJson(json['airport'])
        : null;
  }
}
