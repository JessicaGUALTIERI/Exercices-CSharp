namespace TP_Lambda_SortedList;

class Program
{
    static void Main(string[] args)
    {
        List<int> UnorderedListOfIntegers = new List<int> { 13, 98, 24, 9, 16, 76, 5, 1, 38, 49, 23 };
        Console.WriteLine("Before :");
        DisplayList(UnorderedListOfIntegers);

        List<int> OrderedListOfIntegers = SortMyList(UnorderedListOfIntegers, x => x + 10);
        Console.WriteLine("After (+10) :");
        DisplayList(OrderedListOfIntegers);

        Console.WriteLine();

        List<string> ListOfSingularWords = new List<string> { "animal", "car", "computer", "test", "trouble", "game" };
        Console.WriteLine("Before :");
        DisplayList(ListOfSingularWords);

        List<string> ListOfPluralWords = SortMyList(ListOfSingularWords, x => x + "s");
        Console.WriteLine("After (+ \"s\") :");
        DisplayList(ListOfPluralWords);

    }

    public static List<T> SortMyList<T>(List<T> myList, Func<T, T> sortMethod)
    {
        List<T> toReturn = new List<T>();
        foreach (T element in myList)
        {
            toReturn.Add(sortMethod(element));
        }
        return toReturn;
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

