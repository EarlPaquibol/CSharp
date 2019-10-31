public class Kata
{
  public static int Find(int[] arr)
  {
      int n = arr.Take(3).Count(i => i%2 == 0) > 1 ? 1 : 0;
      return arr.First(i => i%2 == n);
  }
}

//
  var evenNumbers = integers.Where(integer => integer % 2 == 0);
    var oddNumbers = integers.Where(integer => integer % 2 == 1);
    return evenNumbers.Count() == 1 ? evenNumbers.First() : oddNumbers.First();

//

  public static int Find(int[] integers)
    {
        int[] even = integers.Where(x => x % 2 == 0).ToArray();
        int[] odd = integers.Where(x => x % 2 != 0).ToArray();
        return even.Length > odd.Length ? odd[0] : even[0];
    }
