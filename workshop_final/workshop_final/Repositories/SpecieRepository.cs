using System;
using workshop_final;
using workshop_final.Database;

namespace workshop_final_console.Repositories
{
	public static class SpecieRepository
	{
		public static void CreateSpecie(string name)
		{
            Specie specie = new Specie { Name = name };
            using (var context = new AppDbContext())
            {
                context.Species.Add(specie);
                context.SaveChanges();
            }
        }

        public static List<Specie> GetSpecies()
        {
            List<Specie> species;
            using (var context = new AppDbContext())
            {
                species = context.Species.ToList();
            }
            DisplaySpecies(species);
            return species;
        }

        public static void DisplaySpecies(List<Specie> species)
        {
            if (species != null)
            {
                Console.WriteLine("----Identifiant-----------------Nom---------------");
                foreach (Specie specie in species)
                {
                    Console.WriteLine("|\t" + specie.Id + "\t\t | \t" + specie.Name + "\t\t |");
                }
                Console.WriteLine("--------------------------------------------------");
            }
        }

        public static void EditSpecie(int id, string newName)
        {
            using (var context = new AppDbContext())
            {
                Specie specie = context.Species.FirstOrDefault(x => x.Id == id);
                specie.Name = newName;
                context.SaveChanges();
            }
        }
    }
}

