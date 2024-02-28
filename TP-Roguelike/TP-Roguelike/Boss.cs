using System;
namespace TP_Roguelike
{
	public class Boss : Encounter
	{
        public Characteristics Characteristics { set; get; }

        public Boss(Characteristics initCharacteristics)
        {
            Characteristics = initCharacteristics;
        }

        public override void Meet(Adventurer adventurer)
        {
            RemoveHP remove = new RemoveHP();
            Console.WriteLine("You're facing the boss ! Result : ");
            while (adventurer.Characteristics.HealthPoints > 0 && Characteristics.HealthPoints > 0)
            {
                remove.Trigger(adventurer.Characteristics, Characteristics);
                Console.Write("\tHero : " + adventurer.Characteristics.HealthPoints + "(- ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(Characteristics.Attack);
                Console.ResetColor();
                Console.WriteLine(")");
                if (adventurer.Characteristics.HealthPoints > 0)
                {
                    remove.Trigger(Characteristics, adventurer.Characteristics);
                    Console.Write("\tBoss : " + Characteristics.HealthPoints + "(- ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(adventurer.Characteristics.Attack);
                    Console.ResetColor();
                    Console.WriteLine(")");
                }
            }
            if (adventurer.Characteristics.HealthPoints > 0)
            {
                Console.WriteLine("Congratulations, you've defeated the Boss and completed the " + Dungeon.Title + "!");
            } else
            {
                Console.WriteLine("You almost won ! But sadly, the " + Dungeon.Title + " seems to be too dangerous for you...");
            }
        }
    }
}