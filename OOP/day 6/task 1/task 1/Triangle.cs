namespace task_1
{
    class Triangle : GeoShape
    {
        public Triangle()
            : base() { }

        public Triangle(double _base, double _height)
            : base(_height, _base) { }

        public override double ClacArea()
        {
            return 0.5 * dim1 * dim2;
        }
    }
}
