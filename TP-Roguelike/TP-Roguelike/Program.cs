namespace TP_Roguelike;

class Program
{
    static void Main(string[] args)
    {
        Adventurer hero = new Adventurer(new Characteristics(100, 2, 1));
        Dungeon.Initialize();
        Console.WriteLine(Dungeon.NumberOfRooms);
        while (Dungeon.EndOfDungeon(hero))
        {
            Room room = new Room();
            Dungeon.DisplayRoomNumber();
            room.EncounterInRoom.Meet(hero);
            Dungeon.RoomNumber++;
        }
    }
}

