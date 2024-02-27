using System;
namespace TP_Roguelike
{
    public class Trap : Encounter
    {
        public override void Meet(Adventurer adventurer)
        {
            RemoveHP remove = new RemoveHP();
            remove.Trigger(adventurer.Characteristics);
            Console.WriteLine("Hero encouters a Trap ! Result : \n\tHero : " + adventurer.Characteristics.HealthPoints + "(- ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("10 HP");
            Console.ResetColor();
            Console.WriteLine(")");
        }
    }
}

