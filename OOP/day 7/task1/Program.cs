using System.Diagnostics;
using System.Security.Principal;

namespace task1;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };

        Console.WriteLine($"max={getMaxDistance(arr) - 1}");

        int[] userInput = takeInput();

        Console.WriteLine($"max={getMaxDistance(userInput) - 1}");
    }

    static int[] takeInput()
    {
        Console.WriteLine("Enter array size");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"add number {i}");
            arr[i] = int.Parse(Console.ReadLine());
        }

        return arr;
    }

    static int getMaxDistance(int[] arr)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        int max = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (dic.ContainsKey(arr[i]))
            {
                if (max < (i - dic[arr[i]]))
                {
                    max = (i - dic[arr[i]]);
                }
            }
            else
            {
                dic.Add(arr[i], i);
            }
        }
        return max;
    }
}
