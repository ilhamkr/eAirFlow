// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'airlines.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Airline _$AirlineFromJson(Map<String, dynamic> json) => Airline(
  airlineId: (json['airlineId'] as num?)?.toInt(),
  name: json['name'] as String?,
  country: json['country'] as String?,
  slika: json['slika'] as String?,
  airportId: json['airportId'] as int?,
  airport: json['airport'] == null 
       ? null 
       : Airport.fromJson(json['airport']),
);


Map<String, dynamic> _$AirlineToJson(Airline instance) => <String, dynamic>{
  'airlineId': instance.airlineId,
  'name': instance.name,
  'country': instance.country,
  'slika': instance.slika,
};
