using System;
namespace TP_Bibliothèque
{
	public class Users
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public List<Book> BorrowedBooks { get; set; }

        public Users(string initLastName, string initFirstName, List<Book> initBorrowedBooks)
		{
			LastName = initLastName;
			FirstName = initFirstName;
			BorrowedBooks = initBorrowedBooks;
		}

		public void DisplayBorrowedBooks()
		{
			Console.WriteLine(LastName + " " + FirstName + " has borrowed : ");
			foreach (Book book in BorrowedBooks)
			{
				Console.WriteLine("\t\"" + book.Title + "\", by " + book.Author + " (" + book.Pages + " p.) - " + book.Genre);
			}
		}
	}
}