using System.Diagnostics.Metrics;

namespace task2;

class Program
{
    static void Main(string[] args)
    {
        Employee[] arr = [new Employee(), new Employee(), new Employee()];
        arr[0].setSNN("0");
        arr[0].setSalary(1000);
        arr[1].setSNN("1");
        arr[1].setSalary(2000);

        arr[1].setSNN("2");
        arr[2].setSalary(3000);

        Console.WriteLine(arr[0].toString());
        Console.WriteLine(arr[1].toString());
        Console.WriteLine(arr[2].toString());
        //-----------------
        // Console.WriteLine($"how many employees do you want to add?");

        // int size = int.Parse(Console.ReadLine());

        // int counter = 0;
        // while (counter < userArray.Length)
        // {
        //     Console.WriteLine($"add employee number {counter}");
        //     Console.WriteLine("add snn");
        //     string newSnn = Console.ReadLine();
        //     if (employeeExsistsInArray(userArray, newSnn))
        //     {
        //         Console.WriteLine("the array has an employee withy that snn. try again ");
        //         continue;
        //     }
        //     else
        //     {
        //         userArray[counter].setSNN(newSnn);
        //         Console.WriteLine($"add {userArray[counter].getSNN()}'s salary:");

        //         int newSal = int.Parse(Console.ReadLine());

        //         userArray[counter].setSalary(newSal);
        //         counter++;
        //     }
        // }

        // for (int i = 0; i < userArray.Length; i++)
        // {
        //     Console.WriteLine($"number{i}: {userArray[i].toString()}");
        // }

        //----
        // Dictionary<string,Employee> = new Dictionary<string, Employee>{}
        Employee[] userArray = new Employee[13];
        for (int i = 0; i < userArray.Length; i++)
        {
            userArray[i] = new Employee();
        }

        do
        {
            string input = "N";
            int[] indexArray = new int[13];
            for (int i = 0; i < indexArray.Length; i++)
            {
                indexArray[i] = -1;
            }
            int indexCounter = 0;
            do
            {
                int newIndex = 15;
                do
                {
                    Console.WriteLine("enter a number between 0 and 12");

                    newIndex = int.Parse(Console.ReadLine());
                } while (newIndex < 0 || newIndex > 12);

                Console.WriteLine("add snn");
                string newSnn = Console.ReadLine();
                if (employeeExsistsInArray(userArray, newSnn))
                {
                    Console.WriteLine("an employee already exists with that snn. try again ");
                    continue;
                }
                else
                {
                    userArray[newIndex].setSNN(newSnn);
                    Console.WriteLine($"add {userArray[newIndex].getSNN()}'s salary:");

                    int newSal = int.Parse(Console.ReadLine());

                    userArray[newIndex].setSalary(newSal);
                    indexArray[indexCounter] = newIndex;
                    indexCounter++;
                }

                Console.WriteLine("enter N if you want to stop the input");
                input = Console.ReadLine();
            } while (input != "N");

            Console.WriteLine("this is what you added");

            for (int i = 0; i < indexArray.Length; i++)
            {
                // Employee updatedEmpolyee = userArray[indexArray[i]];
                if (indexArray[i] != -1)
                {
                    Console.WriteLine(
                        $"number{indexArray[i]}: {userArray[indexArray[i]].toString()}"
                    );
                }
            }
        } while (true);
    }

    static Employee getEmployeeBySNN(Employee[] empArray, string snnValue)
    {
        for (int i = 0; i < empArray.Length; i++)
        {
            if (empArray[i].getSNN() == snnValue)
            {
                return empArray[i];
            }
        }
        return null;
    }

    static bool employeeExsistsInArray(Employee[] empArray, string snnValue)
    {
        return getEmployeeBySNN(empArray, snnValue) != null;
    }
}
