using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int SquareDigits(int n)
    {
        string num = Convert.ToString(n);
        List<int> ln = new List<int> { };
        foreach (char i in num)
        {
            ln.Add(Convert.ToInt32(Char.GetNumericValue(i)));
        }
        var temp = ln.Select(x => x * x);
        n = int.Parse(string.Join("", temp));
        return n;
    }
}



using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int SquareDigits(int n)
    {
        string num = Convert.ToString(n);
        var temp = num.Select(x => Char.GetNumericValue(x));
        return int.Parse(string.Join("", temp.Select(x => x * x)));
    }
}


using System;
using System.Linq;

public class Kata
{
    public static int SquareDigits(int n)
    {
        return int.Parse(string.Join("", Convert.ToString(n).Select(x => Char.GetNumericValue(x)).Select(x => x * x)));
    }
}

using System;
using System.Linq;
public class Kata
{
        public static int SquareDigits(int n)
        {
            return int.Parse(String.Concat(n.ToString().Select(a => (int)Math.Pow(char.GetNumericValue(a), 2))));
        }
}
