using System;
namespace TP_POO_exercices_12022024
{
	public class User
	{
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Language { get; set; }
        public DateTime Date { get; set; }

        public User()
        {
            Name = "not provided";
            FirstName = "not provided";
            Language = "FR_fr";
            Date = DateTime.Now;
        }

        public User(string name, string firstName, string language)
        {
            Name = name;
            FirstName = firstName;
            Language = language;
            Date = DateTime.Now;
        }

        public void Display()
        {
            Console.WriteLine(Name + " " + FirstName + " (langue : " + Language + "), profil créé le " + Date);
        }

        public void SetLanguage(string newLanguage)
        {
            Language = newLanguage;
        }
    }
}

