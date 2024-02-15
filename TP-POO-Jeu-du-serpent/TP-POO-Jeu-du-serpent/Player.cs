using System;
using System.Numerics;

namespace TP_POO_Jeu_du_serpent
{
	public class Player
	{
		public string Name { get; set; }
		public int Space { get; set; }

		public Player()
		{
            Console.WriteLine("What's the player's name ?");
            Name = Console.ReadLine();
            Space = 1;
		}

		public void PlayingRound()
		{
			int dice = ThrowDice();
            Console.Write(Name + " [" + Space + "] throws dice : " + dice);
            Space += dice;
			if (Victory())
			{
				Console.WriteLine(" and goes straight to the end !\n\n" + Name + " wins !!! Congrats !!!");
			} else
			{
                if (TheSpaceIsATrap(Space))
                {
                    Console.WriteLine(" and falls in a trap ! Going back to " + Space + "...");
                }
                else if (TheSpaceIsABonus(Space))
                {
                    Console.WriteLine(" and finds a secret way ! Going to " + Space + " !!!");
                }
                else
                {
                    Console.WriteLine(" and goes to the space n°" + Space);
                }
            }
        }

		public int ThrowDice()
		{
            Random random = new Random();
            int dice;
            dice = random.Next(1, 7);
            return dice;
        }

		public bool TheSpaceIsATrap(int space)
		{
			bool result = false;
			switch(space)
			{
				case > 50:
					Space = 25;
					result = true;
					break;
				case 37:
					Space = 12;
					result = true;
					break;
				case 14:
					Space = 7;
					result = true;
					break;
				case 46:
					Space = 33;
					result = true;
					break;
			}
			return result;
		}

        public bool TheSpaceIsABonus(int space)
        {
            bool result = false;
            switch (space)
            {
                case 20:
                    Space = 35;
                    result = true;
                    break;
                case 2:
                    Space = 17;
                    result = true;
                    break;
                case 31:
                    Space = 43;
                    result = true;
                    break;
            }
            return result;
        }

		public bool Victory()
		{
			return Space == 50;
		}
    }
}

