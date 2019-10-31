public static class Kata
{
    public static int Solution(int value)
    {
        if (value<1)
          return 0;
        IEnumerable<int> nums = Enumerable.Range(1, value - 1).ToList().FindAll(x => x % 3 == 0 || x % 5 == 0);
        return nums.Sum();
    }
}


//

return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
//

var sum = 0;
    for(int i = 3; i < value; i++)
    {
      if(i % 3 == 0 || i % 5 == 0) sum += i;
    }
    return sum;
