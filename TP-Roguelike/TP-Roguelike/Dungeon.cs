using System;
namespace TP_Roguelike
{
	public class Dungeon
	{
		public static List<Room> Rooms { get; set; }
		public static int NumberOfRooms { get; set; }
        public static Random random = new Random();
		public static int RoomNumber { get; set; }

		public static void Initialize()
		{
			Rooms = new List<Room>();
			RoomNumber = 1;
            NumberOfRooms = random.Next(4, 10);
			for (int i = 0; i < NumberOfRooms; i++)
			{
				Rooms.Add(new Room());
			}
        }

		public static bool EndOfDungeon(Adventurer adventurer)
		{
			if (adventurer.Characteristics.HealthPoints > 0 && RoomNumber != NumberOfRooms + 1)
			{
				return true;
			} else
			{
				return false;
			}
		}

		public static void DisplayRoomNumber()
		{
            Console.WriteLine("\nROOM N°" + RoomNumber);
        }
    }
}

