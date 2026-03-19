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

    public IActionResult Add()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Add(string name, string coordinator, string place, float lat, float lng, int fee)
    {
        service.add(name,coordinator,place,lat, lng, fee);
        return new RedirectResult("/Event");
    }
}