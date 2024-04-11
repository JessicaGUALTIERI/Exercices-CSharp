using System;
using System.Text.Json;

namespace TP_juste_prix
{
	public static class Database
	{
        public static List<Game> Games { get; set; } = new List<Game>();

        public static void Initialize()
		{
            Games = new List<Game>();
        }

        public static void DisplayDatabase()
        {
            foreach (Game game in Games)
            {
                Console.WriteLine("Game n°" + game.GameId + " : " + game.Score);
            }
        }

        public static void SerializeGame()
        {
            string jsonString;
            string jsonFileName = "Datas.json";
            string path = AppDomain.CurrentDomain.BaseDirectory + "../../../Datas/" + jsonFileName;
            int count = CountOfList();
            StreamWriter sw = new StreamWriter(path);
            jsonString = JsonSerializer.Serialize(Games);
            sw.WriteLine(jsonString);
            sw.Close();
        }

        public static void DeserializeGame()
        {
            string jsonString = "";
            string jsonFileName = "Datas.json";
            string path = AppDomain.CurrentDomain.BaseDirectory + "../../../Datas/" + jsonFileName;

            StreamReader sr = new StreamReader(path);
            jsonString = sr.ReadLine();
            sr.Close();

            try
            {
                Games = JsonSerializer.Deserialize<List<Game>>(jsonString);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static int CountOfList()
        {
            return Games.Count();
        }
    }
}

