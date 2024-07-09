namespace task_2;

class Point3D
{
    private int x;
    private int y;
    private int z;

    //1
    public Point3D(int _x = 0, int _y = 0, int _z = 0)
    {
        x = _x;
        y = _y;
        z = _z;
    }

    //2
    public override string ToString()
    {
        return $"x={x}, y={y}, z={z}";
    }

    public static explicit operator string(Point3D v)
    {
        return v.ToString();
    }
}
