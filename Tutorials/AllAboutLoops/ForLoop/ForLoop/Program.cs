using System;
using static System.Console;
class SumFiveints
{
    static void Main()
    {
        int Temp;
        int limit = 4;
        WriteLine("Enter a number >> ");
        int input = Convert.ToInt32(ReadLine());
        for (int x = 0; x < limit; ++x)
        {
            WriteLine("Enter another number >> ");
            Temp = Convert.ToInt32(ReadLine());
            input += Temp;
        }
        WriteLine("The total is " + input);
    }
}