using System;
using static System.Console;
class MonthNames
{
    static void Main()
    {
        int month;
        string input1;
        WriteLine("Enter month integer: ");
        input1 = ReadLine();
        month = Convert.ToInt32(input1);
        WriteLine(((Month)month));
    }
    enum Month
    {
        January = 1, February = 2, March = 3, April = 4, May = 5, June = 6, July = 7, August = 8,
        September = 9, October = 10, November = 11, December = 12



    }
}

