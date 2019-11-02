using System;
public class DigPow
{
    public static long digPow(int n, int p)
    {
        string temp = n.ToString();
        double digit;
        double sum = 0;
        for (int i = 0; i<temp.Length; ++i)
        {
            digit = Char.GetNumericValue(temp[i]);
            sum += Math.Pow(digit, p+i);
        }
        return sum%n == 0 ? (long)sum/n : -1;
    }

}
