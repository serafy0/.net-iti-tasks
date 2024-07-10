namespace task_1;

class Program
{
    static void Main(string[] args)
    {
        Question test = new TrueOrFalseQuestion("is c# object oriented?", 2);

        Question test2 = new ChooseOneQuestion(
            [new Answer('A', "Mostafa"), new Answer('B', "Fareed"), new Answer('C', "Mohamed")],
            "what's your name?",
            2
        );

        Exam ex = new FinalExam();
        ex.addQuestion(test, [test.Choices[0]]);

        Console.WriteLine(test2.Choices[1]);
        ex.addQuestion(test2, [test2.Choices[1]]);

        ex.ShowExam();
    }
}
