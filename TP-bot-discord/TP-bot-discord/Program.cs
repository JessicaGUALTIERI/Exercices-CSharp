namespace TP_bot_discord;

class Program
{
    static void Main(string[] args)
    {
        Server RAN4 = new Server("RAN 4");
        Channel welcome = new Channel("Welcome", RAN4);

        Bot malcolm = new Bot("Malcom says Welcome", "Welcome here !", welcome);
        malcolm.JoinServer(RAN4);

        User jessixica = new User("Jessixica");
        User cyrilloche = new User("Cyrilloche");
        jessixica.JoinServer(RAN4);
        cyrilloche.JoinServer(RAN4);

        Message message1 = new Message(jessixica, "Welcome everyone on this brand new Discord server !");
        Message message2 = new Message(cyrilloche, "Thanks !");
        Message message3 = new Message(jessixica, "Np !!");
        Message message4 = new Message(cyrilloche, ":D");
        message1.OnPost += malcolm.DisplayMessage;
        message2.OnPost += malcolm.DisplayMessage;
        message3.OnPost += malcolm.DisplayMessage;
        message4.OnPost += malcolm.DisplayMessage;

        message1.Post(welcome);
        message2.Post(welcome);

        RAN4.DisplayServer();
    }
}