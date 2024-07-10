namespace task_1;

class MultipleChoiceQuestion : Question
{
    public MultipleChoiceQuestion(
        List<Answer> _choices,
        string _body,
        int _mark = 0,
        string _header = "choose all that apply"
    )
        : base(_body, _mark, _header)
    {
        Choices = _choices;
    }
}
