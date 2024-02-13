using System;
namespace TP_Bibliothèque
{
	public class DataBase
	{
		static List<Book> books = new List<Book>();

		public static void Initialize(Book book)
		{
			books.Add(book);
		}

		public static void DisplayBooksTitle()
		{
			Console.WriteLine("All books' titles are :");
			foreach (Book book in books)
			{
				Console.WriteLine("\t" + book.Title);
			}
		}

        public static void DisplayBooksAuthor()
        {
            Console.WriteLine("All books' authors are :");
            foreach (Book book in books)
            {
                Console.WriteLine("\t" + book.Author);
            }
        }

        public static void DisplayBooksGenre()
        {
            Console.WriteLine("Books' genre may be :");
			for (int i = 0; i < 4; i++)
			{
				Console.WriteLine("\t" + (Genre)i);
			}
        }

		public static void DisplayBooksByGenre(Genre genre)
		{
			Console.WriteLine("Books from the genre " + genre);
            foreach (Book book in books)
            {
				if (book.Genre == genre)
				{
                    Console.WriteLine("\t\"" + book.Title + "\", by " + book.Author);
                }
            }
        }
    }
}

