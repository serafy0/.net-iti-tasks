namespace task1;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = new int[10];

        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine($"Enter number at index {i}");

            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"max is {getMax(array1)}");
        Console.WriteLine($"min is {getMin(array1)}");

        Console.Write("enter value to search: ");

        int search = int.Parse(Console.ReadLine());

        searchNumber(array1, search);

        bruteForceSort(array1);

        for (int i = 0; i < array1.Length; i++)
        {
            Console.WriteLine($"new sorted #{i} is {array1[i]} ");
        }
    }

    static int getMax(int[] arr)
    {
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        return max;
    }

    static int getMin(int[] arr)
    {
        int min = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
                min = arr[i];
        }
        return min;
    }

    static void searchNumber(int[] arr, int searchValue)
    {
        bool notFound = true;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == searchValue)
            {
                notFound = false;
                Console.WriteLine($"{searchValue} is at index#{i}");
            }
        }
        if (notFound)
        {
            Console.WriteLine($"{searchValue} not found");
        }
    }

    static int[] bruteForceSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        return arr;
    }
}
