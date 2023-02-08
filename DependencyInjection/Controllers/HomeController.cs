using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers;

public class HomeController : Controller
{

    private readonly CounterService _counterService;

    public HomeController(CounterService counterService)
    {
        _counterService = counterService;
    }

    public IActionResult Index()
    {
        ViewData["Count"] = _counterService.Count;
        
        return View();
    }
    
    public IActionResult Count()
    {
        _counterService.Increment();

        return Redirect("/");
    }
}