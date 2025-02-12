namespace task_2;

class Point3D : Point
{
    public int Z { get; set; }

    //1
    public Point3D(int _x = 0, int _y = 0, int _z = 0)
        : base(_x, _y)
    {
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
            return false;

        if (object.ReferenceEquals(right, this))
            return true;

        if (right.GetType() != this.GetType())
        {
            return false;
        }

        return this.X == right.X && this.Y == right.Y && this.Z == right.Z;
    }

    public static bool operator ==(Point3D right, Point3D left)
    {
        return right.Equals(left);
    }

    public static bool operator !=(Point3D right, Point3D left)
    {
        return !right.Equals(left);
    }
}
