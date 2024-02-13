using System;
namespace TP_SendingMailsBetweenUsers
{
	public class User
	{
		public string MailAdress { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public User(string initMail, string initFirstName, string initLastName)
		{
			MailAdress = initMail;
			FirstName = initFirstName;
			LastName = initLastName;
		}

        public void SendMail(User recipient)
        {
            Mail.SenderAdress = MailAdress;
            Mail.RecipientAdress = recipient.MailAdress;
            Mail.Date = DateTime.Now;
            Console.WriteLine("SENDING AN EMAIL");
            Console.Write("Object :  ");
            Mail.Object = Console.ReadLine();
            Console.WriteLine("Content :  ");
            Mail.Content = Console.ReadLine();
            Console.WriteLine("Your email has been successfully sent.");
        }

        public void ReadMail()
        {
            Console.WriteLine("\nEMAIL RECEIVED");
            Console.WriteLine("From : " + Mail.SenderAdress);
            Console.WriteLine("To : " + Mail.RecipientAdress);
            Console.WriteLine("Object : " + Mail.Object);
            Console.WriteLine(Mail.Content);
        }
    }
}

