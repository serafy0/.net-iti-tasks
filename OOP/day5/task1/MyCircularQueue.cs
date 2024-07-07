namespace task1
{
    class MyCircularQueue : MyQueue
    {
        private int front;

        // counter is inherited
        public MyCircularQueue(int _size = 5)
            : base(_size)
        {
            front = -1;
        }

        public int getFront()
        {
            return arr[front];
        }

        public void enqueue(int value)
        {
            if (IsFull())
            {
                throw new OverflowException("Queue is full");
            }
            if (front < 0)
            {
                front++;
            }
            counter = (counter + 1) % size; //circular formula

            arr[counter] = value;
            Console.WriteLine($"added {value} to index#{counter}");
        }

        public int dequque()
        {
            if (IsEmpty())
            {
                throw new Exception("queue is Empty");
            }

            int value = arr[front];
            if (front == counter)
            {
                front = -1;
                counter = -1;
            }
            else
            {
                front = (front + 1) % size; //circular
            }

            return value;
        }

        public bool IsFull()
        {
            if (front == 0 && counter == this.size - 1)
            {
                return true;
            }
            else if (front == counter + 1) //if front is right behind the rear
            {
                return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            return (front == -1);
        }
    }
}
