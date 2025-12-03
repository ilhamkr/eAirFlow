class MealType {
  int? mealTypeId;
  String? name;
  double? price;

  MealType({this.mealTypeId, this.name, this.price});

  factory MealType.fromJson(Map<String, dynamic> json) {
    return MealType(
      mealTypeId: json["mealTypeId"],
      name: json["name"],
      price: (json["price"] ?? 0).toDouble(),
    );
  }
}
