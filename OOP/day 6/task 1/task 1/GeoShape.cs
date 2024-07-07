namespace task_1
{
    abstract class GeoShape
    {
        protected double dim1;
        protected double dim2;

        public GeoShape()
        {
            dim1 = dim2 = 0;
            Console.WriteLine("geo created");
        }

        public GeoShape(double _dim1, double _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
            Console.WriteLine("geo created with 2dim");
        }

        public GeoShape(GeoShape _geoshape)
        {
            this.dim1 = _geoshape.dim1;
            this.dim2 = _geoshape.dim2;
            Console.WriteLine("geo created with 1dim");
        }

        public abstract double ClacArea();
    }
}
