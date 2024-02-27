using System;
namespace TP_Roguelike
{
	public class AddHP : ITriggerable
	{
        public void Trigger(Characteristics character, Characteristics opponent)
        {
            character.HealthPoints += character.Attack / 2;
            opponent.HealthPoints -= character.Attack / 2;
        }

        public void Trigger(Characteristics character)
        {
            if (character.HealthPoints < 100)
            {
                Random random = new Random();
                character.HealthPoints += random.Next(5, 11);
                Console.WriteLine("Hero finds an item ! Result :\n\tHero : " + character.HealthPoints);
            } else
            {
                Console.WriteLine("Hero finds an item but is already full HP : can't use it !");
            }
        }
    }
}

