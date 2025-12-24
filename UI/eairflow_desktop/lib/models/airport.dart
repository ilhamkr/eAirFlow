class Airport {
  int? airportId;
  String? name;
  String? city;
  String? country;
  String? timeZoneId;

  Airport({
    this.airportId,
    this.name,
    this.city,
    this.country,
    this.timeZoneId,
  });

  factory Airport.fromJson(Map<String, dynamic> json) => Airport(
        airportId: json['airportId'] as int?,
        name: json['name'] as String?,
        city: json['city'] as String?,
        country: json['country'] as String?,
        timeZoneId: json['timeZoneId'] as String?,
      );

  Map<String, dynamic> toJson() => {
        'airportId': airportId,
        'name': name,
        'city': city,
        'country': country,
        'timeZoneId': timeZoneId,
      };
}
