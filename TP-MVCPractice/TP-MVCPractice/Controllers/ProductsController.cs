using System;
using Microsoft.AspNetCore.Mvc;
using TP_MVCPractice.Models;

namespace TP_MVCPractice.Controllers
{
	public class ProductsController : Controller
	{
        public IActionResult Index()
        {
            var products = ProductsRepository.GetProducts(loadCategory: true);
            return View(products);
        }
    }
}

