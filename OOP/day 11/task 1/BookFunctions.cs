using System.Text;

namespace task_1;

public class BookFunctions
{
    public static string GetTitle(Book B)
    {
        return B.Title;
    }

    public static string GetAuthors(Book B)
    {
        // string.Join(", ", B.Authors);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < B.Authors.Length - 1; i++)
        {
            sb.Append(B.Authors[i]);
            sb.Append(", ");
        }
        sb.Append(B.Authors[B.Authors.Length - 1]);

        return sb.ToString();
    }

    public static string GetPrice(Book B)
    {
        return B.Price.ToString();
    }
}
