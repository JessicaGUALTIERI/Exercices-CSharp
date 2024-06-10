using System;
namespace workshop_final_API.Repositories
{
	public static class AnimalRepository
	{
        public static int GlobalId = 0;

        public static int CreateAnimal(string name, string specie)
        {
            Console.WriteLine("Le " + specie + " '" + name + "' a bien été créé.");
            return GlobalId++;
        }

        public static bool DeleteAnimal(int id)
        {
            Console.WriteLine("L'animal n°" + id + " a bien été supprimé.");
            return true;
        }
    }
}

