namespace task1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Enum.IsDefined(typeof(Employee.SecurityLevel), 4));
        Employee[] testEmployees =
        [
            new Employee(1, 1300, Employee.Gender.Male, Employee.SecurityLevel.DBA, 10, 20, 2000),
            new Employee(
                2,
                2300,
                Employee.Gender.Female,
                Employee.SecurityLevel.Guest,
                30,
                6,
                2020
            ),
            new Employee(
                3,
                3300,
                Employee.Gender.Male,
                Employee.SecurityLevel.SecurityOfficer,
                14,
                20,
                1997
            ),
        ];

        printEmployees(testEmployees);

        printEmployees(getEmployeesFromUser(3));
    }

    static void printEmployees(Employee[] EmpArr)
    {
        for (int i = 0; i < EmpArr.Length; i++)
        {
            Console.WriteLine($"--------");

            Console.WriteLine($"employee#{i}");
            Console.WriteLine(EmpArr[i]);
            Console.WriteLine($"--------");
        }
    }

    static Employee[] getEmployeesFromUser(int size)
    {
        Employee[] EmpArr = new Employee[size];

        for (int i = 0; i < EmpArr.Length; i++)
        {
            Console.WriteLine("enter a new Employee");
            bool isValidId;
            do
            {
                Console.WriteLine("Enter Id");
                isValidId = int.TryParse(Console.ReadLine(), out int newId);

                EmpArr[i].Id = newId;
            } while (!isValidId);
            bool isValidSalary;
            do
            {
                Console.WriteLine("Enter Salary");
                isValidSalary = int.TryParse(Console.ReadLine(), out int newSalary);
                EmpArr[i].Salary = newSalary;
            } while (!isValidSalary);
            string g;
            do
            {
                Console.WriteLine("Enter Gender. enter m for male or f for female");
                g = Console.ReadLine();
                if (g == "m")
                {
                    EmpArr[i].EGender = Employee.Gender.Male;
                }
                else
                {
                    EmpArr[i].EGender = Employee.Gender.Female;
                }
            } while (g != "m" && g != "f");

            bool isValidSlevel;
            int newSLevel;
            do
            {
                Console.WriteLine(
                    "choose a security level.\n1=Guest,2=Developer,3=Secretary,4=DBA,5=SecurityOfficer"
                );

                isValidSlevel = int.TryParse(Console.ReadLine(), out newSLevel);
            } while (!isValidSlevel || newSLevel < 1 || newSLevel > 5);
            if (newSLevel == 5)
            {
                EmpArr[i].SLevel = Employee.SecurityLevel.SecurityOfficer;
            }
            else
            {
                EmpArr[i].SLevel = (Employee.SecurityLevel)newSLevel;
            }

            string[] sArr;
            do
            {
                Console.WriteLine("Enter hire date in dd-mm-yyyy format");
                string dateString = Console.ReadLine();
                sArr = dateString.Split("-");
            } while (sArr.Length != 3 || !isValidDateArray(sArr));
            EmpArr[i].Hdate = new HireDate(sArr[0], sArr[1], sArr[2]);
        }

        return EmpArr;
    }

    static bool isValidDateArray(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            bool isValidNum = int.TryParse(arr[i], out int newNum);

            if (!isValidNum)
            {
                return false;
            }
        }

        return true;
    }
}
