namespace Together.Contract.Controller;

public record QueryEventRequest(
    float lat, float lng, float length
);