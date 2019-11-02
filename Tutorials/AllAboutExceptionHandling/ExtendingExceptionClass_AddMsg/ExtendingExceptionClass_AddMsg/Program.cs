using System;
using static System.Console;
class FindSquareRoot
{
    static void Main()
    {
        double input;
        Write("Enter value >> ");
        try
        {
            if (!Double.TryParse(ReadLine(), out input))
            {
                input = 0;
                WriteLine("Cannot convert input.");
                WriteLine("Squareroot value is " + input);
            }
            else if (input < 0)
            {
                NegativeInput e = new NegativeInput();
                throw (e);
            }
            else
            {
                double sqrt = Math.Sqrt(input);
                WriteLine("Squareroot of {0} is {1}", input, sqrt);
            }
        }
        catch (NegativeInput e)
        {
            Write(e.Message);
        }
    }
}

class NegativeInput : Exception
{
    public static string msg = "Number can’t be negative. idiot";
    public NegativeInput() : base(msg)                           //override exception class msg
    {
    }


}