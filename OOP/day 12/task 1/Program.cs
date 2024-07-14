namespace task_1;

class Program
{
    static void Main(string[] args)
    {
        float budget = 183.23f;
        float bagVolume = 64.11f;
        int people = 7;
        int Npresents = 12;

        float[] presentVolume =
        {
            4.53f, // Lower price examples
            2.11f,
            1.53f,
            2.00f,
            1.04f,
            0.87f,
            2.57f,
            19.45f,
            65.59f,
            14.14f,
            16.66f,
            13.53f
        };
        float[] presentPrice =
        {
            5.23f, // Lower price examples
            2.03f,
            3.23f,
            8.93f,
            6.99f,
            0.46f,
            7.34f,
            65.98f,
            152.13f,
            7.23f,
            10.00f,
            25.25f
        };

        // Call PresentList function
        float affordablePresents = PresentList(
            budget,
            bagVolume,
            people,
            Npresents,
            presentVolume,
            presentPrice
        );

        // Print the result
        Console.WriteLine($"Maximum number of presents that can be bought: {affordablePresents}");
    }

    // public static float PresentList(
    //     float budget,
    //     float bagVolume,
    //     int people,
    //     int Npresents,
    //     float[] presentVolume,
    //     float[] presentPrice
    // )
    // {
    //     float[,] dp = new float[Npresents + 1, (int)(bagVolume + 1)];

    //     int i,
    //         w;
    //     float budgetTaken = 0;

    //     for (i = 0; i <= Npresents; i++)
    //     {
    //         if (budgetTaken >= budget)
    //         {
    //             break;
    //         }
    //         for (w = 0; w < bagVolume; w++)
    //         {
    //             if (budgetTaken >= budget)
    //             {
    //                 break;
    //             }
    //             if (i == 0 || w == 0)
    //             {
    //                 dp[i, w] = 0;
    //             }
    //             else if (presentVolume[i - 1] <= w)
    //             {
    //                 dp[i, w] = Math.Max(
    //                     presentPrice[i - 1] + dp[i - 1, (int)(w - presentVolume[i - 1])],
    //                     dp[i - 1, w]
    //                 );

    //                 budgetTaken += presentPrice[i - 1];
    //             }
    //             else
    //             {
    //                 dp[i, w] = dp[i - 1, w];
    //             }
    //         }
    //     }

    //     return dp[Npresents, (int)bagVolume];
    // }

    public static float PresentList(
        float budget,
        float bagVolume,
        int people,
        int Npresents,
        float[] presentVolume,
        float[] presentPrice
    )
    {
        float totalPresentsNeeded = budget / (presentPrice.Sum() / people);
        float[,] dp = new float[Npresents + 1, (int)(bagVolume + 1)];

        int i,
            w;

        for (i = 0; i <= Npresents; i++)
        {
            for (w = 0; w < bagVolume; w++)
            {
                if (i == 0 || w == 0)
                {
                    dp[i, w] = 0;
                }
                else if (presentVolume[i - 1] <= w)
                {
                    // Consider only presents that fit within remaining bag capacity
                    dp[i, w] = Math.Max(
                        presentPrice[i - 1] + dp[i - 1, (int)(w - presentVolume[i - 1])],
                        dp[i - 1, w]
                    );
                }
                else
                {
                    dp[i, w] = dp[i - 1, w];
                }
            }
        }

        // Calculate maximum affordable presents considering bag volume
        float affordablePresentsByVolume = Math.Min(
            totalPresentsNeeded,
            dp[Npresents, (int)bagVolume] / presentPrice[0]
        );

        // Return the maximum price based on affordable presents
        return affordablePresentsByVolume * presentPrice[0];
    }
}
