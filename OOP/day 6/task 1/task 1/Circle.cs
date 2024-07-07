namespace task_1
{
    class Circle : GeoShape
    {
        public Circle()
            : base() { }

        public Circle(double _radius)
            : base(_radius, _radius) { }

        public override double ClacArea()
        {
            return Math.PI * dim1 * dim1;
        }
    }
}
