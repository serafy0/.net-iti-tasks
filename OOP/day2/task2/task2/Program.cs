namespace task2;

class Program
{
    static void Main(string[] args)
    {
        ///4- array of 3 rows,4 cols read and write   int[,]arr=new int[3,4];
            int[,]  arr = new int[3,4];
            for (int i = 0; i < arr.GetLength(0); i++)
            {   
            Console.WriteLine($"enter row number {i}");
               for (int j = 0; j < arr.GetLength(1); j++)
               {
                   Console.WriteLine($"Enter # at index {i},{j}");
                   arr[i, j] = int.Parse(Console.ReadLine());
               }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
               for (int j = 0; j < arr.GetLength(1); j++)
               {
                   Console.Write($"{arr[i, j]} \t");
               }
               Console.WriteLine();
            }
}
}
