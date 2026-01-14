import 'package:flutter/material.dart';
import 'package:eairflow_desktop/providers/flight_provider.dart';
import 'package:eairflow_desktop/providers/airlines_provider.dart';
import 'package:eairflow_desktop/providers/airport_provider.dart';
import 'package:eairflow_desktop/models/flight.dart';
import 'package:eairflow_desktop/models/airlines.dart';
import 'package:eairflow_desktop/models/airport.dart';
import 'package:eairflow_desktop/utils/timezone_helper.dart';
import 'package:intl/intl.dart';
import 'package:eairflow_desktop/models/time_zone.dart';
import 'package:eairflow_desktop/providers/airplane_provider.dart';
import 'package:eairflow_desktop/models/airplane.dart';


class AdminFlightsScreen extends StatefulWidget {
  const AdminFlightsScreen({super.key});

  @override
  State<AdminFlightsScreen> createState() => _AdminFlightsScreenState();
}

class _AdminFlightsScreenState extends State<AdminFlightsScreen>
    with SingleTickerProviderStateMixin {
  late TabController tabController;

  final _dateTimeFormatter = DateFormat('yyyy-MM-dd HH:mm');

  List<Flight> flights = [];
  List<Airline> airlines = [];
  List<Airport> airports = [];

  final List<TimeZoneInfo> timeZones = [
    TimeZoneInfo(timeZoneId: "Pacific/Baker", displayName: "GMT-12 (Baker Island)"),
    TimeZoneInfo(
        timeZoneId: "Pacific/Pago_Pago", displayName: "GMT-11 (Samoa)"),
    TimeZoneInfo(timeZoneId: "Pacific/Honolulu", displayName: "GMT-10 (Hawaii)"),
    TimeZoneInfo(timeZoneId: "America/Anchorage", displayName: "GMT-9 (Alaska)"),
    TimeZoneInfo(
        timeZoneId: "America/Los_Angeles",
        displayName: "GMT-8 (Los Angeles, Vancouver)"),
    TimeZoneInfo(
        timeZoneId: "America/Denver",
        displayName: "GMT-7 (Denver, Phoenix)"),
    TimeZoneInfo(
        timeZoneId: "America/Chicago",
        displayName: "GMT-6 (Chicago, Mexico City)"),
    TimeZoneInfo(
        timeZoneId: "America/New_York",
        displayName: "GMT-5 (New York, Toronto)"),
    TimeZoneInfo(
        timeZoneId: "America/Caracas",
        displayName: "GMT-4 (Caracas, Atlantic Time)"),
    TimeZoneInfo(
        timeZoneId: "America/Argentina/Buenos_Aires",
        displayName: "GMT-3 (Buenos Aires)"),
    TimeZoneInfo(
        timeZoneId: "Atlantic/South_Georgia",
        displayName: "GMT-2 (South Georgia)"),
    TimeZoneInfo(
        timeZoneId: "Atlantic/Azores", displayName: "GMT-1 (Azores)"),
    TimeZoneInfo(timeZoneId: "Europe/London", displayName: "GMT (London, UTC)"),
    TimeZoneInfo(
        timeZoneId: "Europe/Sarajevo",
        displayName: "GMT+1 (Sarajevo, Berlin)"),
    TimeZoneInfo(
        timeZoneId: "Europe/Athens", displayName: "GMT+2 (Athens, Cairo)"),
    TimeZoneInfo(
        timeZoneId: "Europe/Moscow", displayName: "GMT+3 (Moscow, Istanbul)"),
    TimeZoneInfo(timeZoneId: "Asia/Dubai", displayName: "GMT+4 (Dubai)"),
    TimeZoneInfo(timeZoneId: "Asia/Karachi", displayName: "GMT+5 (Pakistan)"),
    TimeZoneInfo(timeZoneId: "Asia/Dhaka", displayName: "GMT+6 (Bangladesh)"),
    TimeZoneInfo(timeZoneId: "Asia/Bangkok", displayName: "GMT+7 (Thailand)"),
    TimeZoneInfo(
        timeZoneId: "Asia/Singapore",
        displayName: "GMT+8 (China, Singapore)"),
    TimeZoneInfo(timeZoneId: "Asia/Tokyo", displayName: "GMT+9 (Japan)"),
    TimeZoneInfo(
        timeZoneId: "Australia/Sydney", displayName: "GMT+10 (Sydney)"),
    TimeZoneInfo(
        timeZoneId: "Pacific/Guadalcanal",
        displayName: "GMT+11 (Solomon Islands)"),
    TimeZoneInfo(
        timeZoneId: "Pacific/Auckland", displayName: "GMT+12 (New Zealand)"),
  ];

  bool loadingFlights = true;
  bool loadingAirlines = true;
  bool loadingAirports = true;

  final flightProv = FlightProvider();
  final airlineProv = AirlinesProvider();
  final airportProv = AirportProvider();

  

  Map<String, List<Flight>> groupedFlights = {};

  String _departureTimeZone(Flight flight) {
    return flight.departureTimeZone ?? "UTC";
  }

  String _arrivalTimeZone(Flight flight) {
    return flight.arrivalTimeZone ?? "UTC";
  }

  String _formatDateTimeForInput(DateTime? dt, String? timeZoneId) {
    return formatDateInTimeZone(
      dt,
      timeZoneId,
      includeTimeZoneName: false,
    );
  }

  DateTime? _tryParseDateTime(String value) {
    try {
      return _dateTimeFormatter.parseStrict(value);
    } catch (_) {
      return null;
    }
  }

  bool _isBeforeToday(DateTime value) {
    final now = DateTime.now();
    final today = DateTime(now.year, now.month, now.day);
    final dateOnly = DateTime(value.year, value.month, value.day);

    return dateOnly.isBefore(today);
  }

  bool _isArrivalBeforeDeparture(
    DateTime? departure,
    String? departureTimeZoneId,
    DateTime? arrival,
    String? arrivalTimeZoneId,
  ) {
    if (departure == null || arrival == null) return false;
    final departureUtc = toUtcFromTimeZone(departure, departureTimeZoneId);
    final arrivalUtc = toUtcFromTimeZone(arrival, arrivalTimeZoneId);
    return arrivalUtc.isBefore(departureUtc);
  }

  void showSuccess(String msg) {
   ScaffoldMessenger.of(context).showSnackBar(
      SnackBar(
        content: Text(msg),
        backgroundColor: Colors.green,
      ),
    );
  }

  Future<bool> confirmDelete(String title) async {
  return await showDialog(
      context: context,
      builder: (_) => AlertDialog(
        title: const Text("Confirm"),
        content: Text(title),
        actions: [
          TextButton(
              onPressed: () => Navigator.pop(context, false),
              child: const Text("Cancel")),
          ElevatedButton(
              onPressed: () => Navigator.pop(context, true),
              child: const Text("Delete")),
        ],
      ),
    );
  }

  Map<String, List<Flight>> groupFlightsByDay(List<Flight> list) {
    Map<String, List<Flight>> map = {
      "Today": [],
      "Tomorrow": [],
      "In 2 Days": [],
      "In 3 Days": [],
      "In 4 Days": [],
      "In 5 Days": [],
      "Completed": [],
    };

    final now = DateTime.now();

    for (var f in list) {
      if (f.stateMachine?.toLowerCase() == "completed") {
        map["Completed"]!.add(f);
        continue;
      }

      if (f.departureTime == null) continue;

      final dep = f.departureTime!;
      final diff = dep
          .difference(DateTime(now.year, now.month, now.day))
          .inDays;

      if (diff == 0) {
        map["Today"]!.add(f);
      } else if (diff == 1) {
        map["Tomorrow"]!.add(f);
      } else if (diff == 2) {
        map["In 2 Days"]!.add(f);
      } else if (diff == 3) {
        map["In 3 Days"]!.add(f);
      } else if (diff == 4) {
        map["In 4 Days"]!.add(f);
      } else if (diff == 5) {
        map["In 5 Days"]!.add(f);
      }
    }

    return map;
  }

 Future<void> pickDateTime(TextEditingController controller,
      {DateTime? minDate}) async {
    final now = DateTime.now();

  final effectiveMin = minDate ?? now;

  final date = await showDatePicker(
      context: context,
      initialDate: effectiveMin,
      firstDate: effectiveMin,
      lastDate: DateTime(now.year + 5),
    );

    if (date == null) return;

    TimeOfDay? time;
    while (true) {
      time = await showTimePicker(
        context: context,
        initialTime: TimeOfDay.fromDateTime(effectiveMin),
      );

    if (time == null) return;

     final dt =
          DateTime(date.year, date.month, date.day, time.hour, time.minute);

      controller.text = _dateTimeFormatter.format(dt);
      return;
    }
  }




  @override
  void initState() {
    super.initState();

    tabController = TabController(length: 3, vsync: this);

    loadFlights();
    loadAirlines();
    loadAirports();
  }

  Future<void> loadFlights() async {
    try {
      final data = await flightProv.get();

      setState(() {
        flights = data.result;
        groupedFlights = groupFlightsByDay(flights);
        loadingFlights = false;
      });
    } catch (_) {}
  }

  Future<void> loadAirlines() async {
    try {
      final data = await airlineProv.get();
      setState(() {
        airlines = data.result;
        loadingAirlines = false;
      });
    } catch (_) {}
  }

  Future<void> loadAirports() async {
    try {
      final data = await airportProv.get();
      setState(() {
        airports = data.result;
        loadingAirports = false;
      });
    } catch (_) {}
  }


  void addAirportDialog() {
    final name = TextEditingController();
    final city = TextEditingController();
    final country = TextEditingController();
    String? selectedTimeZoneId;

    showDialog(
      context: context,
      builder: (_) => AlertDialog(
        title: const Text("Add Airport"),
        content: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            TextField(controller: name, decoration: const InputDecoration(labelText: "Name")),
            TextField(controller: city, decoration: const InputDecoration(labelText: "City")),
            TextField(controller: country, decoration: const InputDecoration(labelText: "Country")),
          ],
        ),
        actions: [
          TextButton(
            child: const Text("Cancel"),
            onPressed: () => Navigator.pop(context),
          ),
          ElevatedButton(
            child: const Text("Save"),
            onPressed: () async {
              if (name.text.isEmpty ||
                  city.text.isEmpty ||
                  country.text.isEmpty) {
                showDialog(
                  context: context,
                  builder: (_) => AlertDialog(
                    title: const Text("Error"),
                    content: const Text("All fields are required."),
                    actions: [
                      TextButton(onPressed: () => Navigator.pop(context), child: const Text("OK"))
                    ],
                  ),
                );
                return;
              }

              await airportProv.insert({
                "name": name.text,
                "city": city.text,
                "country": country.text,
              });

              Navigator.pop(context);
              loadAirports();
            },
          ),
        ],
      ),
    );
  }

  void editAirportDialog(Airport airport) {
    final name = TextEditingController(text: airport.name);
    final city = TextEditingController(text: airport.city);
    final country = TextEditingController(text: airport.country);

    showDialog(
      context: context,
      builder: (_) => AlertDialog(
        title: const Text("Edit Airport"),
        content: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            TextField(controller: name, decoration: const InputDecoration(labelText: "Name")),
            TextField(controller: city, decoration: const InputDecoration(labelText: "City")),
            TextField(controller: country, decoration: const InputDecoration(labelText: "Country")),
          ],
        ),
        actions: [
          TextButton(
            child: const Text("Cancel"),
            onPressed: () => Navigator.pop(context),
          ),
          ElevatedButton(
            child: const Text("Save"),
            onPressed: () async {
              await airportProv.update(airport.airportId!, {
                "name": name.text,
                "city": city.text,
                "country": country.text,
              });

              Navigator.pop(context);
              loadAirports();
            },
          ),
        ],
      ),
    );
  }

  void addAirlineDialog() {
    final name = TextEditingController();
    final country = TextEditingController();
    int? selectedAirport;
    int? selectedAirplaneId;
    final airplaneProv = AirplaneProvider();
    final List<Airplane> availableAirplanes = [];
    bool loadingAirplanes = false;
    bool loadedAirplanes = false;

    Future<void> loadAvailableAirplanes(void Function(void Function()) setLocal) async {
      setLocal(() {
        loadingAirplanes = true;
      });

      try {
        final airplanes = await airplaneProv.getAll();
        availableAirplanes
          ..clear()
          ..addAll(airplanes);
      } catch (_) {
        availableAirplanes.clear();
      }

      setLocal(() {
        loadingAirplanes = false;
      });
    }

    showDialog(
      context: context,
        builder: (_) => StatefulBuilder(builder: (context, setLocal) {
        if (!loadedAirplanes) {
          loadedAirplanes = true;
          loadAvailableAirplanes(setLocal);
        }
         return AlertDialog(
          title: const Text("Add Airline"),
          content: Column(
            mainAxisSize: MainAxisSize.min,
            children: [
              TextField(controller: name, decoration: const InputDecoration(labelText: "Name")),
              TextField(controller: country, decoration: const InputDecoration(labelText: "Country")),
              DropdownButtonFormField<int>(
                decoration: const InputDecoration(labelText: "Airport"),
                items: airports
                    .map((a) => DropdownMenuItem(
                          value: a.airportId!,
                          child: Text(a.name ?? ""),
                        ))
                    .toList(),
                onChanged: (v) => selectedAirport = v,
              ),
              const SizedBox(height: 12),
              DropdownButtonFormField<int>(
                decoration: const InputDecoration(labelText: "Assign Airplane"),
                items: availableAirplanes
                    .map((a) => DropdownMenuItem(
                          value: a.airplaneId!,
                          child: Text(a.model ?? "Airplane #${a.airplaneId}"),
                        ))
                    .toList(),
                onChanged: loadingAirplanes ? null : (v) {
                  setLocal(() {
                    selectedAirplaneId = v;
                  });
                },
              ),
              if (loadingAirplanes)
                const Padding(
                  padding: EdgeInsets.only(top: 8),
                  child: LinearProgressIndicator(),
                ),
            ], 
            ),
        actions: [
            TextButton(
              child: const Text("Cancel"),
              onPressed: () => Navigator.pop(context),
            ),
            ElevatedButton(
              child: const Text("Save"),
              onPressed: () async {
                if (name.text.isEmpty ||
                    country.text.isEmpty ||
                    selectedAirport == null) {
                  showDialog(
                    context: context,
                    builder: (_) => AlertDialog(
                      title: const Text("Error"),
                      content: const Text("All fields are required."),
                      actions: [
                        TextButton(onPressed: () => Navigator.pop(context), child: const Text("OK"))
                      ],
                    ),
                  );
                  return;
                }

                final airline = await airlineProv.insert({
                  "name": name.text,
                  "country": country.text,
                  "airportId": selectedAirport
                });

                 if (selectedAirplaneId != null) {
                  final selected = availableAirplanes
                      .firstWhere((a) => a.airplaneId == selectedAirplaneId);
                  await airplaneProv.update(selected.airplaneId!, {
                    "model": selected.model ?? "Unknown",
                    "totalSeats": selected.totalSeats,
                    "airlineId": airline.airlineId
                  });
                }

                Navigator.pop(context);
                loadAirlines();
              },
            ),
          ],
        );
      }),
    );
  }

  void editAirlineDialog(Airline airline) {
    final name = TextEditingController(text: airline.name);
    final country = TextEditingController(text: airline.country);
    int? selectedAirport = airline.airportId;

    showDialog(
      context: context,
      builder: (_) => AlertDialog(
        title: const Text("Edit Airline"),
        content: Column(
          mainAxisSize: MainAxisSize.min,
          children: [
            TextField(controller: name, decoration: const InputDecoration(labelText: "Name")),
            TextField(controller: country, decoration: const InputDecoration(labelText: "Country")),
            DropdownButtonFormField<int>(
              value: selectedAirport,
              decoration: const InputDecoration(labelText: "Airport"),
              items: airports
                  .map((a) => DropdownMenuItem(
                        value: a.airportId!,
                        child: Text(a.name ?? ""),
                      ))
                  .toList(),
              onChanged: (v) => selectedAirport = v,
            ),
          ],
        ),
        actions: [
          TextButton(
            child: const Text("Cancel"),
            onPressed: () => Navigator.pop(context),
          ),
          ElevatedButton(
            child: const Text("Save"),
            onPressed: () async {
              await airlineProv.update(airline.airlineId!, {
                "name": name.text,
                "country": country.text,
                "airportId": selectedAirport
              });

              Navigator.pop(context);
              loadAirlines();
            },
          ),
        ],
      ),
    );
  }

  void addFlightDialog() {
    final price = TextEditingController();
    final depTime = TextEditingController();
    final arrTime = TextEditingController();
    final departureLocation = TextEditingController();
    final arrivalLocation = TextEditingController();

    String? depError;
    String? arrError;
    String? priceError;
    String? departureLocationError;
    String? arrivalLocationError;
    String? departureTimeZoneError;
    String? arrivalTimeZoneError;

    int? selectedAirline;
    String? selectedDepartureTimeZoneId;
    String? selectedArrivalTimeZoneId;

    showDialog(
      context: context,
      builder: (_) => StatefulBuilder(builder: (context, setLocal) {
        return AlertDialog(
          title: const Text("Add New Flight"),
          content: SingleChildScrollView(
            child: Column(
              children: [
                TextField(
                controller: departureLocation,
                decoration: InputDecoration(
                 labelText: "Departure location",
                  prefixIcon: const Icon(Icons.flight_takeoff),
                 errorText: departureLocationError,
                ),

                onChanged: (value) {
                  setLocal(() {
                    departureLocationError = value.trim().isEmpty
                        ? "Enter a departure location."
                        : null;
                  });
                },
              ),

               TextField(
                controller: arrivalLocation,
                decoration: InputDecoration(
                 labelText: "Arrival location",
                  prefixIcon: const Icon(Icons.flight_land),
                  errorText: arrivalLocationError,
                ),
                onChanged: (value) {
                  setLocal(() {
                  arrivalLocationError = value.trim().isEmpty
                        ? "Enter an arrival location."
                        : null;
                  });
                },
              ),

               DropdownButtonFormField<String>(
                value: selectedDepartureTimeZoneId,
                decoration: InputDecoration(
                  labelText: "Departure time zone",
                  prefixIcon: const Icon(Icons.public),
                  errorText: departureTimeZoneError,
                ),
                items: timeZones
                    .map((tz) => DropdownMenuItem(
                          value: tz.timeZoneId,
                          child: Text(tz.displayName ?? tz.timeZoneId ?? ""),
                        ))
                    .toList(),
                onChanged: (value) {
                  setLocal(() {
                    selectedDepartureTimeZoneId = value;
                    departureTimeZoneError =
                        value == null ? "Select a departure time zone." : null;
                  });
                },
              ),

              DropdownButtonFormField<String>(
                value: selectedArrivalTimeZoneId,
                decoration: InputDecoration(
                  labelText: "Arrival time zone",
                  prefixIcon: const Icon(Icons.public),
                  errorText: arrivalTimeZoneError,
                ),
                items: timeZones
                    .map((tz) => DropdownMenuItem(
                          value: tz.timeZoneId,
                          child: Text(tz.displayName ?? tz.timeZoneId ?? ""),
                        ))
                    .toList(),
                onChanged: (value) {
                  setLocal(() {
                    selectedArrivalTimeZoneId = value;
                    arrivalTimeZoneError =
                        value == null ? "Select an arrival time zone." : null;
                  });
                },
              ),

              TextField(
                controller: price,
                keyboardType: TextInputType.number,
                decoration: InputDecoration(
                  labelText: "Price",
                  prefixIcon: const Icon(Icons.price_change),
                  errorText: priceError,
                ),
                onChanged: (v) {
                  setLocal(() {
                    priceError = (int.tryParse(v) == null || int.parse(v) <= 0)
                        ? "Price must be a number greater than 0"
                        : null;
                  });
                },
              ),

              TextField(
                controller: depTime,
                readOnly: true,
                decoration: InputDecoration(
                  labelText: "Departure Time",
                  prefixIcon: const Icon(Icons.access_time),
                  errorText: depError,
                ),
                onTap: () async {
                  await pickDateTime(depTime);
                  final dt = _tryParseDateTime(depTime.text);
                  final arrDT = _tryParseDateTime(arrTime.text);

                  setLocal(() {
                     depError = (dt == null || _isBeforeToday(dt))
                        ? "Departure cannot be in the past"
                        : null;
                        arrError = _isArrivalBeforeDeparture(
                            dt,
                            selectedDepartureTimeZoneId,
                            arrDT,
                            selectedArrivalTimeZoneId)
                        ? "Arrival must be after departure"
                        : null;
                  });
                },
              ),

              TextField(
                controller: arrTime,
                readOnly: true,
                decoration: InputDecoration(
                  labelText: "Arrival Time",
                  prefixIcon: const Icon(Icons.timer),
                  errorText: arrError,
                ),
                onTap: () async {
                  await pickDateTime(arrTime);

                  final depDT = _tryParseDateTime(depTime.text);
                  final arrDT = _tryParseDateTime(arrTime.text);

                  setLocal(() {
                    arrError =
                         _isArrivalBeforeDeparture(
                                depDT,
                                selectedDepartureTimeZoneId,
                                arrDT,
                                selectedArrivalTimeZoneId)
                            ? "Arrival must be after departure"
                            : null;
                  });
                },
              ),

              DropdownButtonFormField<int>(
                decoration: const InputDecoration(
                  labelText: "Airline",
                  prefixIcon: Icon(Icons.airlines),
                ),
                items: airlines
                    .map((a) => DropdownMenuItem(
                          value: a.airlineId!,
                          child: Text(a.name ?? ""),
                        ))
                    .toList(),
                onChanged: (v) => selectedAirline = v,
              ),
            ],
          ),
        ),

        actions: [
          TextButton(
            onPressed: () => Navigator.pop(context),
            child: const Text("Cancel"),
          ),

          ElevatedButton(
            child: const Text("Save"),
            onPressed: () async {
              setLocal(() {
               departureLocationError = departureLocation.text.trim().isEmpty
                    ? "Enter a departure location."
                    : null;
                arrivalLocationError = arrivalLocation.text.trim().isEmpty
                    ? "Enter an arrival location."
                    : null;
                departureTimeZoneError = selectedDepartureTimeZoneId == null
                    ? "Select a departure time zone."
                    : null;
                arrivalTimeZoneError = selectedArrivalTimeZoneId == null
                    ? "Select an arrival time zone."
                    : null;
              });

              if (price.text.isEmpty ||
                  depTime.text.isEmpty ||
                  arrTime.text.isEmpty ||
                  selectedAirline == null ||
                  selectedDepartureTimeZoneId == null ||
                  selectedArrivalTimeZoneId == null ||
                  depError != null ||
                  arrError != null ||
                  priceError != null ||
                  departureLocationError != null ||
                  arrivalLocationError != null ||
                  departureTimeZoneError != null ||
                  arrivalTimeZoneError != null) {
                return;
              }

              final departureDate = _tryParseDateTime(depTime.text);
              final arrivalDate = _tryParseDateTime(arrTime.text);

              if (departureDate == null || arrivalDate == null) return;

              final departureUtc =
                  toUtcFromTimeZone(departureDate, selectedDepartureTimeZoneId);
              final arrivalUtc =
                  toUtcFromTimeZone(arrivalDate, selectedArrivalTimeZoneId);

              

              await flightProv.insertAdmin({
                "departureLocation": departureLocation.text.trim(),
                "arrivalLocation": arrivalLocation.text.trim(),
                "price": int.parse(price.text),
                "departureTime": departureUtc.toIso8601String(),
                "arrivalTime": arrivalUtc.toIso8601String(),
                "departureTimeZone": selectedDepartureTimeZoneId,
                "arrivalTimeZone": selectedArrivalTimeZoneId,
                "airlineId": selectedAirline,
              });

              Navigator.pop(context);
              loadFlights();
              showSuccess("Flight successfully added.");
            },
          ),
        ],
      );
    }),
  );
}



  void editFlightDialog(Flight flight) {
    final departureTimeZoneId = _departureTimeZone(flight);
    final arrivalTimeZoneId = _arrivalTimeZone(flight);
    final depTime = TextEditingController(
      text: _formatDateTimeForInput(flight.departureTime, departureTimeZoneId),
    );
    final arrTime = TextEditingController(
      text: _formatDateTimeForInput(flight.arrivalTime, arrivalTimeZoneId),
    );
    final price = TextEditingController(text: flight.price?.toString());
     final departureLocation =
        TextEditingController(text: flight.departureLocation ?? "");
    final arrivalLocation =
        TextEditingController(text: flight.arrivalLocation ?? "");

    String? depError;
    String? arrError;
   String? departureLocationError;
    String? arrivalLocationError;
    String? departureTimeZoneError;
    String? arrivalTimeZoneError;

    int? selectedAirline = flight.airlineId;
    String? selectedDepartureTimeZoneId = flight.departureTimeZone;
    String? selectedArrivalTimeZoneId = flight.arrivalTimeZone;
    final isLocked = flight.stateMachine?.toLowerCase() == "boarding";

    showDialog(
      context: context,
      builder: (_) => StatefulBuilder(builder: (context, setLocal) {
        return AlertDialog(
          title: const Text("Edit Flight"),
          content: SingleChildScrollView(
            child: Column(
              children: [

              if (isLocked)
                Container(
                  padding: const EdgeInsets.all(10),
                  margin: const EdgeInsets.only(bottom: 10),
                  decoration: BoxDecoration(
                    color: Colors.red.shade50,
                    borderRadius: BorderRadius.circular(6),
                    border: Border.all(color: Colors.red),
                  ),
                  child: const Text(
                    "This flight is currently BOARDING and cannot be edited.",
                    style: TextStyle(color: Colors.red, fontWeight: FontWeight.bold),
                  ),
                ),

               TextField(
                controller: departureLocation,
                enabled: !isLocked,
                decoration: InputDecoration(
                 labelText: "Departure location",
                  prefixIcon: const Icon(Icons.flight_takeoff),
                  errorText: departureLocationError,
                ),
                onChanged: (value) {
                  setLocal(() {
                    departureLocationError = value.trim().isEmpty
                        ? "Enter a departure location."
                        : null;
                  });
                },
              ),

               TextField(
                controller: arrivalLocation,
                enabled: !isLocked,
                decoration: InputDecoration(
                  labelText: "Arrival location",
                  prefixIcon: const Icon(Icons.flight_land),
                  errorText: arrivalLocationError,
                ),
                  onChanged: (value) {
                  setLocal(() {
                    arrivalLocationError = value.trim().isEmpty
                        ? "Enter an arrival location."
                        : null;
                  });
                },
              ),

              DropdownButtonFormField<String>(
                value: selectedDepartureTimeZoneId,
                decoration: InputDecoration(
                  labelText: "Departure time zone",
                  prefixIcon: const Icon(Icons.public),
                  errorText: departureTimeZoneError,
                ),
                items: timeZones
                    .map((tz) => DropdownMenuItem(
                          value: tz.timeZoneId,
                          child: Text(tz.displayName ?? tz.timeZoneId ?? ""),
                        ))
                    .toList(),
                onChanged: isLocked
                    ? null
                    : (value) {
                        setLocal(() {
                          selectedDepartureTimeZoneId = value;
                          departureTimeZoneError =
                              value == null ? "Select a departure time zone." : null;
                        });
                      },
              ),

              DropdownButtonFormField<String>(
                value: selectedArrivalTimeZoneId,
                decoration: InputDecoration(
                  labelText: "Arrival time zone",
                  prefixIcon: const Icon(Icons.public),
                  errorText: arrivalTimeZoneError,
                ),
                items: timeZones
                    .map((tz) => DropdownMenuItem(
                          value: tz.timeZoneId,
                          child: Text(tz.displayName ?? tz.timeZoneId ?? ""),
                        ))
                    .toList(),
                onChanged: isLocked
                    ? null
                    : (value) {
                        setLocal(() {
                          selectedArrivalTimeZoneId = value;
                          arrivalTimeZoneError =
                              value == null ? "Select an arrival time zone." : null;
                        });
                      },
              ),

              TextField(
                controller: price,
                enabled: !isLocked,
                keyboardType: TextInputType.number,
                decoration: const InputDecoration(
                  labelText: "Price",
                  prefixIcon: Icon(Icons.price_change),
                ),
              ),

              TextField(
                controller: depTime,
                readOnly: true,
                enabled: !isLocked,
                decoration: InputDecoration(
                  labelText: "Departure Time",
                  prefixIcon: const Icon(Icons.access_time),
                  errorText: depError,
                ),
                onTap: () async {
                  if (isLocked) return;

                  await pickDateTime(depTime);
                 final dt = _tryParseDateTime(depTime.text);
                 final arrDT = _tryParseDateTime(arrTime.text);

                  setLocal(() {
                    depError = (dt == null || _isBeforeToday(dt))
                        ? "Departure cannot be in the past"
                        : null;
                        arrError = _isArrivalBeforeDeparture(
                            dt,
                            selectedDepartureTimeZoneId,
                            arrDT,
                            selectedArrivalTimeZoneId)
                        ? "Arrival must be after departure"
                        : null;
                  });
                },
              ),

              TextField(
                controller: arrTime,
                readOnly: true,
                enabled: !isLocked,
                decoration: InputDecoration(
                  labelText: "Arrival Time",
                  prefixIcon: const Icon(Icons.timer),
                  errorText: arrError,
                ),
                onTap: () async {
                  if (isLocked) return;

                  await pickDateTime(arrTime);

                  final depDT = _tryParseDateTime(depTime.text);
                  final arrDT = _tryParseDateTime(arrTime.text);

                  setLocal(() {
                    arrError =
                         _isArrivalBeforeDeparture(
                                depDT,
                                selectedDepartureTimeZoneId,
                                arrDT,
                                selectedArrivalTimeZoneId)
                            ? "Arrival must be after departure"
                            : null;
                  });
                },
              ),

              DropdownButtonFormField<int>(
                value: selectedAirline,
                decoration: const InputDecoration(
                  labelText: "Airline",
                  prefixIcon: Icon(Icons.airlines),
                ),
                items: airlines
                    .map((a) => DropdownMenuItem(
                          value: a.airlineId!,
                          child: Text(a.name ?? ""),
                        ))
                    .toList(),
                onChanged: isLocked ? null : (v) => selectedAirline = v,
              ),
            ],
          ),
        ),

        actions: [
          TextButton(
            child: const Text("Cancel"),
            onPressed: () => Navigator.pop(context),
          ),

          ElevatedButton(
            child: const Text("Save"),
            onPressed: isLocked
                ? null
                : () async {
                   setLocal(() {
                       departureLocationError = departureLocation.text.trim().isEmpty
                          ? "Enter a departure location."
                          : null;
                      arrivalLocationError = arrivalLocation.text.trim().isEmpty
                          ? "Enter an arrival location."
                          : null;
                      departureTimeZoneError = selectedDepartureTimeZoneId == null
                          ? "Select a departure time zone."
                          : null;
                      arrivalTimeZoneError = selectedArrivalTimeZoneId == null
                          ? "Select an arrival time zone."
                          : null;
                    });

                   if (depError != null ||
                        arrError != null ||
                        selectedDepartureTimeZoneId == null ||
                        selectedArrivalTimeZoneId == null ||
                        departureLocationError != null ||
                        arrivalLocationError != null ||
                        departureTimeZoneError != null ||
                        arrivalTimeZoneError != null) {
                      return;
                    }

                    final departureDate = _tryParseDateTime(depTime.text);
                    final arrivalDate = _tryParseDateTime(arrTime.text);

                    if (departureDate == null || arrivalDate == null) return;

                    final departureUtc =
                        toUtcFromTimeZone(departureDate, selectedDepartureTimeZoneId);
                    final arrivalUtc =
                        toUtcFromTimeZone(arrivalDate, selectedArrivalTimeZoneId);

                    await flightProv.update(flight.flightId!, {
                     "departureLocation": departureLocation.text.trim(),
                      "arrivalLocation": arrivalLocation.text.trim(),
                      "price": int.tryParse(price.text),
                      "departureTime": departureUtc.toIso8601String(),
                      "arrivalTime": arrivalUtc.toIso8601String(),
                      "departureTimeZone": selectedDepartureTimeZoneId,
                      "arrivalTimeZone": selectedArrivalTimeZoneId,
                      "airlineId": selectedAirline,
                    });

                    Navigator.pop(context);
                    loadFlights();
                    showSuccess("Flight updated successfully.");
                  },
          ),
        ],
      );
    }),
  );
}


  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        TabBar(
          controller: tabController,
          labelColor: Colors.blue,
          tabs: const [
            Tab(text: "Flights"),
            Tab(text: "Airlines"),
            Tab(text: "Airports"),
          ],
        ),
        Expanded(
          child: TabBarView(
            controller: tabController,
            children: [
              buildFlights(),
              buildAirlines(),
              buildAirports(),
            ],
          ),
        ),
      ],
    );
  }

  Widget buildFlights() {
    if (loadingFlights) return const Center(child: CircularProgressIndicator());

    return ListView(
      children: [
        const SizedBox(height: 10),

        Align(
          alignment: Alignment.topRight,
          child: Padding(
            padding: const EdgeInsets.only(right: 12),
            child: ElevatedButton.icon(
              icon: const Icon(Icons.add),
              label: const Text("Add Flight"),
              onPressed: addFlightDialog,
            ),
          ),
        ),

        const SizedBox(height: 10),

        buildDaySection("Today"),
        buildDaySection("Tomorrow"),
        buildDaySection("In 2 Days"),
        buildDaySection("In 3 Days"),
        buildDaySection("In 4 Days"),
        buildDaySection("In 5 Days"),

        const Divider(thickness: 2),
        const SizedBox(height: 10),

        buildDaySection("Completed", completed: true),
      ],
    );
  }

  Widget buildDaySection(String label, {bool completed = false}) {
    final list = groupedFlights[label] ?? [];

    return ExpansionTile(
      initiallyExpanded: label == "Today",
      title: Text(
        "$label (${list.length})",
        style: const TextStyle(fontSize: 18, fontWeight: FontWeight.bold),
      ),
      children: list.map((f) {
       final departureTimeZoneId = _departureTimeZone(f);
        final arrivalTimeZoneId = _arrivalTimeZone(f);
        final duration = calculateDurationWithTimeZones(
          f.departureTime,
          departureTimeZoneId,
          f.arrivalTime,
          arrivalTimeZoneId,
        );
        return Card(
          margin: const EdgeInsets.symmetric(horizontal: 12, vertical: 6),
          shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(12)),
          elevation: 3,
          child: ListTile(
            contentPadding: const EdgeInsets.all(16),

            title: Row(
              children: [
                const Icon(Icons.flight_takeoff, color: Colors.blue, size: 22),
                const SizedBox(width: 8),
                Text(
                  "${f.departureLocation} → ${f.arrivalLocation}",
                  style: const TextStyle(
                    fontSize: 18,
                    fontWeight: FontWeight.bold,
                  ),
                ),
              ],
            ),

            subtitle: Padding(
              padding: const EdgeInsets.only(top: 12),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [

                  Row(
                    children: [
                      const Icon(Icons.access_time, color: Colors.black54, size: 20),
                      const SizedBox(width: 6),
                      const Text("Departure time: ", style: TextStyle(fontWeight: FontWeight.bold)),
                       Text(formatDateInTimeZone(f.departureTime, departureTimeZoneId)),
                    ],
                  ),
                  const SizedBox(height: 6),

                  Row(
                    children: [
                      const Icon(Icons.timer, color: Colors.black54, size: 20),
                      const SizedBox(width: 6),
                      const Text("Arrival time: ", style: TextStyle(fontWeight: FontWeight.bold)),
                      Text(formatDateInTimeZone(f.arrivalTime, arrivalTimeZoneId)),
                    ],
                  ),
                  const SizedBox(height: 6),

                   if (duration != null) ...[
                    Row(
                      children: [
                        const Icon(Icons.timelapse, color: Colors.black54, size: 20),
                        const SizedBox(width: 6),
                        const Text("Duration: ", style: TextStyle(fontWeight: FontWeight.bold)),
                        Text(formatDuration(duration)),
                      ],
                    ),
                    const SizedBox(height: 6),
                  ],
                  
                  Row(
                    children: [
                      const Icon(Icons.airlines, color: Colors.black54, size: 20),
                      const SizedBox(width: 6),
                      Text(f.airline?.name ?? "-"),
                    ],
                  ),
                  const SizedBox(height: 6),

                  Row(
                    children: [
                      const Icon(Icons.price_change, color: Colors.black54, size: 20),
                      const SizedBox(width: 6),
                      Text("${f.price ?? 'N/A'} KM"),
                    ],
                  ),

                  const SizedBox(height: 6),

                  Row(
                    children: [
                      const Icon(Icons.flight_takeoff, color: Colors.black54, size: 20),
                      const SizedBox(width: 6),
                      const Text("Flight status: ", style: TextStyle(fontWeight: FontWeight.bold)),
                      Text(f.stateMachine ?? "-"),
                    ],
                  ),
                ],
              ),
            ),

            trailing: completed
                ? const Icon(Icons.check_circle, color: Colors.green, size: 28)
                : Row(
                    mainAxisSize: MainAxisSize.min,
                    children: [
                      IconButton(
                        icon: const Icon(Icons.edit, color: Colors.blue),
                        onPressed: () => editFlightDialog(f),
                      ),
                      IconButton(
                      icon: const Icon(Icons.delete, color: Colors.red),
                      onPressed: () async {
                        final ok = await confirmDelete("Do you really want to delete this flight?");
                        if (!ok) return;

                        await flightProv.delete(f.flightId!);
                        loadFlights();
                        showSuccess("Flight deleted successfully.");
                      },
                    ),

                    ],
                  ),
          ),
        );
      }).toList(),
    );
  }

  Widget buildAirlines() {
    if (loadingAirlines) return const Center(child: CircularProgressIndicator());

    return Column(
      children: [
        Align(
          alignment: Alignment.topRight,
          child: ElevatedButton.icon(
            onPressed: addAirlineDialog,
            icon: const Icon(Icons.add),
            label: const Text("Add Airline"),
          ),
        ),

        Expanded(
          child: ListView.builder(
            itemCount: airlines.length,
            itemBuilder: (_, i) {
              final a = airlines[i];
              return Card(
                child: ListTile(
                  title: Text(a.name ?? ""),
                  subtitle: Text(a.country ?? ""),
                  trailing: Row(
                    mainAxisSize: MainAxisSize.min,
                    children: [
                      IconButton(
                        icon: const Icon(Icons.edit, color: Colors.blue),
                        onPressed: () => editAirlineDialog(a),
                      ),
                      IconButton(
                        icon: const Icon(Icons.delete, color: Colors.red),
                        onPressed: () async {
                          final ok = await confirmDelete("Delete airline?");
                          if (!ok) return;

                          await airlineProv.delete(a.airlineId!);
                          loadAirlines();
                          showSuccess("Airline deleted successfully.");

                        },
                      ),
                    ],
                  ),
                ),
              );
            },
          ),
        )
      ],
    );
  }

  Widget buildAirports() {
    if (loadingAirports) return const Center(child: CircularProgressIndicator());

    return Column(
      children: [
        Align(
          alignment: Alignment.topRight,
          child: ElevatedButton.icon(
            onPressed: addAirportDialog,
            icon: const Icon(Icons.add),
            label: const Text("Add Airport"),
          ),
        ),

        Expanded(
          child: ListView.builder(
            itemCount: airports.length,
            itemBuilder: (_, i) {
              final a = airports[i];
              return Card(
                child: ListTile(
                  title: Text(a.name ?? ""),
                  subtitle: Text("${a.city}, ${a.country}"),
                  trailing: Row(
                    mainAxisSize: MainAxisSize.min,
                    children: [
                      IconButton(
                        icon: const Icon(Icons.edit, color: Colors.blue),
                        onPressed: () => editAirportDialog(a),
                      ),
                      IconButton(
                        icon: const Icon(Icons.delete, color: Colors.red),
                        onPressed: () async {
                          final ok = await confirmDelete("Delete airport?");
                          if (!ok) return;

                          await airportProv.delete(a.airportId!);
                          loadAirports();
                          showSuccess("Airport deleted successfully.");

                        },
                      ),
                    ],
                  ),
                ),
              );
            },
          ),
        )
      ],
    );
  }
}
