using System.Net.Quic;
using Microsoft.AspNetCore.Mvc;
using Together.Application.Services;
using Together.Contract.Controller;

namespace Together.Api.Controllers;

[ApiController]
[Route("api")]
public class EventController(IEventService eventService) : ControllerBase
{
    private readonly IEventService eventService = eventService;

    [HttpPost("add-event")]
    public IActionResult AddEvent(AddEventRequest request)
    {
        EventAddResult result = eventService.add(request.name,
        request.coordinator, request.place, request.lat, request.lng, request.fee);
        AddEventResponse response = new(result.Id, result.name,
        result.coordinator, result.place, result.lat, result.lng, result.fee);
        return Ok(response);
    }
    [HttpPost("query-event")]
    public IActionResult QueryEvent(QueryEventRequest request)
    {
        var result = eventService.query(request.lat, request.lng, request.length);
        List<QueryEventResponse> events = [];
        foreach(EventQueryResult r in result)
        {
            QueryEventResponse response = new(r.name, r.coordinator, r.place,r.lat, r.lng, r.fee);
            events.Add(response);
        }
        
        return Ok(events.ToArray());
    }
}