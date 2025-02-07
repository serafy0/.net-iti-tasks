using System.Text;

namespace task_1;

abstract class Question
{
    public string Body { get; set; }
    public int Mark { get; set; }

    public string Header { get; set; }

    public List<Answer> Choices { get; set; }

    public Question(string _body, int _mark = 0, string _header = "")
    {
        Body = _body;
        Mark = _mark;
        Header = _header;
        Choices = [];
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append(Header);
        sb.Append("\n");
        sb.Append(Body);
        sb.Append("\n");

        foreach (Answer i in Choices)
        {
            sb.Append(i.Letter);
            sb.Append(") ");
            sb.Append(i.Body);
            sb.Append("\n");
        }

        return sb.ToString();
    }

    public char getAnswerFromUser(List<char> alreadyChosen)
    {
        bool isValid = false;
        char ans;
        do
        {
            isValid = char.TryParse(Console.ReadLine(), out ans);

            if (isValid)
            {
                foreach (var choice in Choices)
                {
                    if (choice.Letter == ans && !alreadyChosen.Contains(ans))
                    {
                        return ans;
                    }
                    else
                    {
                        isValid = false;
                    }
                }
            }
        } while (!isValid);

        return 'X';
    }
}
