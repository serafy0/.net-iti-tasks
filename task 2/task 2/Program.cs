namespace task_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
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

        return dp[Npresents, (int)bagVolume];
    }
}
