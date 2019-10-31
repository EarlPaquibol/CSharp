using System;
using System.Linq;
using System.Collections.Generic;

public class Number
{
  public int DigitalRoot(long n)
  {
     var sum = n.ToString().Sum(char.GetNumericValue);
     while (sum.ToString().Length > 1)
     {
         sum = sum.ToString().Sum(char.GetNumericValue);
     }
     return (int)sum;
  }
}

///////////////////////////////////////////////////////////////////////////////
using System;
using System.Linq;
using System.Collections.Generic;

class Number
{
    public int DigitalRoot(long n)
    {
        string temp = n.ToString();
        List<double> list = temp.Select(x => Char.GetNumericValue(x)).ToList();
        var a = list.Aggregate((x, y) => x + y);
        while (a.ToString().Length > 1)
        {
            temp = a.ToString();
            list = temp.Select(x => Char.GetNumericValue(x)).ToList();
            a = list.Aggregate((x, y) => x + y);
        }
        return Convert.ToInt32(a);
    }
}
