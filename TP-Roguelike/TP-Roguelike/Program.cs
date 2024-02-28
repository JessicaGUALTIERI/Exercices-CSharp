namespace TP_Roguelike;

class Program
{
    static void Main(string[] args)
    {
        Adventurer hero = new Adventurer(new Characteristics(100, 2, 1));
        Dungeon.Initialize();
        while (Dungeon.EndOfDungeon(hero))
        {
            
            Dungeon.DisplayRoom();
            Dungeon.EnteringARoom(hero);
            Dungeon.RoomNumber++;
        }
    }
}

