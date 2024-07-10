namespace task_1;

public class LibraryEngine
{
    public delegate string BookDelegate(Book book);


    public static void ProcessBooks(List<Book> bList, BookDelegate fPtr)
    {
        foreach (Book B in bList)
        {
            Console.WriteLine(fPtr(B));
        }
    }

    public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
    {
        foreach (Book B in bList)
        {
            Console.WriteLine(fPtr(B));
        }
    }
}
