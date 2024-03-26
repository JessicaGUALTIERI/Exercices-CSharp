using Demo_Entity;

using (var context = new TodoDbContext())
{
    var todo = new Todo { Date = DateTime.Now, IsDone = false, Title = "Apprendre React" };
    todo.Create();
    Console.WriteLine("To do list :");
    var todos = context.Todos.ToList();
    todos.ForEach(todo => Console.WriteLine(todo.Title));
    context.SaveChanges();
}