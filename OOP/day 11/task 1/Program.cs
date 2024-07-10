namespace task_1;

class Program
{
    static void Main(string[] args)
    {
        List<Book> books = Repository.Books;
        // User Defined Delegate Datatype
        LibraryEngine.BookDelegate del1 = BookFunctions.GetTitle;
        LibraryEngine.ProcessBooks(books, del1);

        // BCL Delegates
        Func<Book, string> del2 = new Func<Book, string>(BookFunctions.GetAuthors);
        LibraryEngine.ProcessBooks(books, del2);

        // Anonymous Method (GetISBN)
        LibraryEngine.BookDelegate del3 = (Book book) =>
        {
            return book.ISBN;
        };

        LibraryEngine.ProcessBooks(books, del3);

        // Lambda Expression (GetPublicationDate)
        LibraryEngine.BookDelegate del4 = book => book.PublicationDate.ToString();
        LibraryEngine.ProcessBooks(books, del4);
    }
}
