using System;
using static System.Console;
class CountVowelsModularized
{
    public static void Main()
    {

        string length;
        string phrase = "";
        Write("Enter a string >> ");
        length = ReadLine();
        for (int x = 0; x < length.Length; ++x)
        {
            phrase += length.Substring(x, 1);
        }
        WriteLine("Number of vowels is/are >> {0}", CountVowels(phrase));


    }
    public static int CountVowels(string phrase)
    {
        int vowels = 0;
        for (int x = 0; x < phrase.Length; ++x)
        {
            if (phrase.Substring(x, 1) == "A" || phrase.Substring(x, 1) == "a" || phrase.Substring(x, 1) == "e" || phrase.Substring(x, 1) == "E" || phrase.Substring(x, 1) == "i" || phrase.Substring(x, 1) == "I"
                || phrase.Substring(x, 1) == "O" || phrase.Substring(x, 1) == "o" || phrase.Substring(x, 1) == "U" || phrase.Substring(x, 1) == "u")
            {
                vowels++;
            }
        }
        return vowels;
    }
}