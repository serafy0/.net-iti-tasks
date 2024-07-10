namespace task_1;

class Answer
{
    public char Letter { get; set; }
    public string Body { get; set; }

    public Answer(char _letter, string _body)
    {
        Letter = _letter;
        Body = _body;
    }
}
