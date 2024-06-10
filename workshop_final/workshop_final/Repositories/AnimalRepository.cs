using System;
using workshop_final.Database;

namespace workshop_final.Repositories
{
	public static class AnimalRepository
	{
		public static List<Animal> GetAnimals()
		{
            List<Animal> animals;
            using (var context = new AppDbContext())
            {
                animals = context.Animals.Where(x => x.IsBooked == false).ToList();
            }
            DisplayAnimals(animals);
            return animals;
        }

        public static void DisplayAnimals(List<Animal> animals)
        {
            if (animals != null)
            {
                List<Specie> species = new List<Specie>();
                using (var context = new AppDbContext())
                {
                    species = context.Species.ToList();
                }
                Console.WriteLine("----Identifiant-----------------Nom----------------------------Espèce-------------");
                foreach (Animal animal in animals)
                {
                    Specie? specie = species.FirstOrDefault(x => x.Id == animal.SpecieId);
                    Console.WriteLine("|\t" + animal.Id + "\t\t | \t" + animal.Name + "\t\t | \t\t" + specie.Name + "\t\t |");
                }
                Console.WriteLine("----------------------------------------------------------------------------------");
            }
        }

        public static void DisplayAnimal(int id)
        {
            if (id >= 0)
            {
                List<Specie> species = new List<Specie>();
                using (var context = new AppDbContext())
                {
                    species = context.Species.ToList();
                }
                Animal animal = GetAnimalById(id);
                Specie? specie = species.FirstOrDefault(x => x.Id == animal.SpecieId);
                Console.WriteLine("----Identifiant-----------------Nom----------------------------Espèce-------------");
                Console.WriteLine("|\t" + animal.Id + "\t\t | \t" + animal.Name + "\t\t | \t\t" + specie.Name + "\t\t |");
                Console.WriteLine("----------------------------------------------------------------------------------");
            }
        }
        public static Animal GetAnimalById(int id)
        {
            if (id >= 0)
            {
                Animal? animal;
                using (var context = new AppDbContext())
                {
                    animal = context.Animals.FirstOrDefault(x => x.Id == id);
                }
                return animal ?? null;
            }
            return null;
        }

        public static void EditAnimalName(int id, string newName)
        {
            if (id >= 0)
            {
                using (var context = new AppDbContext())
                {
                    Animal animal = context.Animals.FirstOrDefault(x => x.Id == id);
                    animal.Name = newName;
                    context.SaveChanges();
                }
            }
        }

        public static void CreateAnimal(string name, string specie)
        {
            Specie specieDb = new Specie();
            using (var context = new AppDbContext())
            {
                specieDb = context.Species.FirstOrDefault(x => x.Name == specie);
            }

            Animal animal = new Animal { Name = name, SpecieId = specieDb.Id };
            using (var context = new AppDbContext())
            {
                context.Animals.Add(animal);
                context.SaveChanges();
            }
        }

        public static void DeleteAnimal(int id)
        {
            using (var context = new AppDbContext())
            {
                Animal animal = context.Animals.FirstOrDefault(x => x.Id == id);
                context.Animals.Remove(animal);
                context.SaveChanges();
            }
        }
	}
}

