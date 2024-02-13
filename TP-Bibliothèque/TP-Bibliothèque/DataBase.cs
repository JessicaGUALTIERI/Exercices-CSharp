using System;
namespace TP_Bibliothèque
{
	public class DataBase
	{
		static List<Books> books = new List<Books>();

		public static void Initialize(Books book)
		{
			books.Add(book);
		}

		public static void DisplayBooksTitle()
		{
			Console.WriteLine("All books' titles are :");
			foreach (Books book in books)
			{
				Console.WriteLine("\t" + book.title);
			}
		}

        public static void DisplayBooksAuthor()
        {
            Console.WriteLine("All books' authors are :");
            foreach (Books book in books)
            {
                Console.WriteLine("\t" + book.author);
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
            foreach (Books book in books)
            {
				if (book.genre == genre)
				{
                    Console.WriteLine("\t\"" + book.title + "\", by " + book.author + " (" + book.pages + " p.) - " + book.genre);
                }
            }
        }
    }
}

