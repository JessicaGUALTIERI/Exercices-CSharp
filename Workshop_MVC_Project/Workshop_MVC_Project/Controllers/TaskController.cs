using System;
using Microsoft.AspNetCore.Mvc;
using Workshop_MVC_Project.Models;
using Workshop_MVC_Project.Repositories;

namespace Workshop_MVC_Project.Controllers
{
	public class TaskController : Controller
	{
		private readonly ITaskRepository _taskRepository;

		public TaskController(ITaskRepository taskRepository)
		{
			_taskRepository = taskRepository;
		}

		public IActionResult Index()
		{
            List<TaskModel> tasks = _taskRepository.GetTasks();
            return View(tasks);
        }

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(TaskModel task)
		{
			if (ModelState.IsValid)
			{
				_taskRepository.Create(task);
				return RedirectToAction(nameof(Index));
			}
			return View();
		}

        public IActionResult Edit(int id)
        {
			TaskModel task = _taskRepository.GetTaskById(id);
            return View(task);
        }

        [HttpPost]
        public IActionResult Edit(TaskModel task)
        {
            if (ModelState.IsValid)
            {
                _taskRepository.Edit(task);
                return RedirectToAction(nameof(Index));
            }
            return View(task);
        }
    }
}

