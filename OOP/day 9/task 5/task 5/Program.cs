﻿namespace task_5;

class Program
{
    static void Main(string[] args)
    {
        Duration D1 = new Duration(1, 10, 15);
        Console.WriteLine(D1.ToString());

        Duration D2 = new Duration(3600);
        Console.WriteLine(D2.ToString());

        Duration D3 = new Duration(7800);
        Console.WriteLine(D3.ToString());

        Duration D4 = new Duration(666);
        Console.WriteLine(D4.ToString());

        Duration d1 = D1 + D2;
        Console.WriteLine(d1);

        Console.WriteLine(++d1);
        Console.WriteLine(d1++);
        Console.WriteLine(d1++);

        DateTime Obj = (DateTime)D1;

        Console.WriteLine(Obj);
    }
}
