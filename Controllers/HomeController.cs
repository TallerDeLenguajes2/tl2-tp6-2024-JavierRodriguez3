using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tl2_tp6_2024_JavierRodriguez3.Models;

namespace tl2_tp6_2024_JavierRodriguez3.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

}
