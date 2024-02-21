using System.Collections.Generic;

namespace TP_MethodeGenerique;

class Program
{
    static void Main(string[] args)
    {
        // EXERCICE 1
        // Consigne : Faire une méthode générique qui prend en paramètre une liste et qui renvoie un élément aléatoire de la liste
        Title("Exercize 1 : ");
        List<int> listIntEx1 = new List<int> { 12, 13, 14, 15, 16, 17 };
        DisplayList(listIntEx1);
        RandomValuesOfList(listIntEx1);

        Console.WriteLine();

        List<string> listStringEx1 = new List<string> { "coucou", "hello", "bonjour", "hey", "salut" };
        DisplayList(listStringEx1);
        RandomValuesOfList(listStringEx1);

        Console.WriteLine();

        List<float> listFloatEx1 = new List<float> { 1.1f, 1.2f, 1.3f };
        DisplayList(listFloatEx1);
        RandomValuesOfList(listFloatEx1);

        Console.WriteLine();

        // EXERCICE 2
        // Consigne :
        //  Faire 3 classes génériques qui contiennent une List comme attribut (pas de getter ni de setter) et des méthodes Add(T), Get(), Remove() (et si vous voulez GetAndRemove()). Chacune de ses classes ajoute avec Add un élément dans la liste. Ce qui change c'est le Get() et le Remove()

        // 1ère Classe
        Title("Exercize 2 _ 1st Class _ Pick Random Element :");
        PickRandomElement<int> listIntEx2_1 = new PickRandomElement<int>();
        listIntEx2_1.Add(12);
        listIntEx2_1.Add(13);
        listIntEx2_1.Add(14);
        listIntEx2_1.Add(15);
        listIntEx2_1.Add(16);
        listIntEx2_1.Add(17);
        listIntEx2_1.DisplayList();
        int removedIntValueEx2_1 = listIntEx2_1.GetAndRemove();
        Console.Write("The removed value is \"" + removedIntValueEx2_1 + "\" :\n");
        listIntEx2_1.DisplayList();

        Console.WriteLine();

        PickRandomElement<string> listStringEx2_1 = new PickRandomElement<string>();
        listStringEx2_1.Add("hi");
        listStringEx2_1.Add("hello");
        listStringEx2_1.Add("good morning");
        listStringEx2_1.Add("good night");
        listStringEx2_1.Add("yo");
        listStringEx2_1.DisplayList();
        string removedStringValueEx2_1 = listStringEx2_1.GetAndRemove();
        Console.Write("The removed value is \"" + removedStringValueEx2_1 + "\" :\n");
        listStringEx2_1.DisplayList();

        Console.WriteLine();

        // 2ème Classe
        Title("Exercize 2 _ 2nd Class _ Pick First Element :");
        PickFirstElement<int> listIntEx2_2 = new PickFirstElement<int>();
        listIntEx2_2.Add(144);
        listIntEx2_2.Add(1093);
        listIntEx2_2.Add(4);
        listIntEx2_2.Add(530);
        listIntEx2_2.Add(698);
        listIntEx2_2.Add(20);
        listIntEx2_2.DisplayList();
        int removedIntValueEx2_2 = listIntEx2_2.GetAndRemove();
        Console.Write("The removed value is \"" + removedIntValueEx2_2 + "\" :\n");
        listIntEx2_2.DisplayList();

        Console.WriteLine();

        PickFirstElement<string> listStringEx2_2 = new PickFirstElement<string>();
        listStringEx2_2.Add("cat");
        listStringEx2_2.Add("rat");
        listStringEx2_2.Add("bunny");
        listStringEx2_2.DisplayList();
        string removedStringValueEx2_2 = listStringEx2_2.GetAndRemove();
        Console.Write("The removed value is \"" + removedStringValueEx2_2 + "\" :\n");
        listStringEx2_2.DisplayList();

        Console.WriteLine();


        // 3ème Classe
        Title("Exercize 2 _ 3rd Class _ Pick Last Element :");
        PickLastElement<int> listIntEx2_3 = new PickLastElement<int>();
        listIntEx2_3.Add(1);
        listIntEx2_3.Add(2);
        listIntEx2_3.Add(3);
        listIntEx2_3.Add(4);
        listIntEx2_3.Add(5);
        listIntEx2_3.Add(6);
        listIntEx2_3.DisplayList();
        int removedIntValueEx2_3 = listIntEx2_3.GetAndRemove();
        Console.Write("The removed value is \"" + removedIntValueEx2_3 + "\" :\n");
        listIntEx2_3.DisplayList();

        Console.WriteLine();

        PickLastElement<string> listStringEx2_3 = new PickLastElement<string>();
        listStringEx2_3.Add("towel");
        listStringEx2_3.Add("fork");
        listStringEx2_3.Add("tissue");
        listStringEx2_3.Add("computer");
        listStringEx2_3.Add("hair clip");
        listStringEx2_3.Add("tooth brush");
        listStringEx2_3.Add("belt");
        listStringEx2_3.Add("bag");
        listStringEx2_3.DisplayList();
        string removedStringValueEx2_3 = listStringEx2_3.GetAndRemove();
        Console.Write("The removed value is \"" + removedStringValueEx2_3 + "\" :\n");
        listStringEx2_3.DisplayList();

    }

    // EXERCICE 1
    public static void RandomValuesOfList<T>(List<T> list)
    {
        Random random = new Random();
        int indexRandom = random.Next(0, list.Count);
        Console.WriteLine("This is a random element from the list : " + list[indexRandom]);
    }

    public static void DisplayList<T>(List<T> list)
    {
        Console.Write("[ ");
        foreach (T element in list)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine("]");
    }

    public static void Title(string title)
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(title);
        Console.ResetColor();
    }
}

