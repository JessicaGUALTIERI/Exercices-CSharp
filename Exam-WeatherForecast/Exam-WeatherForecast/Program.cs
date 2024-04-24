using System.Xml;
using static System.Net.WebRequestMethods;

namespace Exam_WeatherForecast;

class Program
{
    static void Main(string[] args)
    {
        string urlApi = "https://www.infoclimat.fr/public-api/gfs/xml?_ll=49.133333,6.166667&_auth=AhgAF1EvVHYEKQM0UyUFLFY%2BAjcMegcgAX0GZQpvAn8GbVY3Dm5cOlc5WicPIAQyVHlTMF5lADBWPQN7XC5SMwJoAGxROlQzBGsDZlN8BS5WeAJjDCwHIAFrBmEKeQJpBmVWLA5vXDpXOVomDzkENVR4UyxeYAA%2FVjQDZ1w4UjUCZABmUTdUNgR0A35TZQU3VmcCagxhB24BMwZjCm8CYQZiVjEOblw5VyZaPg8%2BBDRUZ1MzXmgAMVY9A3tcLlJIAhIAeVFyVHQEPgMnU34FZFY7AjY%3D&_c=ae40b13fbf9b8d9a501b49d859472f5a";
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load(urlApi);

        XmlNodeList nodeListEcheance = xmlDocument.GetElementsByTagName("echeance");
        List<string> echeances = new List<string>();
        foreach (XmlNode nodeEcheance in nodeListEcheance)
        {
            string echeance = nodeEcheance.Attributes["hour"].InnerText;
            echeances.Add(echeance);
        }

        XmlNodeList nodeListTemperatureSol = xmlDocument.GetElementsByTagName("level");
        List<string> temperaturesSol = new List<string>();
        foreach (XmlNode nodeEcheance in nodeListTemperatureSol)
        {
            string temperature = nodeEcheance.Attributes["val"].Value.ToString();
            if (temperature == "sol")
            {
                string temperatureSol = nodeEcheance.InnerText;
                double temperatureSolInt = double.Parse(temperatureSol);
                temperatureSolInt -= 273.15d; // Operation to convert Kelvin to Celcius
                temperatureSolInt = Math.Round(temperatureSolInt, 2);
                temperaturesSol.Add(temperatureSolInt.ToString());
            }
        }

        for (int i = 0; i < echeances.Count() || i < temperaturesSol.Count(); i++)
            Console.WriteLine("Échéance dans " + echeances[i] + " heures. Température estimée au sol : " + temperaturesSol[i] + "°C.");
    }
}

