namespace Together.Application.Services;

public class EventService : IEventService
{
    public EventAddResult add(string name, string coordinator, string place, float lat, float lng, int fee)
    {
        return new EventAddResult(Guid.NewGuid(), name, coordinator,place, lat, lng, fee);
    }

    public EventQueryResult[] query(float lat, float lng, float len)
    {
        EventQueryResult result = new("name","coor","tpe",4.0f,5.0f,600);
        EventQueryResult[] results = [result, result];
        return results;
    }
}