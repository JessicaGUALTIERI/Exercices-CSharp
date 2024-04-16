using System.Xml;
using static System.Net.WebRequestMethods;

namespace TP_File_WorkingOnDatas;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------- PART ONE --------------");
        string fileName = "ScoresGOT.csv";
        string path = AppDomain.CurrentDomain.BaseDirectory + "../../../datas/" + fileName;
        StreamReader sr = new StreamReader(path);
        string line;
        string[] values;
        double totalSuccessRate = 0;
        double totalScore = 0;
        int numberOfGames = 0;
        while (!sr.EndOfStream)
        {
            line = sr.ReadLine();
            values = line.Split(';');
            double valueInt = 0;
            if (double.TryParse(values[2], out valueInt) && valueInt > 0)
            {
                totalSuccessRate += valueInt;
                numberOfGames++;
            }
            if (double.TryParse(values[3], out valueInt) && valueInt > 0)
            {
                totalScore += valueInt;
            }
        }
        double averageSuccessRate = totalSuccessRate / numberOfGames;
        averageSuccessRate = Math.Round(averageSuccessRate, 2);
        double averageScore = totalScore / numberOfGames;
        averageScore = Math.Round(averageScore, 2);
        Console.WriteLine("[Stats for " + numberOfGames + " games] Average success rate : " + averageSuccessRate + " | Average score : " + averageScore);
        sr.Close();

        Console.WriteLine("\n-------------- PART TWO --------------");
        string xmlFileName = "books.xml";
        string xmlPath = AppDomain.CurrentDomain.BaseDirectory + "../../../datas/" + xmlFileName;
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(xmlPath);

        foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
        {
            XmlNode firstChildNode = node.ChildNodes[0];
            Console.WriteLine(firstChildNode.InnerText);
        }

        Console.WriteLine("\n-------------- PART THREE --------------");
        string urlApi = "https://api.geekdo.com/xmlapi2/";
        XmlDocument xmlDocApi = new XmlDocument();

        Console.Write("[Search by id] - Please enter the id :\n\t\t>>> ");
        string idSearched = "thing?id=" + Console.ReadLine();
        string completeUrlForIdSearch = urlApi + idSearched;
        xmlDocApi.Load(completeUrlForIdSearch);
        XmlNodeList xmlNodeListForIdSearch = xmlDocApi.GetElementsByTagName("name");
        Console.WriteLine(xmlNodeListForIdSearch[0].Attributes["value"].InnerText);

        Console.WriteLine("--------------------------------------------------------------------------------------");

        Console.Write("[Search by string] - Please enter the string :\n\t\t>>> ");
        string stringSearched = "search?query=" + Console.ReadLine();
        string completeUrlForStringSearch = urlApi + stringSearched;
        int countOfResults = 0;
        xmlDocApi.Load(completeUrlForStringSearch);
        foreach (XmlNode node in xmlDocApi.DocumentElement.ChildNodes)
        {
            XmlNode xmlNode = node.ChildNodes[0];
            Console.WriteLine(xmlNode.Attributes["value"].InnerText);
            countOfResults++;
        }
        DisplayCountOfResults(countOfResults);

        Console.WriteLine("--------------------------------------------------------------------------------------");

        Console.Write("[Search by string with details displayed] - Please enter the string :\n\t\t>>> ");
        stringSearched = "search?query=" + Console.ReadLine();
        string completeUrlForStringSearchAndDetails = urlApi + stringSearched;
        countOfResults = 0;
        xmlDocApi.Load(completeUrlForStringSearchAndDetails);
        foreach (XmlNode node in xmlDocApi.DocumentElement.ChildNodes)
        {
            XmlNode xmlNode = node.ChildNodes[0];
            string name = xmlNode.Attributes["value"].InnerText;
            idSearched = "thing?id=" + node.Attributes["id"].InnerText;
            completeUrlForIdSearch = urlApi + idSearched;
            xmlDocApi.Load(completeUrlForIdSearch);
            XmlNodeList xmlNodeListDescription = xmlDocApi.GetElementsByTagName("description");
            string description = xmlNodeListDescription[0].InnerText;
            Console.WriteLine("NAME : " + name + "\nDESCRIPTION :\n" + description + "\n");
            countOfResults++;
        }
        DisplayCountOfResults(countOfResults);

        Console.ReadLine();
    }

    public static void DisplayCountOfResults(int countOfResults)
    {
        if (countOfResults > 0)
            Console.WriteLine("[" + countOfResults + " results]");
        else
            Console.WriteLine("No result.");
    }
}


