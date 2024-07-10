namespace task_1;

public class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string[] Authors { get; set; }
    public DateTime PublicationDate { get; set; }
    public decimal Price { get; set; }

    public Book(
        string _ISBN,
        string _Title,
        string[] _Authors,
        DateTime _PublicationDate,
        decimal _Price
    )
    {
        ISBN = _ISBN;
        Title = _Title;
        Authors = _Authors;
        PublicationDate = _PublicationDate;
        Price = _Price;
    }

    public override string ToString()
    {
        return $"{ISBN}\n{Title}\n{BookFunctions.GetAuthors(this)}\n{PublicationDate.ToString()}\n{Price}";
    }
}
