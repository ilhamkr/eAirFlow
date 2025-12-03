import 'package:eairflow_mobile/models/flight_review.dart';
import 'package:eairflow_mobile/providers/base_provider.dart';

class FlightReviewProvider extends BaseProvider<FlightReview> {
  FlightReviewProvider() : super("FlightReview");

  @override
  FlightReview fromJson(data) {
    return FlightReview.fromJson(data);
  }

  Future leaveReview(int userId, int flightId, int rating, String comment) async {
    return await insert({
      "userId": userId,
      "flightId": flightId,
      "rating": rating,
      "comment": comment
    });
  }

  Future<List<FlightReview>> getByUser(int userId) async {
    final result = await get(filter: {"userId": userId});
    return result.result.cast<FlightReview>();
  }

  Future<List<FlightReview>> getByFlight(int flightId) async {
    final result = await get(filter: {"flightId": flightId});
    return result.result.cast<FlightReview>();
  }
}
