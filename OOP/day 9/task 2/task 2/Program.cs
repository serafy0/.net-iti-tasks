namespace task_2;

class Program
{
    static void Main(string[] args)
    {
        Point3D P = new Point3D(10, 10, 10);
        Console.WriteLine(P.ToString());
        string castedString = (string)P;
        Console.WriteLine(castedString);
    }
}
