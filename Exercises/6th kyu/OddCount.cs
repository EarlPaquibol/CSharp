
    class Kata
    {
        public static int find_it(int[] seq)
        {
            foreach (int num in seq)
            {
                if (seq.Count(x => x == num) % 2 != 0)
                {
                    return num;
                }
            }
            return -1;
        }
    }


using System.Linq;

namespace Solution
{
  class Kata
    {
      public static int find_it(int[] seq)
      {
        return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
      }
    }
}

using System.Linq;

namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq)
      {
        return  seq.First(x => seq.Count(s => s == x) % 2 == 1);
      }

    }
}
