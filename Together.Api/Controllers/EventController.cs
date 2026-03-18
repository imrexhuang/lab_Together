using Microsoft.AspNetCore.Mvc;

namespace Together.Api.Controllers;

[ApiController]
[Route("api")]
public class EventController:ControllerBase
{
    [Route("add-event")]
    public IActionResult AddEvent()
    {
        return Ok();
    }
    [Route("query-event")]
    public IActionResult QueryEvent()
    {
        return Ok();
    }
}