using System;
namespace TP_Roguelike
{
	public class Dungeon
	{
		public static List<Room> Rooms { get; set; }

		public static void Initialize()
		{
			Rooms = new List<Room>();
		}
	}
}

