namespace task4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int number1 = 0;
        int number2 = 0;
        char op = 'Y';
        char again = '-';

        do
        {
            Console.WriteLine("type num1");

            number1 = int.Parse(Console.ReadLine());


            Console.WriteLine("select +,-,/ or *");

            op = char.Parse(Console.ReadLine());

            Console.WriteLine("type num2");
            number2 = int.Parse(Console.ReadLine());
            float sum = 0;


            // if (op == '+')
            // {
            //     sum = number1 + number2;
            // }
            // else if (op == '-')
            // {
            //     sum = number1 / number2;

            // }
            // else if (op == '/')
            // {
            //     sum = number1 / number2;

            // }
            // else if (op == '*')
            // {
            //     sum = number1 * number2;

            // }

            switch (op)
            {
                case '+':
                    {

                        sum = number1 + number2;


                        break;
                    }
                case '-':
                    {
                        sum = number1 - number2;

                        break;
                    }
                case '/':
                    {
                        sum = number1 / number2;

                        break;
                    }
                case '*':
                    {
                        sum = number1 * number2;

                        break;
                    }


            }

            Console.WriteLine($"Result: {sum}");

            Console.WriteLine("Press n to quit or press any other key to try again");
            again = char.Parse(Console.ReadLine());

        } while (again != 'n');
    }
}
