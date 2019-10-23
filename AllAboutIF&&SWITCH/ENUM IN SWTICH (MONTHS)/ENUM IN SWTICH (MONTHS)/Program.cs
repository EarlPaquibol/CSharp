using System;
using static System.Console;
class CheckMonth
{
    enum month
    {
        January = 01, February, March, April, May, June, July, August, September, October, November, December
    }
    static void Main()
    {
        WriteLine("Enter your birth month >> ");
        int input = Convert.ToInt32(ReadLine());
        WriteLine("Enter your birth day >> ");
        int day = Convert.ToInt32(ReadLine());
        if (input <= 12 && day <= 31)
        {
            switch ((month)input)
            {
                case month.January:
                    WriteLine("2/17 is a valid birthday.", (int)month.January);
                    break;
                case month.February:
                    WriteLine("{0} is a valid month", month.February);
                    break;
                case month.March:
                    WriteLine("{0} is a valid month", input);
                    break;
                case month.April:
                    WriteLine("{0} is a valid month", input);
                    break;
                case month.May:
                    WriteLine("{0} is a valid month", input);
                    break;
                case month.June:
                    WriteLine("{0} is a valid month", input);
                    break;
                case month.July:
                    WriteLine("{0} is a valid month", input);
                    break;
                case month.August:
                    WriteLine("{0} is a valid month", input);
                    break;
                case month.September:
                    WriteLine("{0} is a valid month", input);
                    break;
                case month.October:
                    WriteLine("{0} is a valid month", input);
                    break;
                case month.November:
                    WriteLine("{0} is a valid month", input);
                    break;
                case month.December:
                    WriteLine("{0} is a valid month", input);
                    break;


            }
        }
        else
        {
            WriteLine("Invalid date");
        }
    }
}