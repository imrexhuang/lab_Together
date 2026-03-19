using Together.Application.Common.Interfaces;
using Together.Domain.Entity;

namespace Together.Application.Services;

public class EventService(IEventRepository repository) : IEventService
{
    private readonly IEventRepository repository = repository;
    public EventAddResult add(string name, string coordinator, string place, float lat, float lng, int fee)
    {
        Event e = new()
        {
            Name = name,
            Coordinator = coordinator,
            Place = place,
            Lat = lat,
            Lng = lng,
            Fee = fee
        };
        repository.AddEvent(e);
        return new EventAddResult(Guid.NewGuid(), name, coordinator, place, lat, lng, fee);
    }

    public EventQueryResult[] query(float lat, float lng, float len)
    {
        List<EventQueryResult> results = [];
        foreach(Event r in repository.GetAll())
        {
        EventQueryResult result = new(r.Name, r.Coordinator, r.Place, r.Lat, r.Lng, r.Fee);    
        results.Add(result);
        }
                

        return [.. results];
    }
}