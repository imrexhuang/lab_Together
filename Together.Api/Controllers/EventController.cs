using Microsoft.AspNetCore.Mvc;
using Together.Contract.Controller;

namespace Together.Api.Controllers;

[ApiController]
[Route("api")]
public class EventController : ControllerBase
{
    [HttpPost("add-event")]
    public IActionResult AddEvent(AddEventRequest request)
    {
        AddEventResponse response = new(Guid.NewGuid(), request.name,
        request.coordinator, request.place, request.lat, request.lng, request.fee);
        return Ok(response);
    }
    [HttpPost("query-event")]
    public IActionResult QueryEvent(QueryEventRequest request)
    {
        QueryEventResponse response = new("name1","coordinator2","place3",4.0f,5.0f,6);
        QueryEventResponse[] events = [response, response, response];
        return Ok(events);
    }
}