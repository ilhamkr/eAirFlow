class PagedResult<T> {
  int count;
  List<T> result;

  PagedResult({
    required this.count,
    required this.result,
  });

  factory PagedResult.fromJson(
      Map<String, dynamic> json, T Function(dynamic) fromJsonT) {
    return PagedResult(
      count: json['count'] ?? 0,
      result: (json['resultList'] as List<dynamic>? ?? [])
          .map((e) => fromJsonT(e))
          .toList(),
    );
  }
}
