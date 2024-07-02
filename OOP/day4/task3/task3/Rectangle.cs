namespace task3
{
    class Rectangle
    {
        Point upperLeft;
        Point lowerRight;

        public void SetUl(Point _upperLeft)
        {
            upperLeft = _upperLeft;
        }

        public void SetLR(Point _lowerRight)
        {
            lowerRight = _lowerRight;
        }

        public Point GetUl()
        {
            return upperLeft;
        }

        public Point GetLr()
        {
            return lowerRight;
        }

        public Rectangle()
        {
            upperLeft = null;
            lowerRight = null;
        }

        public Rectangle(Point _upperLeft, Point _lowerRight)
        {
            upperLeft = _upperLeft;
            lowerRight = _lowerRight;
        }

        public void DrawRect() { }
    }
}
