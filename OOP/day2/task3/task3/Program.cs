namespace task3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int day = -1;
        int month = -1;
        int year = -1;

        int maxDayNum = 30;

        do
        {
            Console.WriteLine("Please enter year a year between 1980 and 2023");
            int yearValue = int.Parse(Console.ReadLine());

            if (yearValue < 2023 && yearValue > 1980)
            {
                year = yearValue;
            }
        } while (year == -1);

        do
        {
            Console.WriteLine("Please enter a month between 1 and 12");
            int monthValue = int.Parse(Console.ReadLine());

            if (monthValue <= 12 && monthValue >= 1)
            {
                month = monthValue;
            }
        } while (month == -1);

        do
        {
            Console.WriteLine("Please enter a valid day");
            int dayValue = int.Parse(Console.ReadLine());

            if (
                month == 1
                || month == 3
                || month == 5
                || month == 7
                || month == 8
                || month == 10
                || month == 12
            )
            {
                maxDayNum = 31;
                if (dayValue <= 31 && dayValue >= 1)
                {
                    day = dayValue;
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                maxDayNum = 30;

                if (dayValue <= 30 && dayValue >= 1)
                {
                    day = dayValue;
                }
            }
            else if (month == 2)
            {
                if (year % 4 == 0)
                {
                    maxDayNum = 29;
                    if (dayValue >= 1 && dayValue <= 29)
                    {
                        day = dayValue;
                    }
                }
                else if (dayValue >= 1 && dayValue <= 28)
                {
                    maxDayNum = 28;
                    day = dayValue;
                }
            }
        } while (month == -1);

        Console.WriteLine($"{day}/{month}/{year}");

        int currentday = DateTime.Now.Day;
        int currentmonth = DateTime.Now.Month;
        int currentyear = DateTime.Now.Year;
        int calcYear = currentyear - year;
        int calcMonth = currentmonth - month;
        int calcDay = currentday - day;

        if (calcMonth < 0)
        {
            calcMonth = 12 + calcMonth;
            calcYear--;
        }

        if (calcDay < 0)
        {
            calcDay = maxDayNum + calcDay;
            calcMonth--;

            if (calcMonth >= 12)
            {
                calcMonth = 12 - calcMonth;
                calcYear++;
            }
        }

        Console.WriteLine($"you're {calcYear}y  {calcMonth} months and {calcDay} days");
    }
}
