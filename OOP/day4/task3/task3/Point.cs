namespace task3
{
    class Point
    {
        int x;
        int y;

        public void SetX(int _x)
        {
            this.x = _x;
        }

        public void SetY(int _y)
        {
            this.y = _y;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public Point()
        {
            x = y = 0;
            Console.WriteLine("Point def ctor");
        }

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
            Console.WriteLine("Point 2p ctor");
        }
    }
}
