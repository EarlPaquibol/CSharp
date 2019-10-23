using System;
using static System.Console;
class GuessingGame
{
    static void Main()
    {
        int min = 1, max = 11;
        Random ranNumberGenerator = new Random();
        int randomNumber, input;
        randomNumber = ranNumberGenerator.Next(min, max);

        Write("Enter a number between 1 and 10 >> ");
        input = Convert.ToInt32(ReadLine());



        if (randomNumber == input)
        {
            WriteLine("The random number is >> {0}", randomNumber);
            WriteLine("Your guess is correct");
        }
        else
        {
            if (randomNumber > input)
            {
                WriteLine("The random number is >> {0}", randomNumber);
                WriteLine("Your guess was too low");
            }
            else
            {
                WriteLine("The random number is >> {0}", randomNumber);
                WriteLine("Your guess was too high");
            }
        }
    }
}
