using System;
using static System.Console;
using static System.Array;
class ArrayDemo
{
    static void Main()
    {
        int[] nums = { 7, 6, 3, 2, 10, 8, 4, 5, 9, 1 };
        int input;
        do
        {
            Write("Enter a value 1-4 >> ");

            input = Convert.ToInt32(ReadLine());
            if (input == 1)
            {
                for (int x = 0; x < nums.Length; ++x)
                {
                    Write("{0} ", nums[x]);
                }
                WriteLine("");
            }
            else if (input == 2)
            {
                Reverse(nums);
                for (int x = 0; x < nums.Length; ++x)
                {
                    Write("{0} ", nums[x]);
                }
                WriteLine("");
            }
            else if (input == 3)
            {
                Write("Which position do you want to view? ");
                int view = Convert.ToInt32(ReadLine());
                WriteLine(nums[view]);
            }
        } while (input != 4);
    }
}