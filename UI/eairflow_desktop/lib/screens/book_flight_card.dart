import 'package:eairflow_desktop/models/airport.dart';
import 'package:eairflow_desktop/models/mealtype.dart';
import 'package:eairflow_desktop/models/seatclass.dart';
import 'package:eairflow_desktop/providers/airport_provider.dart';
import 'package:eairflow_desktop/providers/auth_provider.dart';
import 'package:eairflow_desktop/models/airlines.dart';
import 'package:eairflow_desktop/models/flight.dart';
import 'package:eairflow_desktop/providers/airlines_provider.dart';
import 'package:eairflow_desktop/providers/flight_provider.dart';
import 'package:eairflow_desktop/providers/mealtype_provider.dart';
import 'package:eairflow_desktop/providers/reservation_provider.dart';
import 'package:eairflow_desktop/providers/seatclass_provider.dart';
import 'package:eairflow_desktop/providers/user_provider.dart';
import 'package:eairflow_desktop/screens/payment_screen.dart';
import 'package:flutter/material.dart';
import 'package:eairflow_desktop/utils/timezone_helper.dart';

String _departureTimeZone(Flight flight) {
  return flight.airport?.timeZoneId ??
      flight.airline?.airport?.timeZoneId ??
      'UTC';
}

String _arrivalTimeZone(Flight flight) {
  return flight.airline?.airport?.timeZoneId ??
      flight.airport?.timeZoneId ??
      'UTC';
}

String _formatFlightDateTime(Flight flight, DateTime? dateTime,
    {bool isArrival = false}) {
  return formatDateInTimeZone(
    dateTime,
    isArrival ? _arrivalTimeZone(flight) : _departureTimeZone(flight),
  );
}

Duration? _calculateFlightDuration(Flight flight) {
  return calculateDurationWithTimeZones(
    flight.departureTime,
    _departureTimeZone(flight),
    flight.arrivalTime,
    _arrivalTimeZone(flight),
  );
}

class BookFlightCard extends StatefulWidget {
  final VoidCallback onFlightBooked;
  const BookFlightCard({super.key, required this.onFlightBooked});

  @override
  State<BookFlightCard> createState() => _BookFlightCardState();
}

class _BookFlightCardState extends State<BookFlightCard> {
  final _fromCtrl = TextEditingController();
  final _toCtrl = TextEditingController();
  DateTime? selectedDate;

  int? selectedAirportId;
  List<Airport> airports = [];
  bool isLoadingAirports = true;

  int? selectedAirlineId;
  List<Airline> airlines = [];
  bool isLoadingAirlines = true;

  List<String> fromLocations = [];
  List<String> toLocations = [];

  String? selectedFrom;
  String? selectedTo;

  bool isSearching = false;
  List<Flight> flights = [];

  List<Flight> recommendedFlights = [];
  bool loadingRecommendations = true;

  List<dynamic> myReservations = [];


  @override
  void initState() {
    super.initState();
    _loadAirports();
    _loadRecommendations();
    _loadMyReservations();
  }

  Future<void> _loadMyReservations() async {
  final userId = AuthProvider.userId;
  if (userId == null) return;

  final provider = ReservationProvider();
  final res = await provider.getByUser(userId);

  setState(() {
    myReservations = res;
  });
}


  Future<void> _loadRecommendations() async {
  try {
    final userId = AuthProvider.userId;
    if (userId != null) {
      final userProvider = UserProvider();
      final rec = await userProvider.getForUser(userId);
      setState(() {
        recommendedFlights = rec;
      });
    }
  } catch (e) {
    print("RECOMMENDER ERROR: $e");
  }

  setState(() => loadingRecommendations = false);
}

  Future<void> _loadAirports() async {
    try {
      final p = AirportProvider();
      final res = await p.getAll();
      setState(() {
        airports = res;
        isLoadingAirports = false;
      });
    } catch (_) {
      setState(() => isLoadingAirports = false);
    }
  }

  Future<void> _loadAirlinesByAirport(int airportId) async {
    setState(() {
      airlines = [];
      isLoadingAirlines = true;
      selectedAirlineId = null;
      fromLocations = [];
      toLocations = [];
      selectedFrom = null;
      selectedTo = null;
      selectedDate = null;
    });

    try {
      final p = AirlinesProvider();
      final res = await p.getByAirport(airportId);
      setState(() {
        airlines = res;
        isLoadingAirlines = false;
      });
    } catch (_) {
      setState(() => isLoadingAirlines = false);
    }
  }

  Future<void> _pickDate() async {
  if (selectedAirlineId == null || selectedFrom == null || selectedTo == null) {
    ScaffoldMessenger.of(context).showSnackBar(
      const SnackBar(content: Text("Please select airline, from and to first")),
    );
    return;
  }

  final fp = FlightProvider();

  final flightsData = await fp.get(filter: {
    "airlineId": selectedAirlineId,
    "departureLocation": selectedFrom,
    "arrivalLocation": selectedTo,
  });

  final now = DateTime.now();

  final allowedDates = flightsData.result
      .map((f) => f.departureTime!)
      .where((d) => d.isAfter(now))
      .map((d) => DateTime(d.year, d.month, d.day))
      .toSet()
      .toList()
    ..sort();

  if (allowedDates.isEmpty) {
    ScaffoldMessenger.of(context).showSnackBar(
      const SnackBar(content: Text("No available dates for this route")),
    );
    return;
  }

  final picked = await showDatePicker(
    context: context,
    firstDate: allowedDates.first,
    lastDate: allowedDates.last,
    selectableDayPredicate: (day) {
      return allowedDates.contains(
        DateTime(day.year, day.month, day.day),
      );
    },
    initialDate: allowedDates.first,
  );

  if (picked != null) {
    setState(() => selectedDate = picked);
  }
}



  Future<void> _searchFlights() async {
    if (selectedAirportId == null ||
        selectedAirlineId == null ||
        _fromCtrl.text.trim().isEmpty ||
        _toCtrl.text.trim().isEmpty ||
        selectedDate == null) {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(content: Text("Please fill all fields")),
      );
      return;
    }

    setState(() {
      isSearching = true;
      flights = [];
    });

    try {
      final fp = FlightProvider();
      final dateStr =
          "${selectedDate!.year}-${selectedDate!.month}-${selectedDate!.day}";

      final res = await fp.get(filter: {
        "airlineId": selectedAirlineId,
        "departureLocation": _fromCtrl.text,
        "arrivalLocation": _toCtrl.text,
        "date": dateStr,
      });

      setState(() {
        flights = res.result;
      });
    } finally {
      setState(() => isSearching = false);
    }
  }

  InputDecoration _inputDecoration(String label, IconData icon) {
    return InputDecoration(
      labelText: label,
      prefixIcon: Icon(icon),
      filled: true,
      fillColor: const Color(0xFFF5F7FB),
      border: OutlineInputBorder(
        borderRadius: BorderRadius.circular(12),
        borderSide: BorderSide.none,
      ),
    );
  }

  @override
  Widget build(BuildContext context) {
    final cs = Theme.of(context).colorScheme;

    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [

      if (!loadingRecommendations && recommendedFlights.isNotEmpty)
        Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            const Text(
              "Recommended for you",
              style: TextStyle(
                fontSize: 22,
                fontWeight: FontWeight.bold,
              ),
            ),
            const SizedBox(height: 12),
      
            SizedBox(
              height: 190,
              child: Align(
                alignment: recommendedFlights.length == 1
                    ? Alignment.centerLeft
                    : Alignment.center,

                child: ListView.separated(
                  scrollDirection: Axis.horizontal,

                  padding: EdgeInsets.symmetric(
                    horizontal: recommendedFlights.length == 1 ? 0 : 60,
                  ),

                  itemCount: recommendedFlights.length,
                  separatorBuilder: (_, __) => const SizedBox(width: 12),

                  itemBuilder: (_, i) {
                    final f = recommendedFlights[i];
                    final departureText = _formatFlightDateTime(f, f.departureTime);

                    return Container(
                      width: 300,
                      padding: const EdgeInsets.all(14),
                      decoration: BoxDecoration(
                        borderRadius: BorderRadius.circular(16),
                        border: Border.all(color: Colors.grey.shade300),
                        color: Colors.white,
                        boxShadow: [
                          BoxShadow(
                            color: Colors.black.withOpacity(0.05),
                            blurRadius: 6,
                            offset: const Offset(0, 3),
                          )
                        ],
                      ),

                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Row(
                            children: [
                              const Icon(Icons.flight_takeoff, color: Colors.blue),
                              const SizedBox(width: 6),
                              Expanded(
                                child: Text(
                                  "${f.departureLocation} → ${f.arrivalLocation}",
                                  style: const TextStyle(
                                    fontSize: 16,
                                    fontWeight: FontWeight.bold,
                                  ),
                                  overflow: TextOverflow.ellipsis,
                                ),
                              ),
                            ],
                          ),

                          const SizedBox(height: 10),

                          Row(
                            children: [
                              const Icon(Icons.airlines, size: 20, color: Colors.black54),
                              const SizedBox(width: 6),
                              Expanded(
                                child: Text(
                                  f.airline?.name ?? "Unknown Airline",
                                  style: const TextStyle(fontSize: 14),
                                  overflow: TextOverflow.ellipsis,
                                ),
                              ),
                            ],
                          ),

                          const SizedBox(height: 6),

                          Row(
                            children: [
                              const Icon(Icons.access_time, size: 20, color: Colors.black54),
                              const SizedBox(width: 6),
                              const Text(
                                "Departure:",
                                style: TextStyle(fontSize: 14, fontWeight: FontWeight.w600),
                              ),
                              const SizedBox(width: 4),
                              Text(
                                departureText,
                                style: const TextStyle(fontSize: 14),
                              ),
                            ],
                          ),

                          const SizedBox(height: 6),

                          Row(
                            children: [
                              const Icon(Icons.price_change, size: 20, color: Colors.green),
                              const SizedBox(width: 6),
                              Text(
                                "${f.price} KM",
                                style: const TextStyle(
                                  fontSize: 15,
                                  fontWeight: FontWeight.bold,
                                  color: Colors.green,
                                ),
                              ),
                            ],
                          ),

                          const SizedBox(height: 10),

                          ElevatedButton(
                              onPressed: () async {
                              final result = await showDialog(
                                context: context,
                                builder: (_) => BookNowDialog(
                                  flight: f,
                                  airlineName: f.airline?.name ?? "Airline",
                                  airportId: selectedAirportId,
                                ),
                              );
                          
                              if (result == true && context.mounted) {
                                widget.onFlightBooked();
                                ScaffoldMessenger.of(context).showSnackBar(
                                  const SnackBar(content: Text("Flight booked successfully")),
                                );
                              }
                            },
                            style: ElevatedButton.styleFrom(
                              backgroundColor: Colors.blue,
                              minimumSize: const Size(double.infinity, 40),
                              shape: RoundedRectangleBorder(
                                borderRadius: BorderRadius.circular(10),
                              ),
                            ),
                            child: const Text(
                              "Book now",
                              style: TextStyle(color: Colors.white),
                            ),
                          ),
                        ],
                      ),
                    );
                  },
                ),
              ),
            ),

          ],
        ),

        const SizedBox(height: 8),

        Card(
          elevation: 4,
          shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(18)),
          child: Padding(
            padding: const EdgeInsets.all(20),
            child: IntrinsicHeight(
              child: Row(
                crossAxisAlignment: CrossAxisAlignment.stretch,
                children: [
                  Expanded(flex: 5, child: _LeftPanel()),

                  const VerticalDivider(width: 32, thickness: 1),

                  Expanded(
                    flex: 7,
                    child: _RightForm(
                      airports: airports,
                      isLoadingAirports: isLoadingAirports,
                      selectedAirportId: selectedAirportId,
                      onAirportChanged: (v) {
                        setState(() => selectedAirportId = v);
                        if (v != null) _loadAirlinesByAirport(v);
                      },

                      airlines: airlines,
                      isLoadingAirlines: isLoadingAirlines,
                      selectedAirlineId: selectedAirlineId,
                      onAirlineChanged: (v) async {
                      setState(() => selectedAirlineId = v);

                        if (v != null) {
                          final fp = FlightProvider();
                          final loc = await fp.getFutureLocations(v);
                      
                          setState(() {
                            fromLocations = loc["from"]!;
                            toLocations = loc["to"]!;

                            selectedFrom = null;
                            selectedTo = null;

                            _fromCtrl.text = "";
                            _toCtrl.text = "";
                          });
                        }
                      },

                      selectedFrom: selectedFrom,
                      selectedTo: selectedTo,
                      fromLocations: fromLocations,
                      toLocations: toLocations,

                      onFromChanged: (v) {
                        setState(() {
                          selectedFrom = v;
                          _fromCtrl.text = v ?? "";
                        });
                      },

                      onToChanged: (v) {
                        setState(() {
                          selectedTo = v;
                          _toCtrl.text = v ?? "";
                        });
                      },


                      fromCtrl: _fromCtrl,
                      toCtrl: _toCtrl,
                      selectedDate: selectedDate,
                      colorScheme: cs,
                      inputDecoration: _inputDecoration,
                      onPickDate: _pickDate,
                      onSearch: _searchFlights,
                    ),
                  ),
                ],
              ),
            ),
          ),
        ),

        const SizedBox(height: 16),
        if (isSearching) const LinearProgressIndicator(),

        if (!isSearching && flights.isEmpty)
          const Text("No results yet. Use the search above."),

        if (flights.isNotEmpty)
          ListView.separated(
            shrinkWrap: true,
            physics: const NeverScrollableScrollPhysics(),
            itemCount: flights.length,
            separatorBuilder: (_, __) => const SizedBox(height: 10),
            itemBuilder: (_, i) => FlightResultCard(
              flight: flights[i],
              airlineName: airlines
                      .firstWhere(
                          (a) => a.airlineId == flights[i].airlineId,
                          orElse: () => Airline(name: "Airline"))
                      .name ??
                  "Airline",
                   airportId: selectedAirportId,
                   reservations: myReservations,
            ),
          ),
      ],
    );
  }
}

class _LeftPanel extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    final cs = Theme.of(context).colorScheme;

    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        Text("Planning a journey?",
            style: TextStyle(
                color: cs.primary.withOpacity(0.8),
                fontWeight: FontWeight.w600)),
        const SizedBox(height: 4),
        Text("Book a Flight",
            style: TextStyle(
                fontSize: 28,
                fontWeight: FontWeight.w800,
                color: cs.primary)),
        const SizedBox(height: 16),

        Center(
          child: ClipRRect(
            borderRadius: BorderRadius.circular(12),
            child: Image.asset(
              "assets/images/airplane-home.png",
              width: 300,
              height: 150,
              fit: BoxFit.contain,
            ),
          ),
        ),
      ],
    );
  }
}

class _RightForm extends StatelessWidget {
  const _RightForm({
    required this.airports,
    required this.isLoadingAirports,
    required this.selectedAirportId,
    required this.onAirportChanged,
    required this.airlines,
    required this.isLoadingAirlines,
    required this.selectedAirlineId,
    required this.onAirlineChanged,
    required this.fromCtrl,
    required this.toCtrl,
    required this.selectedDate,
    required this.colorScheme,
    required this.inputDecoration,
    required this.onPickDate,
    required this.onSearch,
    required this.selectedFrom,
    required this.selectedTo,
    required this.fromLocations,
    required this.toLocations,
    required this.onFromChanged,
    required this.onToChanged,
  });

  final List<Airport> airports;
  final bool isLoadingAirports;
  final int? selectedAirportId;
  final void Function(int?) onAirportChanged;

  final List<Airline> airlines;
  final bool isLoadingAirlines;
  final int? selectedAirlineId;
  final void Function(int?) onAirlineChanged;

  final TextEditingController fromCtrl;
  final TextEditingController toCtrl;
  final DateTime? selectedDate;

  final ColorScheme colorScheme;
  final InputDecoration Function(String, IconData) inputDecoration;
  final VoidCallback onPickDate;
  final VoidCallback onSearch;

  final String? selectedFrom;
  final String? selectedTo;
  final List<String> fromLocations;
  final List<String> toLocations;

final void Function(String?) onFromChanged;
final void Function(String?) onToChanged;


  @override
  Widget build(BuildContext context) {
    final cs = colorScheme;

    return Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [
        isLoadingAirports
            ? const LinearProgressIndicator()
            : DropdownButtonFormField<int>(
              isExpanded: true,
              value: selectedAirportId,
              decoration: inputDecoration("Airport", Icons.location_city),
              items: airports
                  .map((a) => DropdownMenuItem<int>(
                        value: a.airportId,
                        child: Text(
                          "${a.city ?? ''} - ${a.name ?? ''}",
                          overflow: TextOverflow.ellipsis,
                        ),
                      ))
                  .toList(),
              onChanged: onAirportChanged,
            ),

        const SizedBox(height: 12),

        isLoadingAirlines
            ? const LinearProgressIndicator()
            : DropdownButtonFormField<int>(
                value: selectedAirlineId,
                decoration: inputDecoration("Airlines", Icons.flight),
                items: airlines
                    .map((a) => DropdownMenuItem<int>(
                          value: a.airlineId,
                          child: Text(a.name ?? ""),
                        ))
                    .toList(),
                onChanged: onAirlineChanged,
              ),

        const SizedBox(height: 12),

        Row(
          children: [
            Expanded(
              child: DropdownButtonFormField<String>(
                value: selectedFrom,
                decoration: inputDecoration("From", Icons.flight_takeoff),
                items: fromLocations
                    .map((f) => DropdownMenuItem(value: f, child: Text(f)))
                    .toList(),
                onChanged: onFromChanged,
              ),
            ),

            const SizedBox(width: 12),

            Expanded(
              child: DropdownButtonFormField<String>(
                value: selectedTo,
                decoration: inputDecoration("To", Icons.flight_land),
                items: toLocations
                    .map((t) => DropdownMenuItem(value: t, child: Text(t)))
                    .toList(),
                onChanged: onToChanged,
              ),
            ),
          ],
        ),



        const SizedBox(height: 12),

        InkWell(
          onTap: onPickDate,
          child: InputDecorator(
            decoration: inputDecoration("Date", Icons.calendar_today),
            child: Text(
              selectedDate == null
                  ? "Select date"
                  : "${selectedDate!.day}.${selectedDate!.month}.${selectedDate!.year}",
            ),
          ),
        ),

        const SizedBox(height: 20),

        SizedBox(
          width: double.infinity,
          height: 46,
          child: ElevatedButton(
            onPressed: onSearch,
            style: ElevatedButton.styleFrom(
              backgroundColor: cs.primary,
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(14),
              ),
            ),
            child: const Text(
              "SEARCH",
              style:
                  TextStyle(fontSize: 16, fontWeight: FontWeight.bold, color: Colors.white),
            ),
          ),
        ),
      ],
    );
  }
}

class FlightResultCard extends StatelessWidget {
  final Flight flight;
  final String airlineName;
  final int? airportId;
  final List reservations;

  const FlightResultCard({
    super.key,
    required this.flight,
    required this.airlineName,
    required this.airportId,
    required this.reservations,
  });

  String _formatDate(DateTime d) {
    final months = [
      "Jan","Feb","Mar","Apr","May","Jun",
      "Jul","Aug","Sep","Oct","Nov","Dec"
    ];
    final h = d.hour.toString().padLeft(2, '0');
    final m = d.minute.toString().padLeft(2, '0');
    return "${d.day} ${months[d.month - 1]} ${d.year}  $h:$m";
  }

  Duration? get _duration {
  if (flight.departureTime == null || flight.arrivalTime == null) return null;

  DateTime dep = flight.departureTime!;
  DateTime arr = flight.arrivalTime!;

  if (arr.isBefore(dep)) {
    arr = arr.add(const Duration(days: 1));
  }

  return arr.difference(dep);
}


  String get _durationText {
    final d = _duration;
    if (d == null) return "";
    final h = d.inHours;
    final m = d.inMinutes.remainder(60);
    return "${h}h ${m}m";
  }

  @override
Widget build(BuildContext context) {
  final cs = Theme.of(context).colorScheme;
  final String? logoPath = _getAirlineLogo(airlineName);

  final alreadyBooked = reservations.any(
    (r) =>
        r.flightId == flight.flightId &&
        r.stateMachine?.toLowerCase() != "cancelled",
  );

  return Container(
    decoration: BoxDecoration(
      color: cs.surface,
      borderRadius: BorderRadius.circular(14),
      border: Border.all(color: cs.outlineVariant),
      boxShadow: [
        BoxShadow(
          color: Colors.black.withOpacity(0.05),
          blurRadius: 6,
        )
      ],
    ),
    padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 14),
    child: Row(
      children: [
        CircleAvatar(
          radius: 28,
          backgroundColor: cs.primary.withOpacity(0.15),
          backgroundImage: logoPath != null ? AssetImage(logoPath) : null,
          child: logoPath == null
              ? Text(
                  airlineName.isNotEmpty ? airlineName[0] : "A",
                  style: TextStyle(
                    color: cs.primary,
                    fontWeight: FontWeight.bold,
                  ),
                )
              : null,
        ),

        const SizedBox(width: 16),

        Expanded(
          child: Row(
            children: [
              Expanded(
                child: _locationBlock(
                  title: flight.departureLocation ?? "-",
                  time: flight.departureTime != null
                      ? _formatDate(flight.departureTime!)
                      : "-",
                  alignEnd: false,
                ),
              ),

              Expanded(
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.center,
                  children: [
                    Text(
                      airlineName,
                      style: TextStyle(
                        color: cs.primary,
                        fontWeight: FontWeight.w700,
                      ),
                    ),
                    const SizedBox(height: 4),
                    Text(
                      _durationText,
                      style: const TextStyle(fontWeight: FontWeight.w700),
                    ),
                    const Text("Non-stop"),
                  ],
                ),
              ),

              Expanded(
                child: _locationBlock(
                  title: flight.arrivalLocation ?? "-",
                  time: flight.arrivalTime != null
                      ? _formatDate(flight.arrivalTime!)
                      : "-",
                  alignEnd: true,
                ),
              ),
            ],
          ),
        ),

        const SizedBox(width: 20),

        Column(
          crossAxisAlignment: CrossAxisAlignment.end,
          children: [
            Text(
              flight.price != null ? "\$${flight.price}" : "---",
              style: const TextStyle(
                fontSize: 18,
                fontWeight: FontWeight.w800,
              ),
            ),

            const SizedBox(height: 8),

            alreadyBooked
                ? Container(
                    padding: const EdgeInsets.symmetric(horizontal: 14, vertical: 6),
                    decoration: BoxDecoration(
                      color: Colors.red.shade50,
                      borderRadius: BorderRadius.circular(14),
                    ),
                    child: const Text(
                      "Already booked",
                      style: TextStyle(
                        color: Colors.red,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                  )
                : ElevatedButton(
                    onPressed: () {
                      showDialog(
                        context: context,
                        builder: (_) => BookNowDialog(
                          flight: flight,
                          airlineName: airlineName,
                          airportId: airportId,
                        ),
                      );
                    },
                    style: ElevatedButton.styleFrom(
                      backgroundColor: cs.primary,
                      padding: const EdgeInsets.symmetric(horizontal: 16),
                    ),
                    child: const Text(
                      "Book now",
                      style: TextStyle(color: Colors.white),
                    ),
                  ),
          ],
        ),
      ],
    ),
  );
}


  String? _getAirlineLogo(String airlineName) {
  final logos = {
    "Turkish Airlines": "assets/images/turkishairlines.png",
    "Lufthansa": "assets/images/lufthansa.png",
    "Ryanair": "assets/images/ryanair.png",
    "Fly emirates": "assets/images/flyemirates.png"
  };

  return logos[airlineName];
}


  Widget _locationBlock({
    required String title,
    required String time,
    required bool alignEnd,
  }) {
    return Column(
      crossAxisAlignment:
          alignEnd ? CrossAxisAlignment.end : CrossAxisAlignment.start,
      children: [
        Text(title, style: const TextStyle(fontWeight: FontWeight.w700)),
        const SizedBox(height: 4),
        Text(
          time,
          style: const TextStyle(
            color: Colors.blueAccent,
            fontWeight: FontWeight.w500,
          ),
        ),
      ],
    );
  }
}

 class BookNowDialog extends StatefulWidget {
  final Flight flight;
  final String airlineName;
  final int? airportId;

  const BookNowDialog({
    super.key,
    required this.flight,
    required this.airlineName,
    required this.airportId,
  });

  @override
  State<BookNowDialog> createState() => _BookNowDialogState();
}

class _BookNowDialogState extends State<BookNowDialog> {
  String? selectedSeat;

  final _passengerFormKey = GlobalKey<FormState>();
  final _dobCtrl = TextEditingController();
  final _addressCtrl = TextEditingController();
  final _cityCtrl = TextEditingController();
  final _countryCtrl = TextEditingController();
  final _passportCtrl = TextEditingController();
  final _citizenshipCtrl = TextEditingController();
  final _baggageCtrl = TextEditingController();

  List<SeatClass> seatClasses = [];
  List<MealType> mealTypes = [];

  SeatClass? selectedSeatClass;
  MealType? selectedMeal;

  Set<String> occupiedSeats = {};

  bool isLoading = true;

  @override
  void dispose() {
    _dobCtrl.dispose();
    _addressCtrl.dispose();
    _cityCtrl.dispose();
    _countryCtrl.dispose();
    _passportCtrl.dispose();
    _citizenshipCtrl.dispose();
    _baggageCtrl.dispose();
    super.dispose();
  }

  @override
  void initState() {
    super.initState();
    _loadData();
  }

  Future<void> _loadData() async {
    try {
      final seatProvider = SeatClassProvider();
      final mealProvider = MealTypeProvider();

      final seatPaged = await seatProvider.get();
      final mealPaged = await mealProvider.get();


      final flightProv = FlightProvider();
      final seats = await flightProv.getOccupiedSeats(widget.flight.flightId!);

      setState(() {
        occupiedSeats = seats.toSet();
        seatClasses = seatPaged.result;
        mealTypes = mealPaged.result;

        selectedSeatClass = seatClasses.firstWhere(
          (x) => x.name?.toLowerCase() == "economy",
          orElse: () => seatClasses.first,
        );

        selectedMeal = mealTypes.first;

        isLoading = false;
      });
    } catch (e) {
      print("ERROR LOADING DATA: $e");
      setState(() => isLoading = false);
    }
  }

  double get totalPrice {
    final base = widget.flight.price?.toDouble() ?? 0;
    final seatPrice = selectedSeatClass?.priceMultiplier ?? 0;
    final mealPrice = selectedMeal?.price ?? 0;

    return base + seatPrice + mealPrice;
  }

  Future<void> _confirmBooking() async {
    if (!_passengerFormKey.currentState!.validate()) {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(content: Text("Please complete passenger details")),
      );
      return;
    }

    if (selectedSeat == null) {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(content: Text("Please select a seat")),
      );
      return;
    }

    final reservationProvider = ReservationProvider();

    final request = {
  "userId": AuthProvider.userId,
  "flightId": widget.flight.flightId,
  "seatId": selectedSeatClass?.seatClassId,
  "mealTypeId": selectedMeal?.mealTypeId,
  "selectedSeat": selectedSeat,
  "airportId": widget.airportId,
  "airplaneId": widget.flight.airplaneId,
  "dateOfBirth": _dobCtrl.text.trim(),
  "address": _addressCtrl.text.trim(),
  "city": _cityCtrl.text.trim(),
  "country": _countryCtrl.text.trim(),
  "passportNumber": _passportCtrl.text.trim(),
  "citizenship": _citizenshipCtrl.text.trim(),
  "baggageInfo": _baggageCtrl.text.trim(),
};

    try {
      final reservation = await reservationProvider.insert(request);

      if (!mounted) return;

      final result = await Navigator.push(
        context,
        MaterialPageRoute(
          builder: (_) => PaymentScreen(
            reservationId: reservation.reservationId!,
            userId: AuthProvider.userId!,
            amount: totalPrice.toInt(),
          ),
        ),
      );
      
      if (result == true) {
        Navigator.pop(context, true); 
      }

    } catch (e) {
      print("ERROR: $e");
      ScaffoldMessenger.of(context).showSnackBar(
        SnackBar(content: Text("Reservation failed: $e")),
      );
    }
  }

  @override
  Widget build(BuildContext context) {
    final cs = Theme.of(context).colorScheme;

    return Dialog(
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(18)),
      child: Container(
        width: 900,
        height: 900,
        child: isLoading
            ? const Center(child: CircularProgressIndicator())
            : Row(
                children: [
                  Expanded(
                    flex: 5,
                    child: _buildSeatGrid(cs),
                  ),
                  Expanded(
                    flex: 4,
                    child: _buildRightPanel(cs),
                  )
                ],
              ),
      ),
    );
  }

  Widget _buildSeatGrid(ColorScheme cs) {
    final allowedRows = _allowedRowsForSeatClass(selectedSeatClass);
    return Padding(
      padding: const EdgeInsets.all(20),
      child: Column(
        children: [
          Text("Select Your Seat",
              style: TextStyle(fontSize: 18, color: cs.primary)),
          const SizedBox(height: 12),
          Expanded(
            child: GridView.builder(
              gridDelegate: const SliverGridDelegateWithFixedCrossAxisCount(
                crossAxisCount: 6,
                crossAxisSpacing: 8,
                mainAxisSpacing: 8,
              ),
              itemCount: 60,
              itemBuilder: (_, i) {
                final row = (i ~/ 6) + 1;
                final col = String.fromCharCode(65 + (i % 6));
                final seat = "$row$col";
                final isOccupied = occupiedSeats.contains(seat);
                final isSelected = selectedSeat == seat;
                final isAllowed = allowedRows.contains(row);
                final isSelectable = isAllowed && !isOccupied;

                return GestureDetector(
                  onTap: isSelectable
                      ? () => setState(() => selectedSeat = seat)
                      : null,
                  child: Container(
                    alignment: Alignment.center,
                    decoration: BoxDecoration(
                      color: isOccupied
                          ? Colors.grey.shade400
                          : isSelected
                              ? cs.primary
                              : isAllowed
                                  ? Colors.white
                                  : Colors.grey.shade200,
                      borderRadius: BorderRadius.circular(8),
                      border: Border.all(color: cs.primary),
                    ),
                    child: Text(
                      seat,
                      style: TextStyle(
                        color: isSelected
                            ? Colors.white
                            : isAllowed
                                ? cs.primary
                                : Colors.grey,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                  ),
                );
              },
            ),
          )
        ],
      ),
    );
  }

  Set<int> _allowedRowsForSeatClass(SeatClass? seatClass) {
    final name = seatClass?.name?.toLowerCase() ?? '';

    if (name.contains('first')) {
      return {1, 2, 3};
    }

    if (name.contains('business')) {
      return {4, 5, 6};
    }

    return {7, 8, 9, 10};
  }

  bool _isSeatAllowedForClass(String? seat, [SeatClass? seatClass]) {
    if (seat == null || seat.isEmpty) {
      return true;
    }

    final match = RegExp(r'^(\d+)').firstMatch(seat);
    if (match == null) return false;

    final row = int.tryParse(match.group(1) ?? '');
    if (row == null) return false;

    return _allowedRowsForSeatClass(seatClass ?? selectedSeatClass).contains(row);
  }


  Widget _buildRightPanel(ColorScheme cs) {
    return Container(
      padding: const EdgeInsets.all(20),
      color: cs.primary.withOpacity(0.05),
      child: Form(
  key: _passengerFormKey,
  child: SingleChildScrollView(
    padding: const EdgeInsets.only(bottom: 16),
    child: Column(
      crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Text("Flight Options",
                style: TextStyle(fontSize: 18, color: cs.primary)),
            const SizedBox(height: 12),

          _dropdown<SeatClass>(
            "Class",
            selectedSeatClass,
            seatClasses,
            (v) => setState(() {
              selectedSeatClass = v;

              if (!_isSeatAllowedForClass(selectedSeat, v)) {
                selectedSeat = null;
              }
            }),
            (x) => x.name ?? "",
          ),

          const SizedBox(height: 12),

          _dropdown<MealType>(
            "Meal",
            selectedMeal,
            mealTypes,
            (v) => setState(() => selectedMeal = v),
            (x) => x.name ?? "",
          ),

          const SizedBox(height: 16),
            const Divider(),
            const SizedBox(height: 12),
            Text(
              "Passenger details",
              style: TextStyle(
                fontSize: 16,
                color: cs.primary,
                fontWeight: FontWeight.w700,
              ),
            ),
            const SizedBox(height: 12),
            TextFormField(
              controller: _dobCtrl,
              decoration: const InputDecoration(
                labelText: "Date of birth",
                hintText: "DD/MM/YYYY",
              ),
              validator: (v) => v == null || v.trim().isEmpty ? "Required" : null,
            ),
            const SizedBox(height: 12),
            TextFormField(
              controller: _addressCtrl,
              decoration: const InputDecoration(
                labelText: "Address",
              ),
              validator: (v) => v == null || v.trim().isEmpty ? "Required" : null,
            ),
            const SizedBox(height: 12),
            Row(
              children: [
                Expanded(
                  child: TextFormField(
                    controller: _cityCtrl,
                    decoration: const InputDecoration(
                      labelText: "City",
                    ),
                    validator: (v) =>
                        v == null || v.trim().isEmpty ? "Required" : null,
                  ),
                ),
                const SizedBox(width: 12),
                Expanded(
                  child: TextFormField(
                    controller: _countryCtrl,
                    decoration: const InputDecoration(
                      labelText: "Country",
                    ),
                    validator: (v) =>
                        v == null || v.trim().isEmpty ? "Required" : null,
                  ),
                ),
              ],
            ),
            const SizedBox(height: 12),
            Row(
              children: [
                Expanded(
                  child: TextFormField(
                    controller: _passportCtrl,
                    decoration: const InputDecoration(
                      labelText: "Passport number",
                    ),
                    validator: (v) =>
                        v == null || v.trim().isEmpty ? "Required" : null,
                  ),
                ),
                const SizedBox(width: 12),
                Expanded(
                  child: TextFormField(
                    controller: _citizenshipCtrl,
                    decoration: const InputDecoration(
                      labelText: "Citizenship",
                    ),
                    validator: (v) =>
                        v == null || v.trim().isEmpty ? "Required" : null,
                  ),
                ),
              ],
            ),
            const SizedBox(height: 12),
            TextFormField(
              controller: _baggageCtrl,
              decoration: const InputDecoration(
                labelText: "Travel bag info",
                hintText: "e.g., 1 cabin bag, 1 checked bag",
              ),
              validator: (v) => v == null || v.trim().isEmpty ? "Required" : null,
            ),

            const Spacer(),
            const Divider(),
            const SizedBox(height: 8),

            Text("Total: \$${totalPrice.toStringAsFixed(2)}",
              style: TextStyle(fontSize: 20, color: cs.primary)),

          SizedBox(
              width: double.infinity,
              height: 44,
              child: ElevatedButton(
                onPressed: selectedSeat == null ? null : _confirmBooking,
                child: const Text("Book Flight"),
              ),
            )
          ],
        ),
      ),
      ),
    );
  }

  Widget _dropdown<T>(
    String label,
    T? selected,
    List<T> items,
    Function(T?) onChanged,
    String Function(T) getLabel,
  ) {
    return DropdownButtonFormField<T>(
      value: selected,
      decoration: InputDecoration(
        labelText: label,
        filled: true,
        fillColor: Colors.white,
        border: OutlineInputBorder(
          borderRadius: BorderRadius.circular(10),
          borderSide: BorderSide.none,
        ),
      ),
      items: items
          .map((item) => DropdownMenuItem<T>(
                value: item,
                child: Text(getLabel(item)),
              ))
          .toList(),
      onChanged: onChanged,
    );
  }
}

  Widget _counter(String label, int value, Function(int) onChanged) {
    return Row(
      mainAxisAlignment: MainAxisAlignment.spaceBetween,
      children: [
        Text(label, style: const TextStyle(fontWeight: FontWeight.w600)),
        Row(
          children: [
            IconButton(
              icon: const Icon(Icons.remove_circle_outline),
              onPressed: value > 0 ? () => onChanged(value - 1) : null,
            ),
            Text("$value", style: const TextStyle(fontWeight: FontWeight.bold)),
            IconButton(
              icon: const Icon(Icons.add_circle_outline),
              onPressed: () => onChanged(value + 1),
            ),
          ],
        ),
      ],
    );
  }

