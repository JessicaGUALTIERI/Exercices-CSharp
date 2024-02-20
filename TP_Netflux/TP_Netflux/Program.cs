namespace TP_Netflux;

class Program
{
    static void Main(string[] args)
    {
        TVShow GOT = new TVShow("Game Of Thrones");
        Content GOTS1E1 = new Episode("Winter Is Coming", GOT, 63, 1, 1);
        Content GOTS1E2 = new Episode("The Kingsroad", GOT, 56, 1, 2);
        Content GOTS1E3 = new Episode("Lord Snow", GOT, 57, 1, 3);
        Content GOTS1E4 = new Episode("Cripples, Bastards, and Broken Things", GOT, 56, 1, 4);
        Content GOTS1E5 = new Episode("The Wolf And The Lion", GOT, 55, 1, 5);
        Content GOTS1E6 = new Episode("A Golden Crown", GOT, 55, 1, 6);
        Content GOTS1E7 = new Episode("You Win Or You Die", GOT, 55, 1, 7);
        Content GOTS1E8 = new Episode("The Pointy End", GOT, 59, 1, 8);
        Content GOTS1E9 = new Episode("Baelor", GOT, 56, 1, 9);
        Content GOTS1E10 = new Episode("Fire And Blood", GOT, 52, 1, 10);

        Movie.Initialization();
        Content Inception = new Movie("Inception", 148, "Nolan");
        Content ShutterIsland = new Movie("Shutter Island", 130, "Scorsese");
        Content TheWolfOfWallStreet = new Movie("The Wolf Of Wall Street", 179, "Scorsese");
        Content TheKingsSpeech = new Movie("The King's Speech", 118, "Hooper");

        User user1 = new User("arandommailadress1@gmail.com", "user57000");
        User user2 = new User("arandommailadress2@gmail.com", "user93000");

        GOT.DisplayAllEpisodes();
        Movie.DisplayAllMovies();

        user1.DisplayWatchtime();
        user2.DisplayWatchtime();

        user1.Watch(GOTS1E1);
        user1.Watch(GOTS1E2);
        user1.Watch(GOTS1E3);
        user1.Watch(Inception);
        user1.Watch(TheKingsSpeech);

        user2.Watch(GOTS1E1);
        user2.Watch(GOTS1E2);
        user2.Watch(GOTS1E3);
        user2.Watch(GOTS1E4);
        user2.Watch(GOTS1E5);
        user2.Watch(GOTS1E6);
        user2.Watch(GOTS1E7);
        user2.Watch(GOTS1E8);
        user2.Watch(GOTS1E9);
        user2.Watch(GOTS1E10);

        GOT.DisplayAllEpisodes();
        Movie.DisplayAllMovies();

        user1.DisplayWatchtime();
        user2.DisplayWatchtime();
    }
}

