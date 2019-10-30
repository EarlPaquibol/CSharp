using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        string vowels = "aeiouAEIOU";
        int vowelCount = 0;
        foreach (char letter in str)
        {
            if (vowels.Contains(letter))
                vowelCount++;
        }
        return vowelCount;
    }
}


//
using System;
using System.Text.RegularExpressions;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        return (Regex.Matches(str, @"[aeiouAEIOU]")).Count;
    }
}


using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        return str.Count(i => "aeiou".Contains(i));
    }
}
