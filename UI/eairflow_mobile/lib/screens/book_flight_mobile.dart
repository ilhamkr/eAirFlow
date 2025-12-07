import 'package:eairflow_mobile/models/airlines.dart';
import 'package:eairflow_mobile/models/airport.dart';
import 'package:eairflow_mobile/models/flight.dart';
import 'package:eairflow_mobile/models/mealtype.dart';
import 'package:eairflow_mobile/models/seatclass.dart';
import 'package:eairflow_mobile/providers/airlines_provider.dart';
import 'package:eairflow_mobile/providers/airport_provider.dart';
import 'package:eairflow_mobile/providers/auth_provider.dart';
import 'package:eairflow_mobile/providers/flight_provider.dart';
import 'package:eairflow_mobile/providers/mealtype_provider.dart';
import 'package:eairflow_mobile/providers/reservation_provider.dart';
import 'package:eairflow_mobile/providers/seatclass_provider.dart';
import 'package:eairflow_mobile/providers/user_provider.dart';
import 'package:eairflow_mobile/screens/payment_screen.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';

class BookFlightCard extends StatefulWidget {
  final VoidCallback? onBookingFinished;
  const BookFlightCard({super.key, this.onBookingFinished});

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
      _fromCtrl.clear();
      _toCtrl.clear();
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
      contentPadding: const EdgeInsets.symmetric(horizontal: 12, vertical: 10),
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
              height: 230,
              child: ListView.separated(
                scrollDirection: Axis.horizontal,
                itemCount: recommendedFlights.length,
                separatorBuilder: (_, __) => const SizedBox(width: 12),
      
                itemBuilder: (_, i) {
  final f = recommendedFlights[i];
  final df = DateFormat("yyyy-MM-dd HH:mm");

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
            const Text(
              " Departure time:",
              style: TextStyle(fontSize: 14, fontWeight: FontWeight.w600),
            ),
            const SizedBox(width: 6),
            Text(
              f.departureTime != null ? df.format(f.departureTime!) : 'N/A',
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

        const SizedBox(height: 14),
        Divider(color: Colors.grey.shade300),
        const SizedBox(height: 10),

        SizedBox(
          width: double.infinity,
          child: ElevatedButton(
            onPressed: () async {  
              final result = await Navigator.push(
                context,
                MaterialPageRoute(
                  builder: (_) => BookNowPage(
                    flight: f,
                    airlineName: f.airline?.name ?? "Airline",
                    airportId: f.airline?.airportId,
                  ),
                ),
              );

              if (result == true) {
                widget.onBookingFinished?.call();
              }
            },
            style: ElevatedButton.styleFrom(
              backgroundColor: Colors.blue.shade700,
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(12),
              ),
            ),
            child: const Text(
              "Book Now",
              style: TextStyle(
                color: Colors.white,
                fontWeight: FontWeight.bold,
              ),
            ),
          ),
        ),

      ],
    ),
  );


                },
              ),
            ),
          ],
        ),

        Card(
          elevation: 3,
          shape:
              RoundedRectangleBorder(borderRadius: BorderRadius.circular(18)),
          child: Padding(
            padding: const EdgeInsets.all(16),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text(
                  "Book a Flight",
                  style: TextStyle(
                    fontSize: 22,
                    fontWeight: FontWeight.w800,
                    color: cs.primary,
                  ),
                ),
                const SizedBox(height: 4),
                Text(
                  "Plan your next trip in a few taps.",
                  style: TextStyle(
                    color: cs.primary.withOpacity(0.65),
                    fontSize: 13,
                  ),
                ),
                const SizedBox(height: 14),
                Center(
                  child: ClipRRect(
                    borderRadius: BorderRadius.circular(16),
                    child: Image.asset(
                      "assets/images/airplane-home.png",
                      width: 260,
                      height: 180,
                      fit: BoxFit.cover,
                    ),
                  ),
                ),
                const SizedBox(height: 18),

                _RightForm(
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
                        fromLocations = loc["from"] ?? [];
                        toLocations = loc["to"] ?? [];
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
              ],
            ),
          ),
        ),

        const SizedBox(height: 16),

        if (isSearching) const LinearProgressIndicator(),

        if (!isSearching && flights.isEmpty)
          const Padding(
            padding: EdgeInsets.only(top: 6),
            child: Text(
              "No results yet. Use the search above.",
              style: TextStyle(fontSize: 13),
            ),
          ),

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
                        orElse: () => Airline(name: "Airline"),
                      )
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
                    .map(
                      (a) => DropdownMenuItem<int>(
                        value: a.airportId,
                        child: Text(
                          "${a.city ?? ''} - ${a.name ?? ''}",
                          overflow: TextOverflow.ellipsis,
                        ),
                      ),
                    )
                    .toList(),
                onChanged: onAirportChanged,
              ),
        const SizedBox(height: 10),

        isLoadingAirlines
            ? const LinearProgressIndicator()
            : DropdownButtonFormField<int>(
                value: selectedAirlineId,
                decoration: inputDecoration("Airlines", Icons.flight),
                items: airlines
                    .map(
                      (a) => DropdownMenuItem<int>(
                        value: a.airlineId,
                        child: Text(a.name ?? ""),
                      ),
                    )
                    .toList(),
                onChanged: onAirlineChanged,
              ),
        const SizedBox(height: 10),

        Column(
          children: [
            DropdownButtonFormField<String>(
              value: selectedFrom,
              decoration: inputDecoration("From", Icons.flight_takeoff),
              items: fromLocations
                  .map((f) => DropdownMenuItem(value: f, child: Text(f)))
                  .toList(),
              onChanged: onFromChanged,
            ),
            const SizedBox(height: 10),
            DropdownButtonFormField<String>(
              value: selectedTo,
              decoration: inputDecoration("To", Icons.flight_land),
              items: toLocations
                  .map((t) => DropdownMenuItem(value: t, child: Text(t)))
                  .toList(),
              onChanged: onToChanged,
            ),
          ],
        ),

        const SizedBox(height: 10),

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
        const SizedBox(height: 16),

        SizedBox(
          width: double.infinity,
          height: 48,
          child: ElevatedButton(
            onPressed: onSearch,
            style: ElevatedButton.styleFrom(
              backgroundColor: cs.primary,
              shape: RoundedRectangleBorder(
                borderRadius: BorderRadius.circular(14),
              ),
            ),
            child: const Text(
              "Search flights",
              style: TextStyle(
                fontSize: 16,
                fontWeight: FontWeight.bold,
                color: Colors.white,
              ),
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
    required this.reservations
  });

  String _formatDate(DateTime d) {
    final months = [
      "Jan","Feb","Mar","Apr","May","Jun",
      "Jul","Aug","Sep","Oct","Nov","Dec"
    ];
    final h = d.hour.toString().padLeft(2, '0');
    final m = d.minute.toString().padLeft(2, '0');
    return "${d.day} ${months[d.month - 1]}  $h:$m";
  }

  Duration? get _duration {
    if (flight.departureTime == null || flight.arrivalTime == null) return null;
    return flight.arrivalTime!.difference(flight.departureTime!);
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
  final alreadyBooked = reservations.any(
    (r) =>
        r.flightId == flight.flightId &&
        r.stateMachine?.toLowerCase() != "cancelled",
  );

  final cs = Theme.of(context).colorScheme;
  final String? logoPath = _getAirlineLogo(airlineName);

  return Container(
    margin: const EdgeInsets.symmetric(vertical: 6),
    padding: const EdgeInsets.all(14),
    decoration: BoxDecoration(
      color: Colors.white,
      borderRadius: BorderRadius.circular(16),
      boxShadow: [
        BoxShadow(
          color: Colors.black.withOpacity(0.06),
          blurRadius: 8,
          offset: const Offset(0, 3),
        ),
      ],
      border: Border.all(color: Colors.grey.shade200),
    ),
    child: Column(
      crossAxisAlignment: CrossAxisAlignment.start,
      children: [

        Row(
          children: [
            CircleAvatar(
              radius: 26,
              backgroundColor: cs.primary.withOpacity(0.08),
              backgroundImage: logoPath != null ? AssetImage(logoPath) : null,
              child: logoPath == null
                  ? Text(
                      airlineName.isNotEmpty ? airlineName[0] : "A",
                      style: TextStyle(
                        color: cs.primary,
                        fontWeight: FontWeight.bold,
                        fontSize: 18,
                      ),
                    )
                  : null,
            ),
            const SizedBox(width: 12),

            Expanded(
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Text(
                    airlineName,
                    style: TextStyle(
                      fontWeight: FontWeight.w800,
                      fontSize: 16,
                      color: cs.primary,
                    ),
                  ),
                  const SizedBox(height: 3),
                  Text(
                    flight.price != null ? "${flight.price} KM" : "---",
                    style: TextStyle(
                      fontSize: 16,
                      fontWeight: FontWeight.bold,
                      color: cs.primary,
                    ),
                  ),
                ],
              ),
            ),

            alreadyBooked
                ? Container(
                    padding:
                        const EdgeInsets.symmetric(horizontal: 12, vertical: 6),
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
                      Navigator.push(
                        context,
                        MaterialPageRoute(
                          builder: (_) => BookNowPage(
                            flight: flight,
                            airlineName: airlineName,
                            airportId: airportId,
                          ),
                        ),
                      );
                    },
                    style: ElevatedButton.styleFrom(
                      backgroundColor: cs.primary,
                      padding:
                          const EdgeInsets.symmetric(horizontal: 14),
                      shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(20),
                      ),
                    ),
                    child: const Text(
                      "Book",
                      style: TextStyle(color: Colors.white),
                    ),
                  ),
          ],
        ),

        const SizedBox(height: 14),
        Divider(color: Colors.grey.shade300),
        const SizedBox(height: 10),

        Row(
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

            Column(
              children: [
                Icon(Icons.flight_takeoff, size: 20, color: cs.primary),
                const SizedBox(height: 6),
                Text(
                  _durationText,
                  style: const TextStyle(
                    fontWeight: FontWeight.w600,
                    fontSize: 13,
                  ),
                ),
                const Text(
                  "Non-stop",
                  style: TextStyle(fontSize: 11, color: Colors.grey),
                ),
              ],
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
      ],
    ),
  );
}


  String? _getAirlineLogo(String airlineName) {
    final logos = {
      "Turkish Airlines": "assets/images/turkishairlines.png",
      "Lufthansa": "assets/images/lufthansa.png",
      "Ryanair": "assets/images/ryanair.png",
      "Fly emirates": "assets/images/flyemirates.png",
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
        Text(
          title,
          style: const TextStyle(
            fontSize: 15,
            fontWeight: FontWeight.w700,
          ),
        ),
        const SizedBox(height: 5),
        Text(
          time,
          style: const TextStyle(
            color: Colors.blueAccent,
            fontWeight: FontWeight.w600,
            fontSize: 13,
          ),
        ),
      ],
    );
  }
}


  String? _getAirlineLogo(String airlineName) {
    final logos = {
      "Turkish Airlines": "assets/images/turkishairlines.png",
      "Lufthansa": "assets/images/lufthansa.png",
      "Ryanair": "assets/images/ryanair.png",
      "Fly emirates": "assets/images/flyemirates.png",
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
        Text(
          title,
          style: const TextStyle(fontWeight: FontWeight.w700),
        ),
        const SizedBox(height: 4),
        Text(
          time,
          style: const TextStyle(
            color: Colors.blueAccent,
            fontWeight: FontWeight.w500,
            fontSize: 12,
          ),
        ),
      ],
    );
  }


class BookNowPage extends StatefulWidget {
  final Flight flight;
  final String airlineName;
  final int? airportId;

  const BookNowPage({
    super.key,
    required this.flight,
    required this.airlineName,
    required this.airportId,
  });

  @override
  State<BookNowPage> createState() => _BookNowPageState();
}

class _BookNowPageState extends State<BookNowPage> {
  String? selectedSeat;

  List<SeatClass> seatClasses = [];
  List<MealType> mealTypes = [];

  SeatClass? selectedSeatClass;
  MealType? selectedMeal;

  Set<String> occupiedSeats = {};

  bool isLoading = true;

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
        seatClasses = seatPaged.result;
        mealTypes = mealPaged.result;

        if (seatClasses.isNotEmpty) {
          occupiedSeats = seats.toSet();
          selectedSeatClass = seatClasses.firstWhere(
            (x) => x.name?.toLowerCase() == "economy",
            orElse: () => seatClasses.first,
          );
        }

        if (mealTypes.isNotEmpty) {
          selectedMeal = mealTypes.first;
        }

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

  Future<bool> _alreadyBookedThisFlight(int flightId) async {
  final userId = AuthProvider.userId;
  if (userId == null) return false;

  final provider = ReservationProvider();
  final reservations = await provider.getByUser(userId);

  return reservations.any(
    (r) =>
        r.flightId == flightId &&
        r.stateMachine?.toLowerCase() != "cancelled",
  );
}


  Future<void> _confirmBooking() async {
    if (selectedSeat == null) {
      ScaffoldMessenger.of(context).showSnackBar(
        const SnackBar(content: Text("Please select a seat")),
      );
      return;
    }

    final alreadyBooked =
      await _alreadyBookedThisFlight(widget.flight.flightId!);

  if (alreadyBooked) {
    ScaffoldMessenger.of(context).showSnackBar(
      const SnackBar(
        content: Text("You already have a reservation for this flight."),
        backgroundColor: Colors.red,
      ),
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
    };

    print("➡️ INSERT: $request");

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

      if (result == true && mounted) {
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

    return Scaffold(
      appBar: AppBar(
        title: Text(
          "Select seat",
          style: TextStyle(color: cs.onSurface),
        ),
        backgroundColor: cs.surface,
        iconTheme: IconThemeData(color: cs.primary),
        elevation: 1,
      ),
      body: isLoading
          ? const Center(child: CircularProgressIndicator())
          : Column(
              children: [
                Expanded(
                  flex: 6,
                  child: Padding(
                    padding: const EdgeInsets.all(16),
                    child: Column(
                      children: [
                        Text(
                          "${widget.airlineName}  •  ${widget.flight.departureLocation} → ${widget.flight.arrivalLocation}",
                          style: TextStyle(
                            fontSize: 14,
                            color: cs.primary,
                            fontWeight: FontWeight.w600,
                          ),
                          textAlign: TextAlign.center,
                        ),
                        const SizedBox(height: 10),
                        Expanded(
                          child: GridView.builder(
                            gridDelegate:
                                const SliverGridDelegateWithFixedCrossAxisCount(
                              crossAxisCount: 6,
                              crossAxisSpacing: 6,
                              mainAxisSpacing: 6,
                            ),
                            itemCount: 60,
                            itemBuilder: (_, i) {
                              final row = (i ~/ 6) + 1;
                              final col =
                                  String.fromCharCode(65 + (i % 6));
                              final seat = "$row$col";
                              final isOccupied =
                                  occupiedSeats.contains(seat);
                              final isSelected = selectedSeat == seat;

                              return GestureDetector(
                                onTap: isOccupied
                                    ? null
                                    : () => setState(
                                        () => selectedSeat = seat),
                                child: Container(
                                  alignment: Alignment.center,
                                  decoration: BoxDecoration(
                                    color: isOccupied
                                        ? Colors.grey.shade400
                                        : isSelected
                                            ? cs.primary
                                            : Colors.white,
                                    borderRadius: BorderRadius.circular(8),
                                    border:
                                        Border.all(color: cs.primary),
                                  ),
                                  child: Text(
                                    seat,
                                    style: TextStyle(
                                      color: isSelected
                                          ? Colors.white
                                          : cs.primary,
                                      fontWeight: FontWeight.bold,
                                      fontSize: 12,
                                    ),
                                  ),
                                ),
                              );
                            },
                          ),
                        ),
                      ],
                    ),
                  ),
                ),

                Container(
                  padding: const EdgeInsets.all(16),
                  decoration: BoxDecoration(
                    color: cs.primary.withOpacity(0.03),
                    borderRadius: const BorderRadius.vertical(
                      top: Radius.circular(18),
                    ),
                    boxShadow: [
                      BoxShadow(
                        color: Colors.black.withOpacity(0.08),
                        blurRadius: 8,
                        offset: const Offset(0, -2),
                      ),
                    ],
                  ),
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text(
                        "Flight options",
                        style: TextStyle(
                          fontSize: 16,
                          color: cs.primary,
                          fontWeight: FontWeight.w700,
                        ),
                      ),
                      const SizedBox(height: 10),

                      _dropdown<SeatClass>(
                        "Class",
                        selectedSeatClass,
                        seatClasses,
                        (v) => setState(() => selectedSeatClass = v),
                        (x) => x.name ?? "",
                      ),
                      const SizedBox(height: 10),

                      _dropdown<MealType>(
                        "Meal",
                        selectedMeal,
                        mealTypes,
                        (v) => setState(() => selectedMeal = v),
                        (x) => x.name ?? "",
                      ),
                      const SizedBox(height: 10),

                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceBetween,
                        children: [
                          Text(
                            "Total:",
                            style: TextStyle(
                              fontSize: 16,
                              color: cs.primary,
                              fontWeight: FontWeight.w600,
                            ),
                          ),
                          Text(
                            "\$${totalPrice.toStringAsFixed(2)}",
                            style: TextStyle(
                              fontSize: 20,
                              color: cs.primary,
                              fontWeight: FontWeight.w900,
                            ),
                          ),
                        ],
                      ),
                      const SizedBox(height: 12),

                      SizedBox(
                        width: double.infinity,
                        height: 48,
                        child: ElevatedButton(
                          onPressed:
                              selectedSeat == null ? null : _confirmBooking,
                          style: ElevatedButton.styleFrom(
                            backgroundColor: cs.primary,
                            shape: RoundedRectangleBorder(
                              borderRadius: BorderRadius.circular(14),
                            ),
                          ),
                          child: const Text(
                            "Confirm & pay",
                            style: TextStyle(
                              color: Colors.white,
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                        ),
                      )
                    ],
                  ),
                ),
              ],
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
        contentPadding:
            const EdgeInsets.symmetric(horizontal: 12, vertical: 8),
        border: OutlineInputBorder(
          borderRadius: BorderRadius.circular(10),
          borderSide: BorderSide.none,
        ),
      ),
      items: items
          .map(
            (item) => DropdownMenuItem<T>(
              value: item,
              child: Text(getLabel(item)),
            ),
          )
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
