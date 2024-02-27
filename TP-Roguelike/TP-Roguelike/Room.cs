using System;
namespace TP_Roguelike
{
	public class Room
	{
		public Encounter EncounterInRoom { get; set; }

        public Room()
		{
			GenerateEncounter();
		}

		public void GenerateEncounter()
		{
			Random random = new Random();
			int randomPercentage = random.Next(1, 101);
			if (randomPercentage <= 50)
			{
                EncounterInRoom = new Monster(new Characteristics(random.Next(10, 21), random.Next(1, 6), random.Next(1, 4)));
			} else if (randomPercentage > 50 && randomPercentage <= 85)
			{
				EncounterInRoom = new Item();
			} else
			{
				EncounterInRoom = new Trap();
			}
		}
	}
}

