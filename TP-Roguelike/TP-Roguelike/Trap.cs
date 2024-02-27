using System;
namespace TP_Roguelike
{
    public class Trap : Encounter
    {
        public override void Meet(Adventurer adventurer)
        {
            RemoveHP remove = new RemoveHP();
            remove.Trigger(adventurer.Characteristics);
            Console.WriteLine("Hero encouters a Trap ! Result : \n\tHero : " + adventurer.Characteristics.HealthPoints);
        }
    }
}

