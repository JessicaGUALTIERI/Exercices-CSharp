using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 De 1 à 1000, afficher les nombres sauf si : 

                    Un nombre est divisible par 3 : afficher “Fizz” ; 

                    Un nombre est divisible par 5 : afficher “Buzz” ; 

                    Un nombre est divisible par 3 et 5 : afficher “FizzBuzz”. 
            */

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Buzz");
                else if (i % 5 == 0)
                    Console.WriteLine("Fizz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}