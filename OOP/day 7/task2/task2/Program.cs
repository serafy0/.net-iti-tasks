namespace task2;

class Program
{
    static void Main(string[] args)
    {
        reverseString("this is a test");
        reverseString("all your base");
        reverseString("Word");
    }

    static void reverseString(string value)
    {
        Console.WriteLine(string.Join(" ", value.Split(" ").Reverse()));
    }
}
