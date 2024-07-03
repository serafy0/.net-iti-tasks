namespace task_1
{
    class Rectangle : GeoShape
    {
        public Rectangle()
        {
            Console.WriteLine("rect def ctor");
        }

        public Rectangle(double _d1, double _d2)
            : base(_d1, _d2)
        {
            Console.WriteLine("rect 2p ctor");
        }

        public override double ClacArea()
        {
            return dim1 * dim2;
        }
    }
}
