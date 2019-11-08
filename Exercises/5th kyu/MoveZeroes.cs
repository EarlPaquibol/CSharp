using System.Linq;
using System.Collections.Generic;
public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        List<int> ey = arr.ToList();
        for (int i =0; i<arr.Length; ++i)
        {
            if (arr[i] == 0)
            {
                ey.Remove(arr[i]);
                ey.Add(0);
            }
        }
        return ey.ToArray();
    }
}
///
using System.Linq;
public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
     return arr.OrderBy(x => x==0).ToArray();
  }
}
///
using System.Linq;
public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    return arr.Where(x=>x!=0).Concat(arr.Where(x=>x==0)).ToArray();
  }
}
//
using System.Linq;
public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
     return arr.OrderBy(x => x==0).ToArray();
  }
}
