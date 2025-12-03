import 'package:eairflow_mobile/models/airport.dart';
import 'package:json_annotation/json_annotation.dart';

part 'airlines.g.dart';

@JsonSerializable(explicitToJson: true)
class Airline {
  int? airlineId;
  String? name;
  String? country;
  String? slika;
  int? airportId;
  Airport? airport;

  Airline({
    this.airlineId,
    this.name,
    this.country,
    this.slika,
    this.airportId,
    this.airport,
  });

  factory Airline.fromJson(Map<String, dynamic> json) =>
      _$AirlineFromJson(json);

  Map<String, dynamic> toJson() => _$AirlineToJson(this);
}
