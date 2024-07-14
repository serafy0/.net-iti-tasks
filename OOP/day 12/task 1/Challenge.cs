class Challenge
{
    public static float PresentList(
        float budget,
        float bagVolume,
        int people,
        int Npresents,
        float[] presentVolume,
        float[] presentPrice
    )
    {
        float[,] result = new float[Npresents + 1, (int)Math.Ceiling(bagVolume)];
        float sol = 0;
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                if (i == 0 || j == 0)
                    continue;
                else if (presentVolume[i - 1] <= j)
                {
                    sol = presentPrice[i - 1] + result[i - 1, (int)(j - presentVolume[i - 1])];
                    result[i, j] = Math.Max(sol, result[i - 1, j]);
                    Console.WriteLine(result[i, j]);
                }
                else
                {
                    result[i, j] = result[i - 1, j];
                }
            }
        }

        for (int i = result.GetLength(1) - 1; i > 0; i--)
        {
            int j = result.GetLength(0) - 1;
            if (result[j, i] <= budget)
            {
                sol = result[j, i];
                break;
            }
            else
            {
                continue;
            }
        }

        return sol;
    }

    public static float PresentList2(
        float budget,
        float bagVolume,
        int people,
        int Npresents,
        float[] presentVolume,
        float[] presentPrice
    )
    {
        float[,] dp = new float[Npresents + 1, (int)(bagVolume + 1)];

        int i,
            w;
        float budgetTaken = 0;

        for (i = 0; i <= Npresents; i++)
        {
            if (budgetTaken >= budget)
            {
                break;
            }
            for (w = 0; w < bagVolume; w++)
            {
                if (budgetTaken >= budget)
                {
                    break;
                }
                if (i == 0 || w == 0)
                {
                    dp[i, w] = 0;
                }
                else if (presentVolume[i - 1] <= w)
                {
                    dp[i, w] = Math.Max(
                        presentPrice[i - 1] + dp[i - 1, (int)(w - presentVolume[i - 1])],
                        dp[i - 1, w]
                    );

                    budgetTaken += presentPrice[i - 1];
                }
                else
                {
                    dp[i, w] = dp[i - 1, w];
                }
            }
        }

        return dp[Npresents, (int)bagVolume];
    }
}
