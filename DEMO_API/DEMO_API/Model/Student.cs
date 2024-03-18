using System;
namespace DEMO_API.Model
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Promotion Promotion { get; set; }

		public static Student GetStudentById(int id)
		{
			return new Student { Id = id, Name = "Julien", Promotion = new Promotion { Name = "CDA" } };
		}

        public static int CreateStudent(string name, Promotion promotion)
        {
			Console.WriteLine("Name : " + name);
			Console.WriteLine("Promotion : " + promotion);
            return 112;
        }

        public static bool DeleteStudent(int id)
        {
            Console.WriteLine("Student n°" + id + " successfully deleted");
            return true;
        }
    }
}

