import 'package:flutter/material.dart';
import 'package:eairflow_mobile/models/flight.dart';
import 'package:eairflow_mobile/providers/flight_review_provider.dart';

Future<void> showRateDialog(BuildContext context, int userId, Flight flight) {
  int rating = 0;
  final commentCtrl = TextEditingController();

  return showModalBottomSheet(
    context: context,
    isScrollControlled: true,
    backgroundColor: Colors.white,
    shape: const RoundedRectangleBorder(
      borderRadius: BorderRadius.vertical(top: Radius.circular(22)),
    ),
    builder: (context) {
      return Padding(
        padding: EdgeInsets.only(
          bottom: MediaQuery.of(context).viewInsets.bottom,
        ),
        child: StatefulBuilder(
          builder: (context, setState) {
            return Container(
              padding: const EdgeInsets.all(18),
              child: Column(
                mainAxisSize: MainAxisSize.min,
                children: [
                  Text(
                    "Rate your flight",
                    style: TextStyle(
                      fontSize: 20,
                      fontWeight: FontWeight.w700,
                      color: Colors.blue.shade700,
                    ),
                  ),

                  const SizedBox(height: 6),
                  Text(
                    "${flight.departureLocation} → ${flight.arrivalLocation}",
                    style: const TextStyle(
                      fontSize: 14,
                      color: Colors.grey,
                    ),
                  ),

                  const SizedBox(height: 18),

                  Row(
                    mainAxisAlignment: MainAxisAlignment.center,
                    children: List.generate(5, (i) {
                      return IconButton(
                        icon: Icon(
                          i < rating ? Icons.star : Icons.star_border,
                          color: Colors.amber,
                          size: 34,
                        ),
                        onPressed: () => setState(() => rating = i + 1),
                      );
                    }),
                  ),

                  const SizedBox(height: 12),

                  TextField(
                    controller: commentCtrl,
                    maxLines: 3,
                    decoration: InputDecoration(
                      hintText: "Leave a comment (optional)",
                      filled: true,
                      fillColor: Colors.grey.shade100,
                      border: OutlineInputBorder(
                        borderRadius: BorderRadius.circular(12),
                        borderSide: BorderSide.none,
                      ),
                    ),
                  ),

                  const SizedBox(height: 18),

                  Row(
                    children: [
                      Expanded(
                        child: OutlinedButton(
                          onPressed: () => Navigator.pop(context),
                          child: const Text("Cancel"),
                        ),
                      ),
                      const SizedBox(width: 10),
                      Expanded(
                        child: ElevatedButton(
                          onPressed: rating < 1
                              ? null
                              : () async {
                                  final p = FlightReviewProvider();
                                  await p.leaveReview(
                                    userId,
                                    flight.flightId!,
                                    rating,
                                    commentCtrl.text,
                                  );

                                  Navigator.pop(context);

                                  ScaffoldMessenger.of(context).showSnackBar(
                                    const SnackBar(
                                      content: Text("Thanks for your review!"),
                                    ),
                                  );
                                },
                          style: ElevatedButton.styleFrom(
                            backgroundColor: Colors.blue.shade700,
                          ),
                          child: const Text(
                            "Submit",
                            style: TextStyle(color: Colors.white),
                          ),
                        ),
                      ),
                    ],
                  ),

                  const SizedBox(height: 12),
                ],
              ),
            );
          },
        ),
      );
    },
  );
}

