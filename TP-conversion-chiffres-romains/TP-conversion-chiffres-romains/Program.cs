using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Consigne :
            // Coder un convertisseur où on entre un chiffre romain et on sort un chiffre.

            
            int entierI = 1;
            int entierV = 5;
            int entierX = 10;
            int entierL = 50;
            int entierC = 100;
            int entierD = 500;
            int entierM = 1000;
            int sortie = 0;

            Console.WriteLine("Entrez le chiffre romain à convertir :");
            string chiffreRomain = Console.ReadLine();
            for (int i = 0; i < chiffreRomain.Length; i++)
            {
                if (chiffreRomain[i] == 'I')
                {
                    if (i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'V' || i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'X' || i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'L' || i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'C' || i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'D' || i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'M')
                    {
                        sortie -= entierI;
                    }
                    else
                    {
                        sortie += entierI;
                    }
                }

                if (chiffreRomain[i] == 'V')
                {
                    if (i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'X' || i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'L' || i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'C' || i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'D' || i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'M')
                    {
                        sortie -= entierV;
                    }
                    else
                    {
                        sortie += entierV;
                    }
                }

                if (chiffreRomain[i] == 'X')
                {
                    if (i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'L' || i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'C' || i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'D' || i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'M')
                    {
                        sortie -= entierX;
                    }
                    else
                    {
                        sortie += entierX;
                    }
                }

                if (chiffreRomain[i] == 'L')
                {
                    if (i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'C' || i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'D' || i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'M')
                    {
                        sortie -= entierL;
                    }
                    else
                    {
                        sortie += entierL;
                    }
                }

                if (chiffreRomain[i] == 'C')
                {
                    if (i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'D' || i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'M')
                    {
                        sortie -= entierC;
                    }
                    else
                    {
                        sortie += entierC;
                    }
                }

                if (chiffreRomain[i] == 'D')
                {
                    if (i != (chiffreRomain.Length - 1) && chiffreRomain[i + 1] == 'M')
                    {
                        sortie -= entierD;
                    }
                    else
                    {
                        sortie += entierD;
                    }
                }

                if (chiffreRomain[i] == 'M')
                {
                    sortie += entierM;
                }
            }
            Console.WriteLine("  -> " + sortie);
        }
    }
}