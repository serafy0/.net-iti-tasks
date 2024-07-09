namespace task_2;

class Program
{
    static void Main(string[] args)
    {
        // Point3D P = new Point3D(10, 10, 10);
        // Console.WriteLine(P.ToString());
        // string castedString = (string)P;
        // Console.WriteLine(castedString);
        Point3D P1 = new Point3D(1, 2, 3);
        Point3D P2 = new Point3D(1, 2, 3);

        Console.WriteLine(P1 == P2);
        Console.WriteLine(P1 != P2);
        if (P1.Equals(P2))
        {
            Console.WriteLine("EQ");
        }
        else
        {
            Console.WriteLine("NEQ");
        }

        Point3D p1 = addPointFromUser();
        Point3D p2 = addPointFromUser();

        Point3D p3 = addPointFromUser();

        Point3D[] arr = [p1, p2, p3];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"point#{i}");
            Console.WriteLine(arr[i].ToString());
        }
    }

    static Point3D addPointFromUser()
    {
        int newCoardX,
            newCoardY,
            newCoardZ;
        addCoard(out newCoardX);
        addCoard(out newCoardY);
        addCoard(out newCoardZ);

        Point3D newPoint = new(newCoardX, newCoardY, newCoardZ);
        return newPoint;
    }

    static void addCoard(out int newCoard)
    {
        bool isValid;
        do
        {
            isValid = int.TryParse(Console.ReadLine(), out newCoard);
        } while (!isValid);
    }
}
