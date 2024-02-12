using System;
namespace TP_calculatrice
{
	public class Calculatrice
	{
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }

        public int Add(int numberOne, int numberTwo)
		{
            NumberOne = numberOne;
            NumberTwo = numberTwo;
			return NumberOne + NumberTwo;
		}

		public int Substract(int numberOne, int numberTwo)
		{
            NumberOne = numberOne;
            NumberTwo = numberTwo;
            return NumberOne - NumberTwo;
        }

        public int Multiply(int numberOne, int numberTwo)
        {
            NumberOne = numberOne;
            NumberTwo = numberTwo;
            return NumberOne * NumberTwo;
        }

        public float Divide(int numberOne, int numberTwo)
        {
            NumberOne = numberOne;
            NumberTwo = numberTwo;
            if (NumberOne == 0 || NumberTwo == 0)
            {
                Console.WriteLine("Division par zéro impossible");
                return 0;
            }
            return (float)NumberOne / NumberTwo;
        }

        public bool IsNotZero()
        {
            return NumberOne != 0 && NumberTwo != 0;
        }
    }
}

