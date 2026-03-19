using Microsoft.AspNetCore.Mvc;

namespace Together.Web.Controllers;
public class EventController:Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
}