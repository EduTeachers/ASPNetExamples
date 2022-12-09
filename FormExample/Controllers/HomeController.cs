using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using FormExample.FormModel;
using FormExample.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FormExample.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        RegisterUserFormModel model = new RegisterUserFormModel();
        return View(model);
    }

    [HttpPost]
    public IActionResult Index(RegisterUserFormModel model)
    {
        UserViewModel user = new UserViewModel()
        {
            Email = model.Email,
            FullName = model.FullName
        };
        return View("Submit", user);
    }
    
    public IActionResult SimpleForm()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult SimpleForm(String fullName)
    {
        Console.WriteLine(fullName);
        return View();
    }
}