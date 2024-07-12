namespace task_1;

class Program
{
    static void Main(string[] args)
    {
        Question question1 = new TrueOrFalseQuestion("is c# object oriented?", 1);

        Question question2 = new ChooseOneQuestion(
            [new Answer('A', "Mostafa"), new Answer('B', "Fareed"), new Answer('C', "Mohamed")],
            "what's your name?",
            1
        );

        Exam ex = new FinalExam();
        ex.addQuestion(question1, [question1.Choices[0]]);

        Console.WriteLine(question2.Choices[1]);
        ex.addQuestion(question2, [question2.Choices[1]]);

        Question question3 = new MultipleChoiceQuestion(
            [
                new Answer('A', "C#"),
                new Answer('B', "CSS"),
                new Answer('C', "Java"),
                new Answer('E', "C++")
            ],
            "Which of these are OPP languages?",
            3
        );
        ex.addQuestion(
            question3,
            [question3.Choices[0], question3.Choices[2], question3.Choices[3]]
        );

        ex.ShowExam();
    }
}
