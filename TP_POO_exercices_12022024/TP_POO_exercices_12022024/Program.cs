namespace TP_POO_exercices_12022024;

class Program
{
    static void Main(string[] args)
    {
        User eleve = new User("Gualtieri", "Jessica", "FR_fr");
        eleve.Display();
        eleve.SetLanguage("UK_en");
        eleve.Display();
    }
}

