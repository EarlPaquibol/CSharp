using System;
using static System.Console;
class EnterUppercaseLetters
{
    static void Main()
    {
        char input;
        do
        {
            Write("Enter a big letter >> ");
            input = Convert.ToChar(ReadLine());
            bool letter = char.IsUpper(input);
            if (letter == true)
            {
                WriteLine("OK");

            }
            else if (input != '!')
            {
                WriteLine("Sorry - that was not an uppercase letter");

            }
        } while (input != '!');
    }
}
