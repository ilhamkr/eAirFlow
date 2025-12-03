import 'package:eairflow_mobile/models/seatclass.dart';
import 'package:eairflow_mobile/providers/base_provider.dart';

class SeatClassProvider extends BaseProvider<SeatClass> {
  SeatClassProvider() : super("SeatClass");

  @override
  SeatClass fromJson(data) => SeatClass.fromJson(data);
}
