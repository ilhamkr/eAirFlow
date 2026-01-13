import 'package:intl/intl.dart';
import 'package:timezone/data/latest.dart' as tzdata;
import 'package:timezone/timezone.dart' as tz;

bool _timeZonesInitialized = false;

void ensureTimeZonesInitialized() {
  if (_timeZonesInitialized) return;
  tzdata.initializeTimeZones();
  _timeZonesInitialized = true;
}

tz.Location _safeLocation(String? timeZoneId) {
  ensureTimeZonesInitialized();
  if (timeZoneId == null || timeZoneId.isEmpty) {
    return tz.UTC;
  }

  try {
    return tz.getLocation(timeZoneId);
  } catch (_) {
    return tz.UTC;
  }
}

String formatDateInTimeZone(DateTime? dateTime, String? timeZoneId,
    {String pattern = "yyyy-MM-dd HH:mm"}) {
  if (dateTime == null) return "N/A";
  final location = _safeLocation(timeZoneId);
  final tzDate = tz.TZDateTime.from(dateTime, location);
  final formatted = DateFormat(pattern).format(tzDate);
  return "$formatted (${tzDate.timeZoneName})";
}

Duration? calculateDurationWithTimeZones(
    DateTime? departure,
    String? departureTimeZone,
    DateTime? arrival,
    String? arrivalTimeZone,
    ) {
  if (departure == null || arrival == null) return null;

  final depLocation = _safeLocation(departureTimeZone);
  final arrLocation = _safeLocation(arrivalTimeZone);

  final depTime = tz.TZDateTime.from(departure, depLocation).toUtc();
  final arrTime = tz.TZDateTime.from(arrival, arrLocation).toUtc();

  final diff = arrTime.difference(depTime);
  return diff.isNegative ? diff.abs() : diff;
}

String formatDuration(Duration? duration) {
  if (duration == null) return "";
  final hours = duration.inHours;
  final minutes = duration.inMinutes.remainder(60);
  return "${hours}h ${minutes}m";
}