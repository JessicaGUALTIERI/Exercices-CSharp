namespace TP_Dates;

class Program
{
    static void Main(string[] args)
    {
        Dates dateDuJour = new Dates();
        dateDuJour.AffectDatesParts("15-02-2024");
        dateDuJour.DisplayDate();
    }
}

