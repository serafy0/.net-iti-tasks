namespace task_1;

class Program
{
    static void Main(string[] args)
    {
        GeoShape rect = new Rectangle(3, 4);
        Console.WriteLine(rect.ClacArea());

        GeoShape circle = new Circle(5);
        Console.WriteLine(circle.ClacArea());

        GeoShape square = new Square(5);
        Console.WriteLine(square.ClacArea());

        GeoShape triangle = new Triangle(2, 1);
        Console.WriteLine(triangle.ClacArea());

        GeoShape[] shapes = [rect, circle, square, triangle];
        double sumOfAreas = SumOfAreas(shapes);
        Console.Write(sumOfAreas);
    }

    public static double SumOfAreas(GeoShape[] _shapes)
    {
        double sum = 0;
        for (int i = 0; i < _shapes.Length; i++)
        {
            sum += _shapes[i].ClacArea();
        }
        return sum;
    }
}
