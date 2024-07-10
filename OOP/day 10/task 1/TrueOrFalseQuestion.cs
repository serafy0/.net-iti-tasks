namespace task_1;

class TrueOrFalseQuestion : Question
{
    public TrueOrFalseQuestion(string _body, int _mark = 0, string _header = "choose true or false")
        : base(_body, _mark, _header)
    {
        Choices.Add(new Answer('A', "true"));
        Choices.Add(new Answer('B', "false"));
    }
}
