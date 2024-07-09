namespace task_2;

class Point3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    //1
    public Point3D(int _x = 0, int _y = 0, int _z = 0)
    {
        X = _x;
        Y = _y;
        Z = _z;
    }

    //2
    public override string ToString()
    {
        return $"x={X}, y={Y}, z={Z}";
    }

    public static explicit operator string(Point3D v)
    {
        return v.ToString();
    }

    public override bool Equals(object? obj)
    {
        var right = obj as Point3D;

        if (right is null)
        {
            return false;
        }

        Console.WriteLine(obj.ToString());

        return this.X == right.X && this.Y == right.Y;
    }
}
