namespace task_2;

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
        float[,] dp = new float[Npresents + 1, (int)(bagVolume + 1)];

        int p,
            v = 0;
        float remainingBudget = 0;
        int counter = 0;
        for (p = 0; p <= Npresents && remainingBudget < budget && v < bagVolume; p++)
        {
            for (v = 0; v < bagVolume; v++)
            {
                if (p == 0 || v == 0)
                {
                    dp[p, v] = 0;
                }
                else if (presentVolume[p - 1] <= v)
                {
                    dp[p, v] = Math.Max(
                        presentPrice[p - 1] + dp[p - 1, (int)(v - presentVolume[p - 1])],
                        dp[p - 1, v]
                    );

                    remainingBudget += (int)presentPrice[p - 1];
                    counter++;
                }
                else
                {
                    dp[p, v] = dp[p - 1, v];
                }
            }
        }
        Console.WriteLine(counter);
        // Console.WriteLine(dp.ToString());

        return dp[Npresents, (int)bagVolume];
    }
}
