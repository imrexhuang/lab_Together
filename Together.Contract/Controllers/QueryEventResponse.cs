public record QueryEventResponse(
    string? name,
    string? coordinator,
    string? place,
    float lat,
    float lng,
    int fee
);