namespace task_1;

class Program
{
    static void Main(string[] args)
    {
        List<Book> books = Repository.Books;
        // User Defined Delegate Datatype
        LibraryEngine.BookDelegate fPtr1 = BookFunctions.GetTitle;
        LibraryEngine.ProcessBooks(books, fPtr1);

        // BCL Delegates
        Func<Book, string> fPtr2 = new Func<Book, string>(BookFunctions.GetAuthors);
        LibraryEngine.ProcessBooks(books, fPtr2);

        // Anonymous Method (GetISBN)
        LibraryEngine.BookDelegate fPtr3 = (Book book) =>
        {
            return book.ISBN;
        };

        LibraryEngine.ProcessBooks(books, fPtr3);

        // Lambda Expression (GetPublicationDate)
        LibraryEngine.BookDelegate fPtr4 = book => book.PublicationDate.ToString();
        LibraryEngine.ProcessBooks(books, fPtr4);
    }
}
