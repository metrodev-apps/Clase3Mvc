using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Clase3Mvc.Models;

namespace Clase3Mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<Team> _teams;

    public HomeController(ILogger<HomeController> logger)
    {        
        _logger = logger;
        _teams = new List<Team>();
    }

    public IActionResult Index()
    {        
        return View();
    }
    
    public IActionResult Teams()
    {
        _teams.Add(new Team(10, "Barcelona"));
        _teams.Add(new Team(12, "Real Madrid"));
        _teams.Add(new Team(13, "Atletico de Madrid"));
        return View(_teams);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
