namespace task_3;

static class Math
{
    public static double Add(double left, double right)
    {
        return (left + right);
    }

    public static double Subtract(double left, double right)
    {
        return (left - right);
    }

    public static double Multiply(double left, double right)
    {
        return (left * right);
    }

    public static double Divide(double left, double right)
    {
        if (right == 0)
        {
            // throw new Ex
            throw new DivideByZeroException("error");
        }
        return (left / right);
    }
}
