using System;
using Microsoft.AspNetCore.Mvc;
using TP_MVCPractice.Models;
using TP_MVCPractice.ViewModels;

namespace TP_MVCPractice.Controllers
{
	public class ProductsController : Controller
	{
        public IActionResult Index()
        {
            var products = ProductsRepository.GetProducts(loadCategory: true);
            return View(products);
        }

        public IActionResult Add()
        {
            var productViewModel = new ProductViewModel
            {
                Categories = CategoriesRepository.GetCategories()
            };
            return View(productViewModel);
        }
    }
}

