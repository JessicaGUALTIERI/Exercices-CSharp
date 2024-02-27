using System;
namespace TP_Roguelike
{
	public class Adventurer
	{
        public Characteristics Characteristics { set; get; }

		public List<ITriggerable> Abilities { get; set; }

        public Adventurer(Characteristics initCharacteristics)
		{
			Characteristics = initCharacteristics;
		}
	}
}

