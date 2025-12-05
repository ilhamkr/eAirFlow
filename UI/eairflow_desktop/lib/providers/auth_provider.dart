import 'package:flutter/material.dart';

class AuthProvider {
  static int? userId;
  static String? email;
  static String? name;
  static String? surname;
  static String? password;
  static String? profileImageUrl;
  static int? roleId;
  static int? positionId;
  static int? employeeId;

  static final ValueNotifier<int> notifier = ValueNotifier(0);

  static void notify() {
    notifier.value++;
  }


  static String get fullName {
    if ((name ?? "").isEmpty && (surname ?? "").isEmpty) return "User";
    return "${name ?? ""} ${surname ?? ""}".trim();
  }

    static void clear() {
    userId = null;
    name = null;
    surname = null;
    email = null;
    password = null;
    roleId = null;
    profileImageUrl = null;
    positionId=null;
    employeeId = null;
  }

}