namespace TP_calculatrice;

class Program
{
    static void Main(string[] args)
    {
        Calculatrice calculatrice = new Calculatrice();
        Console.WriteLine(calculatrice.Add(9,3));
        Console.WriteLine(calculatrice.Substract(100,10));
        Console.WriteLine(calculatrice.Multiply(10, 10));
        Console.WriteLine(calculatrice.Divide(100, 10));
        Console.WriteLine(calculatrice.Divide(100, 0));
    }
}

