using System;
using System.Diagnostics.Metrics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Source et consignes : https://www.w3resource.com/csharp-exercises/linq/index.php

            /*
              1.Write a program in C# Sharp to show how the three parts of a query operation execute.
                Expected Output:
                The numbers which produce the remainder 0 after divided by 2 are:
                0 2 4 6 8
            */
            Console.WriteLine("Exercise 1.");
            List<int> numbersEx1 = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> numbersDividedBy2And0Remaining = from n in numbersEx1 where n % 2 == 0 select n;
            foreach (int i in numbersDividedBy2And0Remaining)
            {
                Console.Write(i + " ");
            }


            /*
              2. Write a program in C# Sharp to find the +ve numbers from a list of numbers using two where conditions in LINQ Query.
                 Expected Output:
                 The numbers within the range of 1 to 11 are :
                 1 3 6 9 10
            */
            Console.WriteLine("\n\nExercise 2.");
            List<int> numbersEx2 = new List<int> { 10, -3, 1, 50, -12, 6, 12, -9, 3, -16, 9, -87 };
            List<int> orderedNumbersEx2 = numbersEx2.OrderBy(numbersEx2 => numbersEx2).ToList();
            IEnumerable<int> numbersPositiveFrom1To11 = from n in orderedNumbersEx2 where n > 0 && n < 12 select n;
            foreach (int i in numbersPositiveFrom1To11)
            {
                Console.Write(i + " ");
            }


            /*
              3. Write a program in C# Sharp to find the number of an array and the square of each number.
                 Expected Output:
                 { Number = 9, SqrNo = 81 }
                 { Number = 8, SqrNo = 64 }
                 { Number = 6, SqrNo = 36 }
                 { Number = 5, SqrNo = 25 }
            */
            Console.WriteLine("\n\nExercise 3.");
            List<int> numbersEx3 = new List<int> { 9, 8, 6, 5 };
            IEnumerable<int> squareNumbersEx3 = from n in numbersEx3 select n * n;
            int indexOfNumbersEx3 = 0;
            foreach (int i in squareNumbersEx3)
            {
                Console.WriteLine("{ Number = " + numbersEx3[indexOfNumbersEx3] + ", SqrNo = " + i + " }");
                indexOfNumbersEx3++;
            }


            /*
              4. Write a program in C# Sharp to display the number and frequency of a given number from an array.
                 Expected Output:
                 The number and the Frequency are :
                 Number 5 appears 3 times
                 Number 9 appears 2 times
                 Number 1 appears 1 times
                 .......
            */
            Console.WriteLine("\n\nExercise 4.");
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

        }
    }
}