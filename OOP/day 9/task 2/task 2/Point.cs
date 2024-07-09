namespace task_2;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point()
    {
        X = Y = 0;
    }

    public Point(int _x, int _y)
    {
        X = _x;
        Y = _y;
    }

    public override string ToString()
    {
        return $"({X},{Y})";
    }

    public override bool Equals(object? obj)
    {
        var right = obj as Point;

        if (right is null)
            return false;

        if (object.ReferenceEquals(right, this))
            return true;

        if (right.GetType() != this.GetType())
        {
            return false;
        }

        return this.X == right.X && this.Y == right.Y;
    }

    public static bool operator ==(Point right, Point left)
    {
        return right.Equals(left);
    }

    public static bool operator !=(Point right, Point left)
    {
        return !right.Equals(left);
    }
}
