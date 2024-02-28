using System;
using System.Text;

namespace TP_Roguelike
{
	public class Dungeon
	{
		public static List<Room> Rooms { get; set; }
		public static int NumberOfRooms { get; set; }
        public static Random random = new Random();
		public static int RoomNumber { get; set; }
		public static List<string> Titles { get; set; }
		public static string Title { get; set; }
		public static int IndexOfRoom { get; set; }

		public static void Initialize()
		{
			Rooms = new List<Room>();
			RoomNumber = 1;
            NumberOfRooms = random.Next(4, 10);
			Titles = new List<string>();
			Title = RandomDungeonTitle();
            Console.WriteLine("Welcome to the " + Title + " ! You'll face " + NumberOfRooms + " rooms before the terrible boss, good luck !");
            for (int i = 0; i < NumberOfRooms; i++)
			{
				Rooms.Add(new Room());
			}
            Rooms.Add(new Room("boss"));
			IndexOfRoom = 0;
        }

        public static bool EndOfDungeon(Adventurer adventurer)
		{
			if (adventurer.Characteristics.HealthPoints > 0 && RoomNumber != NumberOfRooms + 2)
			{
				return true;
			} else
			{
				return false;
			}
		}

		public static void DisplayRoom()
		{
            Console.Write("\nROOM N°" + RoomNumber + " : ");
        }

		public static string RandomDungeonTitle()
		{
			Titles.Add("Shadowcrypt");
			Titles.Add("Bloodmoon Catacombs");
			Titles.Add("Cursed Halls of Despair");
			Titles.Add("Serpent’s Den");
			Titles.Add("Whispering Abyss");
			Titles.Add("Forgotten Citadel");
			Titles.Add("Blackthorn Manor");
			Titles.Add("Frostbite Caverns");
			Titles.Add("Doomstone Dungeon");
			Titles.Add("Labyrinth of Shadows");
			int randomIndex = random.Next(0, Titles.Count());
			return Titles[randomIndex];
        }

		public static void EnteringARoom(Adventurer adventurer)
		{
			Rooms[IndexOfRoom].EncounterInRoom.Meet(adventurer);
			IndexOfRoom++;
		}
    }
}

