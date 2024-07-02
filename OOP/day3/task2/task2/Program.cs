namespace task2;

class Program
{
    static void Main(string[] args)
    {
        Employee[] arr = [new Employee(), new Employee(), new Employee()];
        arr[0].setSNN("0");
        arr[0].setSalary(1000);
        arr[0].setSNN("1");
        arr[0].setSalary(2000);

        arr[0].setSNN("2");
        arr[0].setSalary(3000);

        Console.WriteLine(arr[0].toString());
        Console.WriteLine(arr[1].toString());
        Console.WriteLine(arr[2].toString());
    }
}
