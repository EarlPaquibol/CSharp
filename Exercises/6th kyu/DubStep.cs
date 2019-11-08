using System;
using System.Linq;

public class Dubstep
{
    public static string SongDecoder(string input)
    {
        return String.Join(" ",input.Split("WUB").Where(x => !string.IsNullOrEmpty(x)));
    }
}
