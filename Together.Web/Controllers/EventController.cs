using Microsoft.AspNetCore.Mvc;
using Together.Application.Services;

namespace Together.Web.Controllers;
public class EventController(IEventService service):Controller
{
    private readonly IEventService service=service;
    public IActionResult Index()
    {
        EventQueryResult[] result = service.query(0,0,0);
        return View(result);
    }
    
}