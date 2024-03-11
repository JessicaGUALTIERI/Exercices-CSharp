namespace TP_Lambda_MusicApp;

class Program
{
    static void Main(string[] args)
    {
        Database.Initialize();
        Database.SearchTitle("Tik");
        Database.SearchGenre("Pop");
        Console.WriteLine();
        Database.SortByNumberOfStreams();
    }
}

