using System;
namespace TP_Bibliothèque
{
	public class Users
	{
		public string lastName { get; set; }
		public string firstName { get; set; }
		public List<Books> borrowedBooks { get; set; }

        public Users(string initLastName, string initFirstName, List<Books> initBorrowedBooks)
		{
			lastName = initLastName;
			firstName = initFirstName;
			borrowedBooks = initBorrowedBooks;
		}

		public void DisplayBorrowedBooks()
		{
			Console.WriteLine(lastName + " " + firstName + " has borrowed : ");
			foreach (Books book in borrowedBooks)
			{
				Console.WriteLine("\t\"" + book.title + "\", by " + book.author + " (" + book.pages + " p.) - " + book.genre);
			}
		}
	}
}

