namespace task_1;

class ChooseOneQuestion : Question
{
    public ChooseOneQuestion(
        List<Answer> _choices,
        string _body,
        int _mark = 0,
        string _header = "choose one"
    )
        : base(_body, _mark, _header)
    {
        Choices = _choices;
    }
}
