using System;
namespace TP_Bibliothèque
{
	public class Books
	{
        public string title { get; set; }
        public int pages { get; set; }
        public string author { get; set; }
        public Genre genre { get; set; }

        public Books(string initTitle, int initPages, string initAuthor, Genre initGenre)
        {
            title = initTitle;
            pages = initPages;
            author = initAuthor;
            genre = initGenre;
        }
    }
}

