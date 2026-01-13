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

String formatDateInTimeZone(
  DateTime? dateTime,
  String? timeZoneId, {
  String pattern = "yyyy-MM-dd HH:mm",
  bool includeTimeZoneName = true,
}) {
  if (dateTime == null) return "N/A";
  final tzDate = _toTimeZoneDateTime(dateTime, timeZoneId);
  final formatted = DateFormat(pattern).format(tzDate);
  if (!includeTimeZoneName) {
    return formatted;
  }
  return "$formatted (${tzDate.timeZoneName})";
}

tz.TZDateTime _toTimeZoneDateTime(DateTime dateTime, String? timeZoneId) {
  final location = _safeLocation(timeZoneId);
  if (dateTime.isUtc) {
    return tz.TZDateTime.from(dateTime, location);
  }

  return tz.TZDateTime(
    location,
    dateTime.year,
    dateTime.month,
    dateTime.day,
    dateTime.hour,
    dateTime.minute,
    dateTime.second,
    dateTime.millisecond,
    dateTime.microsecond,
  );
}

DateTime toUtcFromTimeZone(DateTime dateTime, String? timeZoneId) {
  final location = _safeLocation(timeZoneId);
  final tzDate = tz.TZDateTime(
    location,
    dateTime.year,
    dateTime.month,
    dateTime.day,
    dateTime.hour,
    dateTime.minute,
    dateTime.second,
    dateTime.millisecond,
    dateTime.microsecond,
  );

  return tzDate.toUtc();
}

Duration? calculateDurationWithTimeZones(
    DateTime? departure,
    String? departureTimeZone,
    DateTime? arrival,
    String? arrivalTimeZone,
    ) {
  if (departure == null || arrival == null) return null;

  final depTime = _toTimeZoneDateTime(departure, departureTimeZone).toUtc();
  final arrTime = _toTimeZoneDateTime(arrival, arrivalTimeZone).toUtc();

  return arrTime.difference(depTime);
}

String formatDuration(Duration? duration) {
  if (duration == null) return "";
  final hours = duration.inHours;
  final minutes = duration.inMinutes.remainder(60);
  return "${hours}h ${minutes}m";
}