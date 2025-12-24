import 'package:flutter/material.dart';
import 'package:provider/provider.dart';
import 'providers/user_provider.dart';
import 'screens/login_screen.dart';
import 'utils/timezone_helper.dart';

void main() {
  ensureTimeZonesInitialized();
  runApp(
    MultiProvider(
      providers: [
        ChangeNotifierProvider(create: (_) => UserProvider()),
      ],
      child: const eAirFlowMobileApp(),
    ),
  );
}
final GlobalKey<ScaffoldMessengerState> rootScaffoldMessengerKey =
    GlobalKey<ScaffoldMessengerState>();

class eAirFlowMobileApp extends StatelessWidget {
  const eAirFlowMobileApp({super.key});
  
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'eAirFlow Mobile',
      debugShowCheckedModeBanner: false,
      themeMode: ThemeMode.light,
      scaffoldMessengerKey: rootScaffoldMessengerKey,
      theme: ThemeData(
        useMaterial3: true,
        brightness: Brightness.light,
        scaffoldBackgroundColor: Colors.white,
        canvasColor: Colors.white,
        dialogBackgroundColor: Colors.white,
        cardColor: Colors.white,

        textTheme: const TextTheme(
          bodyLarge: TextStyle(color: Colors.black, decoration: TextDecoration.none),
          bodyMedium: TextStyle(color: Colors.black, decoration: TextDecoration.none),
          bodySmall: TextStyle(color: Colors.black, decoration: TextDecoration.none),
        ),

        colorScheme: ColorScheme.fromSeed(
          seedColor: Colors.blue,
          brightness: Brightness.light,
        ).copyWith(
          surface: Colors.white,
          surfaceTint: Colors.transparent,
          surfaceVariant: Colors.white,

          background: Colors.white,
          onBackground: Colors.black,

          onSurface: Colors.black,
          onSurfaceVariant: Colors.black,

          primaryContainer: Colors.white,
          secondaryContainer: Colors.white,
          tertiaryContainer: Colors.white,

          surfaceContainerLowest: Colors.white,
          surfaceContainerLow: Colors.white,
          surfaceContainer: Colors.white,
          surfaceContainerHigh: Colors.white,
          surfaceContainerHighest: Colors.white,
        ),
      ),


      darkTheme: ThemeData(
        brightness: Brightness.light,
        scaffoldBackgroundColor: Colors.white,
        canvasColor: Colors.white,
        dialogBackgroundColor: Colors.white,
        colorScheme: ColorScheme.fromSeed(
          seedColor: Colors.blue,
          brightness: Brightness.light,
        ).copyWith(
          surface: Colors.white,
          surfaceTint: Colors.transparent,
          background: Colors.white,
        ),
      ),

      home: const MobileLoginScreen(),
    );
  }
}
