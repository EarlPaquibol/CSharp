using System;
using static System.Console;
using System.Linq;
public class Kata
{
    public static int FindShort(string s)
    {
        var list = s.Split(" ");
        var re = list.OrderBy(n => n.Length);
        var shortest = re.First();
        Write(shortest.Length);
        return 0;
    }

    static void Main()
    {
        FindShort("bitcoin take over the world maybe who knows perhaps");
    }
}

//
using System.Linq;
public class Kata
{
  public static int FindShort(string s)
  {
    return s.Split(' ').Min(x => x.Length);
  }
}

using System.Linq;
public class Kata
{
    public static int FindShort(string s) => s.Split(" ").OrderBy(n => n.Length).First().Length;
}


