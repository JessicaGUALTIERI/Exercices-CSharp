using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace TP_MVCPractice.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}

