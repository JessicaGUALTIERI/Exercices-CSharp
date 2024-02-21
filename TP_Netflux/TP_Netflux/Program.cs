namespace TP_Netflux;

class Program
{
    static void Main(string[] args)
    {
        TVShow GOT = new TVShow("Game Of Thrones");
        Episode GOTS1E1 = new Episode("Winter Is Coming", GOT, 63, 1, 1);
        Episode GOTS1E2 = new Episode("The Kingsroad", GOT, 56, 1, 2);
        Episode GOTS1E3 = new Episode("Lord Snow", GOT, 57, 1, 3);
        Episode GOTS1E4 = new Episode("Cripples, Bastards, and Broken Things", GOT, 56, 1, 4);
        Episode GOTS1E5 = new Episode("The Wolf And The Lion", GOT, 55, 1, 5);
        Episode GOTS1E6 = new Episode("A Golden Crown", GOT, 55, 1, 6);
        Episode GOTS1E7 = new Episode("You Win Or You Die", GOT, 55, 1, 7);
        Episode GOTS1E8 = new Episode("The Pointy End", GOT, 59, 1, 8);
        Episode GOTS1E9 = new Episode("Baelor", GOT, 56, 1, 9);
        Episode GOTS1E10 = new Episode("Fire And Blood", GOT, 52, 1, 10);

        Movie.Initialization();
        Movie Inception = new Movie("Inception", 148, "Nolan");
        Movie ShutterIsland = new Movie("Shutter Island", 130, "Scorsese");
        Movie TheWolfOfWallStreet = new Movie("The Wolf Of Wall Street", 179, "Scorsese");
        Movie TheKingsSpeech = new Movie("The King's Speech", 118, "Hooper");

        User user1 = new User("arandommailadress1@gmail.com", "user57000");
        User user2 = new User("arandommailadress2@gmail.com", "user93000");

        GOT.DisplayAllEpisodes();
        Movie.DisplayAllMovies();

        user1.DisplayWatchtime();
        user2.DisplayWatchtime();

        //GOT.Selected(user1);
        //GOT.Selected(user1);
        //GOT.Selected(user2);
        //GOT.Selected(user2);
        //GOT.Selected(user2);
        //GOT.Selected(user2);
        //GOT.Selected(user2);
        //Inception.Selected(user1);
        //TheKingsSpeech.Selected(user1);
        user1.Select(GOT);
        user1.Select(GOT);
        user1.Select(GOT);
        user2.Select(GOT);
        user2.Select(GOT);
        user2.Select(GOT);
        user2.Select(GOT);
        user2.Select(GOT);
        user2.Select(GOT);
 

        GOT.DisplayAllEpisodes();
        Movie.DisplayAllMovies();

        user1.DisplayWatchtime();
        user2.DisplayWatchtime();
    }
}

