using System;
using System.Linq;

public class Kata
{
  public static int DuplicateCount(string str)
  {
    return str.ToLower().GroupBy(c => c).Count(c => c.Count() > 1);
  }
}


using System;
using System.Linq;
public class Kata
{
    public static int DuplicateCount(string str)
    {
        str = str.ToLower();
        int total = 0;
        foreach (char i in str)
        {
            if (str.ToCharArray().Count(x => x == i) > 1)
            {
                str = str.Replace(i, ' ');
                total++;
            }
        }
        return total;
    }
