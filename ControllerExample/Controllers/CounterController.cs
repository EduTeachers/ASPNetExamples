using Microsoft.AspNetCore.Mvc;

namespace ControllerExample.Controllers;

public class CounterController : Controller
{
    public IActionResult Index(int id)
    {
        ViewData["Counter"] = id;
        
        return View();
    }
}