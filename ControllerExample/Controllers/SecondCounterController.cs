using Microsoft.AspNetCore.Mvc;

namespace ControllerExample.Controllers;

public class SecondCounterController : Controller
{
    [Route("[controller]/{action=Index}/{counter?}")]
    [Route("my-awesome-second-controller")]
    public IActionResult Index(int counter)
    {
        ViewData["Counter"] = counter;
        
        return View();
    }
}