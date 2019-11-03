using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
    return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
  }





  //

  using System.Linq;
using System;

public class Kata
{
    public static string SpinWords(string sentence)
    {
        string[] arr = sentence.Split(" ");
        for (int i = 0; i<arr.Length; ++i)
        {
            if (arr[i].Length > 4)
            {
                arr[i] = new String(arr[i].Reverse().ToArray());
            }
            else
                arr[i] = arr[i];
        }
        sentence = String.Join(" ", arr);
        return sentence;
    }
}
