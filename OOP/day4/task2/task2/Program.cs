namespace task2;

class Program
{
    static void Main(string[] args)
    {
        testValues();

        Complex num1 = readNumberFromUser();
        Complex num2 = readNumberFromUser(2);
        Complex result = Complex.Add(num1, num2);

        Console.WriteLine(result.print());
    }

    public static Complex readNumberFromUser(int number = 1)
    {
        Complex cNum = new Complex();

        Console.WriteLine($"Enter #{number} Complex number");
        Console.WriteLine($"Enter real number");
        cNum.setRealNumber(parseInt());

        Console.WriteLine($"Enter imaginary number");
        cNum.setImaginaryNum(parseInt());

        return cNum;
    }

    public static int parseInt()
    {
        return int.Parse(Console.ReadLine());
    }

    public static void testValues()
    {
        Complex[] arr =
        [
            new Complex(3, 4),
            new Complex(3, -4),
            new Complex(3, 1),
            new Complex(3, -1),
            new Complex(0, 3),
            new Complex(0, -3),
            new Complex(0, 1),
            new Complex(0, -1),
            new Complex(1, 0),
            new Complex(0, 0),
        ];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i].print());
        }
    }
}
