namespace TP_Lambda_SortedList;

class Program
{
    static void Main(string[] args)
    {
        List<int> ListOfIntegers = new List<int> { 13, 98, 24, 9, 16, 76, 5, 1, 38, 49, 23 };
        Console.WriteLine("Before :");
        DisplayList(ListOfIntegers);

        List<int> OrderedListOfIntegers = SortMyList(ListOfIntegers, x => x + 10);
        Console.WriteLine("After :");
        DisplayList(OrderedListOfIntegers);

        Console.WriteLine();

        List<string> ListOfStrings = new List<string> { "animal", "car", "computer" };
        Console.WriteLine("Before :");
        DisplayList(ListOfStrings);

        List<string> OrderedListOfStrings = SortMyList(ListOfStrings, x => x + "s");
        Console.WriteLine("After :");
        DisplayList(OrderedListOfStrings);

    }

    public static List<T> SortMyList<T>(List<T> myList, Func<T, T> sortMethod)
    {
        List<T> newList = new List<T>();

        foreach (T element in myList)
        {
            newList.Add(sortMethod(element));
        }
        return newList;
    }

    public static void DisplayList<T>(List<T> list)
    {
        foreach (T element in list)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

