namespace task1
{
    class MyDynamicStack
    {
        private int[] arr;
        private int size;
        private int topOfStack;

        public MyDynamicStack(int _size = 5) //defaults to 5
        {
            size = _size;
            topOfStack = 0;
            arr = new int[size];
        }

        public void Push(int value)
        {
            if (!IsFull())
            {
                arr[topOfStack] = value;
                topOfStack++;
            }
            else
            {
                throw new StackOverflowException(
                    "The requested operation caused a stack overflow."
                );
            }
        }

        public int Pop()
        {
            int retVal = -1;
            if (!this.IsEmpty())
            {
                topOfStack--;
                retVal = arr[topOfStack];
                //return retVal;
            }
            else
            {
                throw new StackOverflowException(
                    "The requested operation caused a stack overflow."
                );
            }
            return retVal;
        }

        public bool IsFull()
        {
            return topOfStack == size;
        }

        public bool IsEmpty()
        {
            return topOfStack == 0;
        }
    }
}
