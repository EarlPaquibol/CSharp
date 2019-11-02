using System;
using System.Linq;

public class Persist
{
    public static int Persistence(long n)
    {
        if (n.ToString().Length < 2)
            return 0;
        int counter = 0;
        n = (int)n.ToString().Select(x => Char.GetNumericValue(x)).Aggregate((x, y) => x * y);
        counter++;
        while (n.ToString().Length > 1)
        {
            n = (int)n.ToString().Select(x => Char.GetNumericValue(x)).Aggregate((x, y) => x * y);
            counter++;
        }
        return counter;
    }
}
