class Solutions
{
    public static float PresentListV2(
        float budget,
        float bagVolume,
        int people,
        int Npresents,
        float[] presentVolume,
        float[] presentPrice
    )
    {
        // Create a list of tuples (price, volume)
        List<(float Price, float Volume)> presents = new List<(float, float)>();
        for (int i = 0; i < Npresents; i++)
        {
            presents.Add((presentPrice[i], presentVolume[i]));
        }

        // Sort presents based on price-to-volume ratio in descending order
        presents = presents.OrderByDescending(p => p.Price / p.Volume).ToList();

        float maxSpent = 0;

        // Try buying k presents for each person (1, 2, 3, ..., until the maximum possible k)
        for (int nOfPresentsPerPerson = 1; nOfPresentsPerPerson <= Npresents / people; nOfPresentsPerPerson++)
        {
            float currentSpent = 0;
            float currentVolume = 0;
            int count = 0;

            foreach (var present in presents)
            {
                // Try to add k presents for each person
                if (
                    count + nOfPresentsPerPerson * people <= Npresents
                    && currentVolume + nOfPresentsPerPerson * people * present.Volume <= bagVolume
                    && currentSpent + nOfPresentsPerPerson * people * present.Price <= budget
                )
                {
                    count += nOfPresentsPerPerson * people;
                    currentVolume += nOfPresentsPerPerson * people * present.Volume;
                    currentSpent += nOfPresentsPerPerson * people * present.Price;
                }
                else
                {
                    break;
                }
            }

            // Check if we have selected exactly k presents for each person
            if (count == nOfPresentsPerPerson * people && currentVolume <= bagVolume && currentSpent <= budget)
            {
                // Check if this is the maximum amount of money spent
                if (currentSpent > maxSpent)
                {
                    maxSpent = currentSpent;
                }
            }
        }

        return maxSpent;
    }
}
