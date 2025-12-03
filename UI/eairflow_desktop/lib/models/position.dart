class Position {
  int? positionId;
  String? name;
  String? description;

  Position();

  Position.fromJson(Map<String, dynamic> json) {
    positionId = json['positionId'];
    name = json['name'];
    description = json['description'];
  }

  Map<String, dynamic> toJson() => {
        "positionId": positionId,
        "name": name,
        "description": description,
      };
}
