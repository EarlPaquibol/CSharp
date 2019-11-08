using System;
public class Kata
{
    public static string Rgb(int r, int g, int b)
    {
        if (r<0)
        {
            r = 0;
        }
        else if (r>255)
        {
            r = 255;
        }
        if (g<0)
        {
            g = 0;
        }
        else if (g > 255)
        {
            g = 255;
        }
        if (b<0)
        {
            b = 0;
        }
        else if (b>255)
        {
            b = 255;
        }
        string rgb = r.ToString("X").PadLeft(2, '0') + g.ToString("X").PadLeft(2, '0')
                       + b.ToString("X").PadLeft(2,'0');
        return rgb;
    }
}


//
using System;

public class Kata
{
  public static string Rgb(int r, int g, int b)
  {
      r = Math.Max(Math.Min(255, r), 0);
      g = Math.Max(Math.Min(255, g), 0);
      b = Math.Max(Math.Min(255, b), 0);
      return String.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
  }
}
