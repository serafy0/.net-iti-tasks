using System.Text;

namespace task_1;

class PracticeExam : FinalExam
{
    public PracticeExam()
        : base() { }

    public override void ShowExam()
    {
        base.ShowExam();

        foreach ((var _q, var _a) in QuestionsMap)
        {
            Console.WriteLine(_q.ToString());
            Console.WriteLine("the correct answer(s) was");

            foreach (Answer i in _a)
            {
                StringBuilder sb = new StringBuilder();

                sb.Append(i.Letter);
                sb.Append(") ");
                sb.Append(i.Body);
                sb.Append("\n");

                Console.WriteLine(sb);
            }
        }

        Console.WriteLine($"your practice grade={FinalGrade}");
    }
}
