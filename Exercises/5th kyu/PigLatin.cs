using System.Linq;
public class Kata
{
    public static string PigIt(string str)
    {
        return string.Join(" ", str.Split(' ').Select(w => w.Substring(1) + w[0] + "ay"));
    }
}

//
using System;
using System.Collections.Generic;

public class Kata
{
    public static string PigIt(string str)
    {
        List<string> pigLatin = new List<string> { };
        foreach (string word in str.Split(" "))
        {
            pigLatin.Add(word.Substring(1) + word.Substring(0, 1) + "ay");
        }
        return String.Join(" ", pigLatin);
    }
}
