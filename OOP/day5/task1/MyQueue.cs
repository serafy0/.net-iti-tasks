namespace task1
{
    class MyQueue
    {
        protected int[] arr;
        protected int size;
        protected int counter;

        public void printQueue()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public MyQueue(int _size = 5) //defaults to 5
        {
            size = _size;
            arr = new int[size];
            counter = -1;
            Console.WriteLine($"array {size}");
            Console.WriteLine($"counter {counter}");
        }

        public void enqueue(int value)
        {
            if (!IsFull())
            {
                arr[++counter] = value;
                Console.WriteLine($"counter added {arr[counter]} at {counter}");
            }
            else
            {
                throw new OverflowException("queue is full");
            }
        }

        public int dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("queue is empty");
            }
            int temp = arr[0];
            for (int i = 0; i < counter; i++)
            {
                arr[i] = arr[i + 1];
            }

            counter--;
            return temp;
        }

        public bool IsFull()
        {
            return counter == size;
        }

        public bool IsEmpty()
        {
            return (counter == -1);
        }

        public int peek()
        {
            return arr[counter];
        }
    }
}
