namespace TP_SendingMailsBetweenUsers;

class Program
{
    static void Main(string[] args)
    {
        User eleve = new User("mathias.dumas@gmail.com", "Mathias", "Dumas");
        User prof = new User("theo.gamory@gmail.com", "Théo", "Gamory");

        prof.SendMail(eleve);
        eleve.ReadMail();
    }
}

