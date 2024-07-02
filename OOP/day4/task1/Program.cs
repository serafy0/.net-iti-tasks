
namespace task1;

class Program
{
    static void Main(string[] args)
    {
        //pass reference type by value
        int[] = array = { 1,2,3,4,5,6,7};
        Utility obj = new Utility();

        obj.MultiplyArrayByTen(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }



        //pass reference type by reference
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Utility obj = new Utility();
        obj.MultiplyArrayByTenV2(ref arr);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);//
        }

        //composition and Association with point and circle and rectangle
        //static variable



        Console.WriteLine("Hello, World!");
    }
}
