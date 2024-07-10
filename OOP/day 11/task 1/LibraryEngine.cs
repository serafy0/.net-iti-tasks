namespace task_1;


public class LibraryEngine
{
    public static void ProcessBooks ( List<Book> bList
                       ,/*Pointer To BookFunciton*/ fPtr)
    {
        foreach (Book B in bList)
        {Console.WriteLine(fPtr(B));
} }
 }