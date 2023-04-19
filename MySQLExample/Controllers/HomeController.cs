using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MySQLExample.Entities;
using MySQLExample.Models;

namespace MySQLExample.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _dbContext;

    public HomeController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        _dbContext.Users.Add(new UserEntity
        {
            FullName = "Test",
            Email = "a@a.cz"
        });
        _dbContext.SaveChanges();
        
        return View();
    }
}