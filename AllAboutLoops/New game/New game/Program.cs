using System;
using static System.Console;

class CountVowels
{
    static void Main()
    {
        char again;
        do
        {
            int min = 1, max = 10;
            Random idiot = new Random();
            int randomNumber = idiot.Next(min, max);
            Write("Enter a guess between 1 and 10 >> ");
            int guess = Convert.ToInt32(ReadLine());
            while (guess != randomNumber)
            {
                Write("Guess again >> ");
                guess = Convert.ToInt32(ReadLine());
            }
            WriteLine("Congrats, you guessed right!");
            WriteLine("Do you want to play again? Y/n");
            again = Convert.ToChar(ReadLine());
            while (again != 'Y' && again != 'y' && again != 'N' && again != 'n')
            {
                WriteLine("I said enter fucking y or n");
                again = Convert.ToChar(ReadLine());
            }
        } while (again != 'n' && again != 'N');

    }
}