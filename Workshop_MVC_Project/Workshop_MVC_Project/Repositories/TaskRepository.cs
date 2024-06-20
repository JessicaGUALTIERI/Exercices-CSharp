using System;
using System.Threading.Tasks;
using Workshop_MVC_Project.Database;
using Workshop_MVC_Project.Models;

namespace Workshop_MVC_Project.Repositories
{
	public class TaskRepository : ITaskRepository
	{
        private readonly DatabaseContext? _db;

        public TaskRepository(DatabaseContext db)
        {
            _db = db;
        }

        public List<TaskModel> GetTasks()
        {
            return _db.Tasks. Where(x => x.IsCompleted == false).ToList();
        }

        public TaskModel GetTaskById(int id)
        {
            return _db.Tasks.FirstOrDefault(x => x.Id == id);
        }

        public void Create(TaskModel task)
        {
            _db.Tasks.Add(task);
            _db.SaveChanges();
        }

        public void Edit(TaskModel task)
        {
            TaskModel? taskToComplete = GetTaskById(task.Id);
            if (taskToComplete != null)
            {
                taskToComplete.Title = task.Title;
                taskToComplete.Description = task.Description;
                taskToComplete.IsCompleted = task.IsCompleted;
                taskToComplete.DueDate = task.DueDate;
                _db.SaveChanges();
            }
        }
    }
}

