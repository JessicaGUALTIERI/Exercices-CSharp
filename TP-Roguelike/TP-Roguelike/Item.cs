using System;
namespace TP_Roguelike
{
	public class Item : Encounter
	{
        public override void Meet(Adventurer adventurer)
        {
            AddHP add = new AddHP();
            add.Trigger(adventurer.Characteristics);
        }
    }
}

