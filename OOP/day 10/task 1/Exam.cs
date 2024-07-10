namespace task_1;

abstract class Exam
{
    public Dictionary<Question, List<Answer>> QuestionsMap { get; set; }
    public int FinalGrade { get; set; }

    public abstract void ShowExam();

    public Exam()
    {
        QuestionsMap = new Dictionary<Question, List<Answer>> { };
    }

    public void addQuestion(Question _question, List<Answer> _answer)
    {
        QuestionsMap.Add(_question, _answer);
    }
}
