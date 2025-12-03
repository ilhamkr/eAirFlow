import 'package:eairflow_mobile/models/flight.dart';

class FlightReview {
  int? reviewId;
  int? userId;
  int? flightId;
  int? rating;
  String? comment;
  DateTime? submittedAt;
  Flight? flight; 

  FlightReview({
    this.reviewId,
    this.userId,
    this.flightId,
    this.rating,
    this.comment,
    this.submittedAt,
    this.flight
  });

  factory FlightReview.fromJson(Map<String, dynamic> json) => FlightReview(
        reviewId: json['reviewId'],
        userId: json['userId'],
        flightId: json['flightId'],
        rating: json['rating'],
        comment: json['comment'],
        flight: json['flight'] != null ? Flight.fromJson(json['flight']) : null,
        submittedAt: json['submittedAt'] != null
            ? DateTime.parse(json['submittedAt'])
            : null,
      );
}
