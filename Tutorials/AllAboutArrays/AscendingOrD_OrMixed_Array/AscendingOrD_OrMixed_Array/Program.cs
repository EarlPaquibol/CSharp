using System;
using static System.Console;
class TemperaturesComparison
{
    static void Main()
    {
        const int min = -30, max = 130;
        int[] temp = new int[5];
        bool sortedA = false;
        bool sortedD = false;
        decimal total = 0;
        for (int x = 0; x < temp.Length; ++x)
        {
            Write("Input a temperature from -30 to 130 >> ");
            int input = Convert.ToInt32(ReadLine());
            while (input < min || input > max)
            {
                Write("The temperature you entered is out of range. \nRe-enter temperature >> ");
                input = Convert.ToInt32(ReadLine());
            }
            temp[x] = input;
        }
        for (int x = 1; x < temp.Length; ++x)
        {
            if (temp[x - 1] < temp[x])     //getting warmer
            {
                sortedA = true;
            }
            else if (temp[x - 1] > temp[x]) //geting colder
            {
                sortedD = true;
            }
        }
        if (sortedA == true && sortedD == true)
        {
            Write("It's a mixed bag: ");
            for (int x = 0; x < temp.Length; ++x)
            {
                Write("{0} ", temp[x]);
            }
        }
        else if (sortedD == true)
        {
            Write("Getting cooler: ");
            for (int x = 0; x < temp.Length; ++x)
            {
                Write("{0} ", temp[x]);
            }
        }
        else if (sortedA == true)
        {
            Write("Getting warmer: ");
            for (int x = 0; x < temp.Length; ++x)
            {
                Write("{0} ", temp[x]);
            }
        }
        WriteLine("");
        for (int x = 0; x < temp.Length; ++x)
        {
            total += temp[x];
        }
        WriteLine("Average: {0:0.0}", total / 5);


    }

}
