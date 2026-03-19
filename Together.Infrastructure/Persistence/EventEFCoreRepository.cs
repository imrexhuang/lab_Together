using Together.Application.Common.Interfaces;
using Together.Domain.Entity;

namespace Together.Infrastructure.Persistence;

public class EventEFCoreRepository : IEventRepository
{
    private readonly EventContext db=new();
    public void AddEvent(Event e)
    {
        db.Add(e);
        db.SaveChanges();
    }

    public Event[] GetAll()
    {
        return [.. db.Events!];
    }
}