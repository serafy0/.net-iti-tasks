namespace task3;

class Program
{
    static void Main(string[] args)
    {
        Point point1 = new Point(3, 4);
        Point point2 = new Point(5, 6);

        Rectangle rect1 = new Rectangle();

        Rectangle rect2 = new Rectangle(null, null);
        //build relationship
        rect2.SetUl(point1);
        rect2.SetUl(point2);

        rect2.DrawRect();

        //cancel relationship
        rect2.SetUl(null);
        rect2.SetLR(null);

        //Line l2=new Line(1,2,3,4);
        ////point def ctor start
        ////point def ctor end
        ////line 4p ctor
        //l2.DrawLine();

        //Line l1 = new Line();
        ////point def ctor start
        ////point def ctor end
        ////line def ctor
        ////line des
        ////point dest end
        ////point dest start
    }
}
