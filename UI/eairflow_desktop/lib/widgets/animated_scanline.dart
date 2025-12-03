import 'package:flutter/material.dart';

class AnimatedScanLine extends StatefulWidget {
  final bool active;
  const AnimatedScanLine({super.key, required this.active});

  @override
  State<AnimatedScanLine> createState() => _AnimatedScanLineState();
}

class _AnimatedScanLineState extends State<AnimatedScanLine>
    with SingleTickerProviderStateMixin {

  AnimationController? controller;
  late Animation<double> animation;

  @override
  void initState() {
    super.initState();

    controller = AnimationController(
      vsync: this,
      duration: const Duration(seconds: 3),
    );

    animation = Tween<double>(begin: 0, end: 200).animate(controller!);
  }

  @override
  void dispose() {
    controller?.dispose();
    super.dispose();
  }

  @override
  void didUpdateWidget(covariant AnimatedScanLine oldWidget) {
    super.didUpdateWidget(oldWidget);

    if (widget.active) {
      controller?.repeat(reverse: true);
    } else {
      controller?.stop();
    }
  }

  @override
  Widget build(BuildContext context) {
    if (!widget.active) return const SizedBox.shrink();

    return AnimatedBuilder(
      animation: animation,
      builder: (_, __) {
        return Positioned(
          top: animation.value,
          left: 0,
          right: 0,
          child: Container(
            height: 4,
            color: Colors.redAccent,
          ),
        );
      },
    );
  }
}
