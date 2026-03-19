namespace Together.Application.Services;

public interface IEventService
{
    EventAddResult add(string name, string coordinator, string place, float lat, float lng, int fee);
    EventQueryResult[] query(float lat, float lng, float len);
}