using System;
using Workshop_MVC_Project.Models;

namespace Workshop_MVC_Project.Repositories
{
	public interface ITaskRepository
	{
		List<TaskModel> GetTasks();
		void Create(TaskModel task);
        void Edit(TaskModel task);
		TaskModel GetTaskById(int id);
    }
}

