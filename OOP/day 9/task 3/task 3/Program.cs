namespace task_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Math.Add(1, 2));
        Console.WriteLine(Math.Subtract(1, 2));
        Console.WriteLine(Math.Multiply(1, 2));
        try
        {
            Console.WriteLine(Math.Divide(1, 0));
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }
}
