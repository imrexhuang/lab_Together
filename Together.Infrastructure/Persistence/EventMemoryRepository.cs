using Together.Application.Common.Interfaces;
using Together.Domain.Entity;

namespace Together.Infrastructure.Persistence;

public class EventMemoryRepository : IEventRepository
{
    private static readonly List<Event> _events = [];
    public void AddEvent(Event e)
    {
        _events.Add(e);
    }

    public Event[] GetAll()
    {
        //return _events.ToArray(); //舊語法
        return [.. _events]; //C#新語法,JavaScript也有類似語法
    }
}