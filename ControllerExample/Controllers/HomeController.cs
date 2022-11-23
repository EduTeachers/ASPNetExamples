using Microsoft.AspNetCore.Mvc;
using ControllerExample.ViewModels;

namespace ControllerExample.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["MyMessage"] = "Hello, world!";

        ViewBag.MyDiscustingMessage = "Please don't use this ViewBag method!";
        
        BookViewModel book = new BookViewModel()
        {
            Title = "Co jsem řekl své dceři o ekonomii",
            Author = "Janis Varufakis",
            Description =
                "Stručná historie kapitalismu. Co se stane, když se profesor ekonomie, který je zároveň radikálním levicovým politikem, rozhodne své dospívající dceři vysvětlit, jak funguje ekonomika a svět kolem nás?",
            ISBN = "978-80-271-0795-7",
            YearPublished = new DateTime(2013, 1, 1)
        };

        return View(book);
    }
}