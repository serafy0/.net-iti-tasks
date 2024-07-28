namespace presents;

class Program
{
    static void Main(string[] args)
    {
        float[] testPresentPrices =
        {
            12.23f,
            45.03f,
            12.23f,
            32.93f,
            6.99f,
            0.46f,
            7.34f,
            65.98f,
            152.13f,
            7.23f,
            10.00f,
            25.25f
        };
        float[] testPresentVolume =
        {
            4.53f,
            9.11f,
            4.53f,
            6.00f,
            1.04f,
            0.87f,
            2.57f,
            19.45f,
            65.59f,
            14.14f,
            16.66f,
            13.53f,
        };

        float testBudget = 183.23f;
        float testBagVolume = 57.11f;
        int testPeople = 7;
        int testNpresents = 12;
        var resultPrice1 = PresentList(
            testBudget,
            testBagVolume,
            testPeople,
            testNpresents,
            testPresentVolume,
            testPresentPrices
        );
        Console.WriteLine($"Maximum amount of money1  {resultPrice1}");

        float budget = 183.23f;
        float bagVolume = 64.11f;
        int people = 7;
        int Npresents = 12;
        float[] presentPrice =
        {
            12.23f,
            45.03f,
            12.23f,
            32.93f,
            6.99f,
            .46f,
            7.34f,
            65.98f,
            152.13f,
            7.23f,
            10.00f,
            25.25f
        };
        float[] presentVolume =
        {
            4.53f,
            9.11f,
            4.53f,
            6.00f,
            1.04f,
            .87f,
            2.57f,
            19.45f,
            65.59f,
            14.14f,
            16.66f,
            13.53f
        };

        var resultPrice2 = PresentList(
            budget,
            bagVolume,
            people,
            Npresents,
            presentVolume,
            presentPrice
        );

        Console.WriteLine($"Maximum amount of money1  {resultPrice2}");
    }

    public static float PresentList(
        float budget,
        float bagVolume,
        int people,
        int Npresents,
        float[] presentVolume,
        float[] presentPrice
    )
    {
        float maxSpent = 0;
        List<int> finalPrices = new List<int>();
        int finalCount = 0;
        int multipleOfPeople = 1;
        while (multipleOfPeople <= Npresents / people)
        {
            int totalPresents = multipleOfPeople++ * people;
            float finalPrice = 0;
            for (int i = 0; i < (1 << Npresents); i++)
            {
                List<int> currentPrices = new List<int>();
                int count = 0;
                float totalVolume = 0;
                float totalPrice = 0;

                for (int j = 0; j < Npresents; j++)
                {
                    if ((i & (1 << j)) != 0)
                    {
                        count++;
                        totalVolume += presentVolume[j];
                        totalPrice += presentPrice[j];
                        currentPrices.Add(j);
                    }
                }

                if (count == totalPresents && totalVolume <= bagVolume && totalPrice <= budget)
                {
                    if (totalPrice > finalPrice)
                    {
                        finalPrice = totalPrice;
                        finalPrices = new List<int>(currentPrices);
                        finalCount = count;
                    }
                }
            }
            if (finalPrice > maxSpent)
            {
                maxSpent = finalPrice;
                float totalPrice = 0;
                float totalVolume = 0;
                Console.WriteLine("Price: Volume");

                foreach (var i in finalPrices)
                {
                    Console.WriteLine($"{presentPrice[i]}: {presentVolume[i]}");
                    totalVolume += presentVolume[i];
                    totalPrice += presentPrice[i];
                }
                Console.WriteLine($"total volume= {totalVolume}");
                Console.WriteLine($"total price= {totalPrice}");
                Console.WriteLine($"final count={finalCount}");
            }
        }

        return maxSpent;
    }
}
