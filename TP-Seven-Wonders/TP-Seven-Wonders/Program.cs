using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SEVEN WONDERS\nCombien avez-vous de ronds ?");
            int nbRonds = int.Parse(Console.ReadLine());
            Console.WriteLine("\nCombien avez-vous de triangles ?");
            int nbTriangles = int.Parse(Console.ReadLine());
            Console.WriteLine("\nCombien avez-vous de carrés ?");
            int nbCarres = int.Parse(Console.ReadLine());

            int totalNbRonds = nbRonds * nbRonds;
            int totalNbTriangles = nbTriangles * nbTriangles;
            int totalNbCarres = nbCarres * nbCarres;

            int min;
            if (nbRonds < nbCarres && nbRonds < nbTriangles)
                min = nbRonds;
            else if (nbCarres < nbRonds && nbCarres < nbTriangles)
                min = nbCarres;
            else
                min = nbTriangles;

            int totalLigne = min * 7;

            int totalJeu = totalLigne + totalNbCarres + totalNbRonds + totalNbTriangles;
            Console.WriteLine("\nVous totalisez un score de " + totalJeu + " !");
        }
    }
}