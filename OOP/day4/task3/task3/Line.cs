namespace task3
{
    class Line
    {
        Point start;
        Point end;

        public Line()
        {
            Console.WriteLine("a Line is being created");

            start = new Point();
            end = new Point();
        }

        public Line(int startX, int startY, int endX, int endY)
        {
            Console.WriteLine("a Line is being created");

            start = new Point(startX, startY);
            end = new Point(endX, endY);
        }

        public void DrawLine()
        {
            Console.WriteLine($"Line is being drawn with {start.toString()} and {end.toString()}");
        }
    }
}
