class BirdCount
{
    private int[] BirdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        BirdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        int k = 0;
        for (int i = 0; i < BirdsPerDay.Length; i++)
        {
            if (i == BirdsPerDay.Length - 1)
            {
                k += BirdsPerDay[i];
            }
        }
        return k;
    }

    public void IncrementTodaysCount()
    {
        BirdsPerDay[BirdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        for (int i = 0; i < BirdsPerDay.Length; i++)
        {
            if (BirdsPerDay[i] == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int k = numberOfDays;
        int res = 0;
        for (int i =0; i < k; i++)
        {
            res += BirdsPerDay[i];
        }
        return res;
    }

    public int BusyDays()
    {
        int k = 0;
        for (int i = 0; i < BirdsPerDay.Length; i++)
        {
            if (BirdsPerDay[i] >= 5)
            {
                k++;
            }
        }
        return k;
    }
}
