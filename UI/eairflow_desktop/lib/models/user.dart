import 'package:eairflow_desktop/models/employee.dart';
import 'package:json_annotation/json_annotation.dart';

part 'user.g.dart';

@JsonSerializable()
class User {
  int? userId;
  String? name;
  String? surname;
  String? email;
  String? phoneNumber;
  String? profileImageUrl;
  int? roleId;
  int? userRoleId;
  Employee? employee;

  User({
  this.userId,
  this.name,
  this.surname,
  this.email,
  this.phoneNumber,
  this.profileImageUrl,
  this.roleId,
  this.userRoleId,
  this.employee,
});


  factory User.fromJson(Map<String, dynamic> json) => User(
  userId: json['userId'],
  name: json['name'],
  surname: json['surname'],
  email: json['email'],
  phoneNumber: json['phoneNumber'],
  profileImageUrl: json['profileImageUrl'],
  roleId: (json['userRoles'] != null && json['userRoles'].isNotEmpty)
      ? json['userRoles'][0]['roleId']
      : 1, 
  userRoleId: (json['userRoles'] != null && json['userRoles'].isNotEmpty)
    ? json['userRoles'][0]['userRoleId']
    : null,
  employee: json['employee'] != null 
        ? Employee.fromJson(json['employee'])
        : null,

);

}
