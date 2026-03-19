namespace Together.Contract.Controller;
public record AddEventRequest (
    string name,
    string coordinator,
    string place,
    float lat,
    float lng,
    int  fee
);