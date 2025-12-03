import 'package:eairflow_desktop/models/flight.dart';
import 'package:eairflow_desktop/providers/flight_review_provider.dart';
import 'package:flutter/material.dart';

void showRateDialog(BuildContext context, int userId, Flight flight) {
  int rating = 0;
  final commentCtrl = TextEditingController();

  showDialog(
    context: context,
    builder: (_) => AlertDialog(
      title: Text("Rate your flight"),
      content: Column(
        mainAxisSize: MainAxisSize.min,
        children: [
          const Text("How would you rate this flight?"),
          const SizedBox(height: 12),

          StatefulBuilder(
            builder: (context, setState) {
              return Row(
                mainAxisAlignment: MainAxisAlignment.center,
                children: List.generate(5, (index) {
                  return IconButton(
                    icon: Icon(
                      index < rating ? Icons.star : Icons.star_border,
                      color: Colors.amber,
                      size: 32,
                    ),
                    onPressed: () {
                      setState(() => rating = index + 1);
                    },
                  );
                }),
              );
            },
          ),

          TextField(
            controller: commentCtrl,
            decoration: const InputDecoration(
              labelText: "Leave a comment (optional)",
            ),
          ),
        ],
      ),
      actions: [
        TextButton(
          onPressed: () => Navigator.pop(context),
          child: const Text("Cancel"),
        ),
        ElevatedButton(
          onPressed: () async {
            if (rating < 1) return;

            final reviewProv = FlightReviewProvider();
            await reviewProv.leaveReview(
              userId,
              flight.flightId!,
              rating,
              commentCtrl.text,
            );

            Navigator.pop(context);

            ScaffoldMessenger.of(context).showSnackBar(
              const SnackBar(content: Text("Thanks for your review!")),
            );
          },
          child: const Text("Submit"),
        ),
      ],
    ),
  );
}
