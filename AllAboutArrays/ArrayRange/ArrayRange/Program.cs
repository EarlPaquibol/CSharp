using System;
using static System.Console;
class TypingGrades
{
    static void Main()
    {
        int[] typed = { 0, 16, 31, 51, 76 };
        string[] grades = { "F", "D", "C", "B", "A" };
        string grade = "";
        Write("Enter number of typed words >> ");
        int input = Convert.ToInt32(ReadLine());
        int x = typed.Length - 1;                                 // = 75
        while (x >= 0 && input < typed[x])
        {
            --x;
            grade = grades[x];
        }
        if (input > 76)
        {
            Write("Typing {0} words per minute: Grade A", input);
        }
        else
            Write("Typing {0} words per minute: Grade {1}", input, grade);
    }
}
