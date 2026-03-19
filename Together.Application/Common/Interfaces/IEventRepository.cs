using Together.Domain.Entity;

namespace Together.Application.Common.Interfaces;

public interface IEventRepository
{
    Event[] GetAll();
    void AddEvent(Event e);
}