namespace TP_POO_Jeu_du_serpent;

class Program
{
    static void Main(string[] args)
    {
        
        Game.StartingGame();
        Player player1 = new Player();
        Player player2 = new Player();

        Console.WriteLine(player1);

        do
        {
            Game.ResetValues(player1, player2);
            while (!player1.Victory() && !player2.Victory())
            {
                Game.DisplayRound();
                player1.PlayingRound();
                if (!player1.Victory())
                {
                    player2.PlayingRound();
                }
                Game.Round++;
            }

        } while (Game.ReplayAnotherGame());
    }
}