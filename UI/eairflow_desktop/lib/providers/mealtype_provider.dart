import 'package:eairflow_desktop/models/mealtype.dart';
import 'package:eairflow_desktop/providers/base_provider.dart';

class MealTypeProvider extends BaseProvider<MealType> {
  MealTypeProvider() : super("MealType");

  @override
  MealType fromJson(data) => MealType.fromJson(data);
}
