namespace TP_File_WorkingOnDatas;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "ScoresGOT.csv";
        string path = AppDomain.CurrentDomain.BaseDirectory + "../../../datas/" + fileName;
        StreamReader sr = new StreamReader(path);
        string line;
        string[] values;
        double totalSuccessRate = 0;
        double totalScore = 0;
        int numberOfGames = 0;
        while (!sr.EndOfStream)
        {
            line = sr.ReadLine();
            values = line.Split(';');
            double valueInt = 0;
            if (double.TryParse(values[2], out valueInt) && valueInt > 0)
            {
                totalSuccessRate += valueInt;
                numberOfGames++;
            }
            if (double.TryParse(values[3], out valueInt) && valueInt > 0)
            {
                totalScore += valueInt;
            }
        }
        double averageSuccessRate = totalSuccessRate / numberOfGames;
        averageSuccessRate = Math.Round(averageSuccessRate, 2);
        double averageScore = totalScore / numberOfGames;
        averageScore = Math.Round(averageScore, 2);
        Console.WriteLine("[Stats for " + numberOfGames + " games] Average success rate : " + averageSuccessRate + " | Average score : " + averageScore);
        sr.Close();
    }
}

