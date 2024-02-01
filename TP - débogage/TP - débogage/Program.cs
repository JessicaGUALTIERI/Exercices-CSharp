Console.WriteLine("Hello, World!");

List<string> lstElements = new List<string>
{
    "Bonjour",
    "Bonsoir",
    "Test"
};

bool isTrue = true;

if (isTrue)
    DisplayElements(lstElements);
else
    Console.WriteLine("Boolean is not true, no display");

Random rand = new Random();
var randomValue = rand.Next(1, 100);

Console.WriteLine("Nombre random {0}", randomValue);

void DisplayElements(List<string> lstElements)
{
    int count = 0;

    foreach (string element in lstElements)
    {
        count++;
        Console.WriteLine("Element n°{0}", count);
        Console.WriteLine("L'elément est {0}", element);
    }
}