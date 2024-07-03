namespace task1;

class Program
{
    static void Main(string[] args)
    {
        MyQueue teatQueue = new MyQueue(5);

        teatQueue.enqueue(1);
        teatQueue.enqueue(2);
        teatQueue.enqueue(3);

        teatQueue.enqueue(4);
        teatQueue.enqueue(5);
        Console.WriteLine($"peak is at {teatQueue.peek()}");

        teatQueue.dequeue();
        teatQueue.dequeue();

        teatQueue.printQueue();

        MyCircularQueue test2 = new MyCircularQueue(8);
        test2.enqueue(1);
        test2.enqueue(2);
        test2.enqueue(3);

        test2.enqueue(4);
        test2.enqueue(5);
        test2.enqueue(3);

        Console.WriteLine($"peak is at {test2.peek()}");

        test2.dequeue();
        test2.dequeue();

        test2.printQueue();
    }
}
