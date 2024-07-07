namespace task_1;

class Program
{
    static void Main(string[] args)
    {
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
                Employee.SecurityLevel.Developer,
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

            Console.WriteLine("Enter Id");
            EmpArr[i].Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Salary");
            EmpArr[i].Salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Gender. enter m for male or f for female");
            string g = Console.ReadLine();
            if (g == "m")
            {
                EmpArr[i].EGender = Employee.Gender.Male;
            }
            else
            {
                EmpArr[i].EGender = Employee.Gender.Female;
            }

            Console.WriteLine("choose a security level.\n1=Guest,2=Developer,3=Secretary,4=DBA");

            EmpArr[i].SLevel = (Employee.SecurityLevel)int.Parse(Console.ReadLine());

            Console.WriteLine("Enter hire date in dd-mm-yyyy formt");
            string dateString = Console.ReadLine();
            string[] sArr = dateString.Split("-");
            EmpArr[i].Hdate = new HireDate(sArr[0], sArr[1], sArr[2]);
            // EmpArr[i].Hdate.Day = int.Parse(sArr[0]);
            // EmpArr[i].Hdate.month = int.Parse(sArr[1]);
            // EmpArr[i].Hdate.Year = int.Parse(sArr[2]);
        }

        return EmpArr;
    }
}
