using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Combien avez-vous de bougies ?");
            int nombreBougiesDebut = int.Parse(Console.ReadLine());
            int nombreBougies = nombreBougiesDebut;
            int reste;
            int nombreTotalBougies = nombreBougies;
            
            while (nombreBougies > 2)
            {
                reste = nombreBougies % 3;
                if (reste == 3)
                {
                    nombreTotalBougies++;
                }
                nombreBougies = nombreBougies / 3;
                nombreTotalBougies += nombreBougies;
            }
            Console.WriteLine("Vous pourrez donc brûler " + nombreTotalBougies + " au total.");
        }
    }
}