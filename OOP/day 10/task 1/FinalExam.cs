namespace task_1;

class FinalExam : Exam
{
    public FinalExam()
        : base() { }

    public override void ShowExam()
    {
        foreach ((var _q, var _a) in QuestionsMap)
        {
            List<char> alreadyChosen = [];
            Console.WriteLine(_q.ToString());
            char newAns = calcAnswer(_q, _a, alreadyChosen);
            if (_q is MultipleChoiceQuestion)
            {
                alreadyChosen.Add(newAns);
                Console.WriteLine("do you want to add another answer? press Y if you do");
                string doYouWantToContinoue = Console.ReadLine();
                while (alreadyChosen.Count != _q.Choices.Count || doYouWantToContinoue != "Y")
                {
                    newAns = calcAnswer(_q, _a, alreadyChosen);
                    alreadyChosen.Add(newAns);
                    Console.WriteLine("do you want to add another answer? press Y if you do");
                    doYouWantToContinoue = Console.ReadLine();
                }
            }
        }
        Console.WriteLine($"your grade is {FinalGrade}");
    }

    public char calcAnswer(Question _q, List<Answer> _a, List<char> alreadyChosen)
    {
        char ans = _q.getAnswerFromUser(alreadyChosen);
        Console.WriteLine($"your answer was {ans}");
        bool isCorrect = false;

        foreach (var x in _a)
        {
            if (x.Letter == ans)
            {
                FinalGrade += _q.Mark / _a.Count;
                isCorrect = true;
            }
        }
        if (!isCorrect && _a.Count > 1 && alreadyChosen.Count >= 1)
        {
            FinalGrade -= _q.Mark / _a.Count;
        }
        return ans;
    }
}
