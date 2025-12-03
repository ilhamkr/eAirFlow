// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'user.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

User _$UserFromJson(Map<String, dynamic> json) => User(
  userId: (json['userId'] as num?)?.toInt(),
  name: json['name'] as String?,
  surname: json['surname'] as String?,
  email: json['email'] as String?,
  phoneNumber: json['phoneNumber'] as String?,
  profileImageUrl: json['profileImageUrl'] as String?,
);

Map<String, dynamic> _$UserToJson(User instance) => <String, dynamic>{
  'userId': instance.userId,
  'name': instance.name,
  'surname': instance.surname,
  'email': instance.email,
  'phoneNumber': instance.phoneNumber,
  'profileImageUrl': instance.profileImageUrl,
};
