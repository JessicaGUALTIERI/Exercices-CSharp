using System;
using Microsoft.AspNetCore.Mvc;
using TP_MVCPractice.Models;

namespace TP_MVCPractice.Controllers
{
	public class ProductController : Controller
	{
        public IActionResult Index()
        {
            var products = ProductsRepository.GetProducts();
            return View(products);
        }
    }
}

