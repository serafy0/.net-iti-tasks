namespace task_1;

class FinalExam : Exam
{
    public FinalExam()
        : base() { }

    public override void ShowExam()
    {
        foreach ((var _q, var _a) in QuestionsMap)
        {
            Console.WriteLine(_q.ToString());
        }
    }
}
