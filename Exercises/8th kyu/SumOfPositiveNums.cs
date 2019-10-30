using System;
using System.Linq;

public class Kata
{
    public static int PositiveSum(int[] arr)
    {
        int total = 0;
        foreach (int num in arr)
        {
            if (num > 0)
                total += num;
        }
        return total;
    }
}
