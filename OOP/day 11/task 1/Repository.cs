namespace task_1;

public static class Repository
{
    static List<Book> books;

    public static List<Book> Books
    {
        get
        {
            return new List<Book>()
            {
                new Book("1", "Book Title1", ["Ahmed", "Mohamed"], new DateTime(), 10),
                new Book("2", "Book Title2", ["Khaled", "Karim"], new DateTime(), 10),
                new Book("3", "Book Title3", ["Peter", "ALi"], new DateTime(), 10),
                new Book("4", "Book Title4", ["Samy", "Ramy"], new DateTime(), 10),
            };
        }
    }
}
