using System;
using TP_MVCPractice.Models;
using Microsoft.AspNetCore.Mvc;

namespace TP_MVCPractice.Controllers;

public class CategoriesController : Controller
{
	public IActionResult Index()
	{
		return View();
	}

	public IActionResult Edit(int? id)
	{
		var category = new Category { CategoryId = id.HasValue ? id.Value : 0 };
		return View(category);
	}
}

