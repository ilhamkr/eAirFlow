class Airport {
  int? airportId;
  String? name;
  String? city;
  String? country;

  Airport({
    this.airportId,
    this.name,
    this.city,
    this.country,
  });

  factory Airport.fromJson(Map<String, dynamic> json) => Airport(
        airportId: json['airportId'] as int?,
        name: json['name'] as String?,
        city: json['city'] as String?,
        country: json['country'] as String?,
      );

  Map<String, dynamic> toJson() => {
        'airportId': airportId,
        'name': name,
        'city': city,
        'country': country,
      };
}
