using System;
using System.Linq;
using System.Collections.Generic;
public class Accumul
{
    public static String Accum(string s)
    {
        s = s.ToLower();
        List<string> x = new List<string>{ };
        foreach (var i in s.Select((Value, Index) => (Value, Index)))
        {
            x.Add(i.Value.ToString().ToUpper() + String.Concat(Enumerable.Repeat(i.Value, i.Index)));
        }
        string accum = String.Join("-", x);
        return accum;
    }
}


//
using System;
using System.Linq;
public class Accumul
{
  public static String Accum(string s)
  {
     return string.Join("-",s.Select((x,i)=>char.ToUpper(x)+new string(char.ToLower(x),i)));
  }
}



        char x = 's';
        string g;
        g = new string(char.ToLower(x), 3);
        Console.WriteLine(g);
