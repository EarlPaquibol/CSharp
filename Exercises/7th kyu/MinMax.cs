using System;
using System.Linq;

public static class Kata
{
    public static string HighAndLow(string numbers)
    {
        string[] arr = numbers.Split(" ");
        int[] num = new int[arr.Length];
        for (int i = 0; i<num.Length; ++i)
        {
            num[i] = Convert.ToInt32(arr[i]);
        }
        string a = num.Min().ToString();
        string b = num.Max().ToString();
        return $"{b} {a}";
    }
}

//
using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    var parsed = numbers.Split().Select(int.Parse);
    return parsed.Max() + " " + parsed.Min();
  }
}


using System;
using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    var numbersList = numbers.Split(' ').Select(x => Convert.ToInt32(x));
    return string.Format("{0} {1}", numbersList.Max(), numbersList.Min());
  }
}
