namespace task_3;

class Program
{
    static void Main(string[] args)
    {
        float[] presentPrices =
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
        float[] presentVolume =
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
            13.53f
        };

        float budget = 183.23f;
        float bagVolume = 57.11f;
        int people = 7;
        int Npresents = 12;
        var resultPrice = PresentList(
            budget,
            bagVolume,
            people,
            Npresents,
            presentVolume,
            presentPrices
        );
        Console.WriteLine($"Maximum amount of money  {resultPrice}");

        var resultPrice2 = Solutions.PresentListV2(
            budget,
            bagVolume,
            people,
            Npresents,
            presentVolume,
            presentPrices
        );

        Console.WriteLine($"Maximum amount of money2:  {resultPrice2}");

        var resultPrice3 = Solutions2.PresentList(
            budget,
            bagVolume,
            people,
            Npresents,
            presentVolume,
            presentPrices
        );

        Console.WriteLine($"Maximum amount of money2:  {resultPrice3}");
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

        // Try buying k presents for each person (1, 2, 3, ..., until the maximum possible k)
        for (int k = 1; k <= Npresents / people; k++)
        {
            // Calculate the total number of presents to be bought
            int totalPresents = k * people;

            // Check all combinations of totalPresents from Npresents
            // We use a simple brute-force approach to check every combination

            for (int i = 0; i < (1 << Npresents); i++)
            {
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
                    }
                }

                // Check if we have selected exactly totalPresents
                if (count == totalPresents && totalVolume <= bagVolume && totalPrice <= budget)
                {
                    // Check if this is the maximum amount of money spent
                    if (totalPrice > maxSpent)
                    {
                        maxSpent = totalPrice;
                    }
                }
            }
        }

        return maxSpent;
    }
}
