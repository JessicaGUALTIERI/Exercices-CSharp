using System;
namespace TP_Roguelike
{
	public class RemoveHP : ITriggerable
	{
        public void Trigger(Characteristics victim, Characteristics opponent)
        {
            victim.HealthPoints -= opponent.Attack;
        }

        public void Trigger(Characteristics character)
        {
            character.HealthPoints -= 10;
        }
    }
}

