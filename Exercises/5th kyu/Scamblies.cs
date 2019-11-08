using System;
using System.Linq;
public class Scramblies
{

    public static bool Scramble(string str1, string str2)
    {
        return str2.All(x=>str1.Count(y=>y==x)>=str2.Count(y=>y==x));
    }

}

//
using System;
public class Scramblies
{
    public static bool Scramble(string str1, string str2)
    {
        bool scram = true;
        int a;
        for (int i = 0; i < str2.Length; ++i)
        {
            if (!str1.Contains(str2[i]))
            {
                scram = false;
                break;
            }
            a = str1.IndexOf(str2[i]);
            if (a < 0)
            {
                break;
            }
            else
            {
                str1 = str1.Remove(a, 1);
            }
        }
        return scram;
    }
}
