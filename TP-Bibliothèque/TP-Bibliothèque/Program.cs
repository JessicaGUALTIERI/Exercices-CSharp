namespace TP_Bibliothèque;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("A day in New York", 206, "Lydia Jones", Genre.Fiction);
        Book book2 = new Book("A long time ago", 530, "Marie Ruppert", Genre.Historical);
        Book book3 = new Book("Indiano Jane", 238, "Olivia Podrigo", Genre.Adventure);
        Book book4 = new Book("Tons of spiders", 116, "Romana Marco", Genre.Horror);
        Book book5 = new Book("Mysteries of Death", 364, "Patty McOnell", Genre.Horror);
        Book book6 = new Book("Loving you", 298, "Anabel Morty", Genre.Fiction);
        Book book7 = new Book("Wish we could turn back time", 219, "Marleyne Duster", Genre.Fiction);

        DataBase.Initialize();
        DataBase.AddBookToDataBase(book1);
        DataBase.AddBookToDataBase(book2);
        DataBase.AddBookToDataBase(book3);
        DataBase.AddBookToDataBase(book4);
        DataBase.AddBookToDataBase(book5);
        DataBase.AddBookToDataBase(book6);
        DataBase.AddBookToDataBase(book7);
        DataBase.DisplayBooksTitle();
        DataBase.DisplayBooksAuthor();
        DataBase.DisplayBooksGenre();
        DataBase.DisplayBooksByGenre((Genre)1);

        Users user1 = new Users("Dumas", "Mathias", new List<Book> { book1, book3});
        Users user2 = new Users("Cherrier", "Cyril", new List<Book> { book2, book5, book6 });
        Users user3 = new Users("Gualtieri", "Jessica", new List<Book> { book4, book7 });

        user1.DisplayBorrowedBooks();
        user2.DisplayBorrowedBooks();
        user3.DisplayBorrowedBooks();
    }
}

