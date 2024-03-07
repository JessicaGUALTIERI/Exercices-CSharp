using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstAspDotnetApp.Models;
using FirstAspDotnetApp.ViewModels.Home;

namespace FirstAspDotnetApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        IndexViewModel model = new IndexViewModel("MNS");
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Promo()
    {
        PromoViewModel promo = new PromoViewModel();
        return View(promo);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

