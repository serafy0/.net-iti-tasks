using System.Diagnostics;

namespace task3;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch[] s = [new Stopwatch(), new Stopwatch(), new Stopwatch()];
        s[0].Start();
        Console.WriteLine(first(999999999));
        s[0].Stop();
        Console.WriteLine($" took {s[0].Elapsed}");

        s[1].Start();
        Console.WriteLine(second(999999999));
        s[1].Stop();
        Console.WriteLine($" took {s[1].Elapsed}");

        s[2].Start();

        Console.WriteLine(third(999999999));
        s[2].Stop();
        Console.WriteLine($" took {s[2].Elapsed}");
    }

    static double first(int maxNum)
    {
        double counter = 0;
        for (int i = 1; i <= maxNum; i++)
        {
            string numString = i.ToString();

            for (int j = 0; j < numString.Length; j++)
            {
                if (numString[j] == '1')
                {
                    counter++;
                }
            }
        }

        return counter;
    }

    static double second(int maxNum)
    {
        double count = 0;
        for (int i = 1; i <= maxNum; i++)
        {
            int newNumber = i;
            while (newNumber > 0)
            {
                if (newNumber % 10 == 1)
                {
                    count++;
                }
                newNumber /= 10;
            }
        }

        return count;
    }

    public static double third(int maxNum)
    {
        int numberOfDigits = (int)Math.Floor(Math.Log10(maxNum) + 1);

        double count = (Math.Pow(10, numberOfDigits - 1) * numberOfDigits);

        return count;
    }
}
