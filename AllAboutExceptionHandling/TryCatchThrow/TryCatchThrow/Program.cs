using System;
using static System.Console;
class SwimmingWaterTemperature
{
    static void Main()
    {
        int temp;
        Write("Enter temperature between 70-85 degrees Farenheit >> ");
        temp = Convert.ToInt32(ReadLine());
        while (temp != 999)
        {
            try
            {
                if (CheckComfort(temp) == true)
                {
                    if (temp >= 70 && temp < 85)
                    {
                        WriteLine("{0} degrees is comfortable for swimming.", temp);
                        Write("Enter another temperature or 999 to quit ");
                        temp = Convert.ToInt32(ReadLine());
                    }
                    else
                    {
                        WriteLine("{0} degrees is not comfortable for swimming.", temp);
                        Write("Enter another temperature or 999 to quit ");
                        temp = Convert.ToInt32(ReadLine());
                    }
                }
                else
                {
                    ArgumentException e = new ArgumentException();
                    throw (e);
                }

            }
            catch (ArgumentException e)
            {
                WriteLine(e.Message);
                Write("Enter another temperature or 999 to quit ");
                temp = Convert.ToInt32(ReadLine());
            }
        }
    }

    public static bool CheckComfort(int temp)
    {
        bool valid = false;
        if (temp >= 32 && temp < 212)
        {
            valid = true;
        }
        else
        {
            valid = false;
        }
        return valid;
    }
}




