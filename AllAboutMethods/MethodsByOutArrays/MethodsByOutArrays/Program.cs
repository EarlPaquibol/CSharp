using static System.Console;
using System;

class IntegerFacts
{
    static void Main()
    {
        int[] array = new int[10];
        int els = FillArray(array);
        int high, low, sum;
        double avg;
        Statistics(array, els, out high, out low, out sum, out avg);
        WriteLine("The array has " + els + " values");
        WriteLine("The highest value is {0}", high);
        WriteLine("The lowest value is {0}", low);
        WriteLine("The sum of the values is {0}", sum);
        WriteLine("The average is {0:0.0}", avg);
    }

    public static int FillArray(int[] array)
    {
        int els = 0;
        string input;
        int idiot = 0;
        for (int x = 0; x < array.Length; ++x)
        {
            Write("Enter an integer >> ");
            input = ReadLine();
            while (!int.TryParse(input, out idiot))
            {
                Write("Invalid integer. Enter an integer again >> ");
                input = ReadLine();
            }
            if (idiot == 999)
            {
                break;
            }
            array[x] = idiot;
        }
        for (int i = 0; i < array.Length; ++i)
        {
            if (array[i] != 0)
                ++els;
        }
        return els;

    }
    public static void Statistics(int[] array, int els, out int high, out int low, out int sum, out double avg)
    {
        Array.Sort(array);
        int w = 0;
        w = array.Length - 1;
        high = array[w];
        int x = 0;
        low = array[x];
        while (array[x] == 0)
        {
            x++;
            low = array[x];
        }
        sum = 0;
        for (int q = 0; q < array.Length; ++q)
        {
            sum += array[q];
        }
        double fk = Convert.ToDouble(sum);
        double elsie = Convert.ToDouble(els);
        avg = fk / elsie;
    }

}
