namespace task1;

public struct HireDate
{
    public int day;
    public int month;
    public int year;

    public int Day
    {
        get { return this.day; }
        set { this.day = value; }
    }
    public int Month
    {
        get { return this.month; }
        set { this.month = value; }
    }
    public int Year
    {
        get { return this.year; }
        set { this.year = value; }
    }

    public HireDate(int d, int m, int y)
    {
        this.day = d;
        this.month = m;
        this.year = y;
    }

    public HireDate(string d, string m, string y)
    {
        this.day = int.Parse(d);
        this.month = int.Parse(m);
        this.year = int.Parse(y);
    }

    public override string ToString()
    {
        return $"{this.day}/{this.month}/{this.year}";
    }
};
