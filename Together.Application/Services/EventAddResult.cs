namespace Together.Application.Services;
public record EventAddResult(
    Guid Id,
    string name,
    string coordinator,
    string place,
    float lat,
    float lng,
    int fee
);