using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HelloUserWeb.Models;

namespace HelloUserWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

        [HttpPost]
        public IActionResult Welcome(string username, string password)
        {
            if (username == "saif" && password == "123")
            {
                return Content($"Hello {username}, Welcome to Saif’s App!");
            }
            else
            {
                return Content("Invalid login credentials.");
            }
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
