namespace task_1;

abstract class Exam
{
    public Dictionary<Question, List<Answer>> QuestionsMap { get; set; }
    public double FinalGrade { get; set; }

    public abstract void ShowExam();

    public Exam()
    {
        QuestionsMap = new Dictionary<Question, List<Answer>> { };
        FinalGrade = 0;
    }

    public void addQuestion(Question _question, List<Answer> _answer)
    {
        QuestionsMap.Add(_question, _answer);
    }
}
