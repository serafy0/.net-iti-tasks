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
            // topOfStack = 0;
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
                // counter++;
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
            for (int i = 0; i < counter; i++)
            {
                int temp = arr[i + 1];
                arr[i + 1] = arr[i];
                arr[i] = temp;
            }
            int value = arr[counter];
            arr[counter] = 0;

            counter--;
            return value;
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
