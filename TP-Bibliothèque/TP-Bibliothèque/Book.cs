using System;
namespace TP_Bibliothèque
{
	public class Book
	{
        public string Title { get; set; }
        public int Pages { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; }

        public Book(string initTitle, int initPages, string initAuthor, Genre initGenre)
        {
            Title = initTitle;
            Pages = initPages;
            Author = initAuthor;
            Genre = initGenre;
        }
    }
}

