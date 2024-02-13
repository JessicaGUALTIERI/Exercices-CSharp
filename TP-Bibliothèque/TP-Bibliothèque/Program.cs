namespace TP_Bibliothèque;

class Program
{
    static void Main(string[] args)
    {
        Books book1 = new Books("A day in New York", 206, "Lydia Jones", (Genre)1);
        Books book2 = new Books("A long time ago", 530, "Marie Ruppert", (Genre)3);
        Books book3 = new Books("Indiano Jane", 238, "Olivia Podrigo", (Genre)0);
        Books book4 = new Books("Tons of spiders", 116, "Romana Marco", (Genre)2);
        Books book5 = new Books("Mysteries of Death", 364, "Patty McOnell", (Genre)2);
        Books book6 = new Books("Loving you", 298, "Anabel Morty", (Genre)1);
        Books book7 = new Books("Wish we could turn back time", 219, "Marleyne Duster", (Genre)1);

        DataBase.Initialize(book1);
        DataBase.Initialize(book2);
        DataBase.Initialize(book3);
        DataBase.Initialize(book4);
        DataBase.Initialize(book5);
        DataBase.Initialize(book6);
        DataBase.Initialize(book7);
        DataBase.DisplayBooksTitle();
        DataBase.DisplayBooksAuthor();
        DataBase.DisplayBooksGenre();
        DataBase.DisplayBooksByGenre((Genre)1);


        Users user1 = new Users("Dumas", "Mathias", new List<Books> { book1, book3});
        Users user2 = new Users("Cherrier", "Cyril", new List<Books> { book2, book5, book6 });
        Users user3 = new Users("Gualtieri", "Jessica", new List<Books> { book4, book7 });

        user1.DisplayBorrowedBooks();
        user2.DisplayBorrowedBooks();
        user3.DisplayBorrowedBooks();

    }
}

