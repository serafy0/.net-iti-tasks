namespace task1
{
    class MyCircularQueue : MyQueue
    {
        private int front;

        public void printQueue()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public MyCircularQueue(int _size = 5)
            : base(_size)
        {
            front = -1;
        }

        public int getFront()
        {
            return arr[front];
        }

        public void enqueue(int value) { }

        public bool IsFull()
        {
            return counter == size - 1;
        }

        public bool IsEmpty()
        {
            return (counter == -1);
        }
    }
}
