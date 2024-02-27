using System;
namespace TP_Roguelike
{
	public class Monster : Encounter
	{
        public Characteristics Characteristics { set; get; }

        public Monster(Characteristics initCharacteristics)
        {
            Characteristics = initCharacteristics;
        }

        public override void Meet(Adventurer adventurer)
        {
            RemoveHP remove = new RemoveHP();
            Console.WriteLine("Hero encounters a Monster ! Result : ");
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
                    Console.Write("\tMonster : " + Characteristics.HealthPoints + "(- ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(adventurer.Characteristics.Attack);
                    Console.ResetColor();
                    Console.WriteLine(")");
                }
            }
        }
    }
}

