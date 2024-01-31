using System;
using System.Drawing;
using System.Text;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Consignes :
            //      1. Faire une liste de chiffres qui représentent le nombre de points de vie qu'ont des personnages.
            //      2. On fait une requête LINQ pour obtenir seulement les personnages qui ont plus de 0 point de vie
            //      3. Afficher dans une liste seulement les chiffres pairs supérieurs à 10

            // 1.
            List<int> pointsDeVie = new List<int> { 12, 78, 7, 76, -55, 6, 57, 28, 100, 0, -10 };

            // 2.
            IEnumerable<int> pointsDeViePositifs = pointsDeVie.Where(i => i > 0).ToList();

            // 3.
            IEnumerable<int> pointsDeViePairsSuperieursA10 = pointsDeVie.Where(i => i > 10 && i % 2 == 0).ToList();
            foreach (int i in pointsDeViePairsSuperieursA10)
            {
                Console.WriteLine(i);
            }
        }
    }
}