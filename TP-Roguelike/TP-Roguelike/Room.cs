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

		public Room(string boss)
		{
			EncounterInRoom = new Boss(new Characteristics(Dungeon.random.Next(25, 40), Dungeon.random.Next(4, 7), Dungeon.random.Next(1, 4)));	
		}

		public void GenerateEncounter()
		{
			int randomPercentage = Dungeon.random.Next(1, 101);
			if (randomPercentage <= 50)
			{
				EncounterInRoom = new Monster(new Characteristics(Dungeon.random.Next(10, 21), Dungeon.random.Next(1, 5), Dungeon.random.Next(1, 4)));
			}
			else if (randomPercentage > 50 && randomPercentage <= 85)
			{
				EncounterInRoom = new Item();
			}
			else
			{
				EncounterInRoom = new Trap();
			}
		}
	}
}

