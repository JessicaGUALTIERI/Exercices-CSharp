namespace TP_Roguelike;

class Program
{
    static void Main(string[] args)
    {
        Adventurer hero = new Adventurer(new Characteristics(100, 2, 1));
        int roomNumber = 1;
        while (hero.Characteristics.HealthPoints > 0)
        {
            Room room = new Room();
            Console.WriteLine("ROOM N°" + roomNumber);
            room.EncounterInRoom.Meet(hero);
            roomNumber++;
            Console.WriteLine();
        }
    }
}

