using System;
namespace TP_API_Animals.Models
{
	public class Animal
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Specie { get; set; }

		public static Animal GetAnimalById(int id)
		{
			return new Animal { Id = 1, Name = "Titi", Specie = "cat" };
		}

		public static int CreateAnimal(string name, string specie)
		{
			Console.WriteLine($"Name : { name }");
            Console.WriteLine($"Specie : {specie}");
			return 9009;
        }

		public static bool DeleteAnimal(int id)
		{
			Console.WriteLine($"Animal n°{ id } has been deleted.");
			return true;
		}
    }
}

