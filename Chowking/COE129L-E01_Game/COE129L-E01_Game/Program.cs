//Roll the dice. First to setVictory wins.


using System;
using static System.Console;

class Game
{
    static void Main()
    {
        char again = 'y';
        do
        {
            Random dice = new Random();
            int roll;
            int victory;
            int moveOne = 0, moveTwo = 0;
            int oneTotal = 0, twoTotal = 0;
            int overVictory = 0, overVictoryTwo = 0;
            int i = 0;
            string oneName, twoName;
            Write("Enter name for player one: ");
            oneName = ReadLine();
            Write("Enter name for player two: ");
            twoName = ReadLine();
            Write("First to number of stars? ");
            victory = Convert.ToInt32(ReadLine());
            while (oneTotal <= victory && twoTotal <= victory)
            {
                WriteLine("{0}, press any key to roll the dice ", oneName);
                ReadKey();
                roll = dice.Next(1, 6);
                moveOne = roll;
                oneTotal += moveOne;
                WriteLine("{0} rolled the dice for {1}", oneName, moveOne);
                if (oneTotal == victory)
                {
                    Write("{0}: ", oneName);
                    for (i = 0; i < oneTotal; ++i)
                    {
                        Write("*");
                    }
                    Write(" Stars({0})", oneTotal);
                    WriteLine("");
                    WriteLine("--------------------------------------");
                    break;
                }
                else if (oneTotal > victory)
                {
                    overVictory = oneTotal - victory - 1;
                    WriteLine("Oops, you went over the victory by {0}", overVictory);
                    oneTotal = oneTotal - (moveOne + overVictory);
                    oneTotal = Math.Abs(oneTotal);
                }
                Write("{0}: ", oneName);
                for (i = 0; i < oneTotal; ++i)
                {
                    Write("*");
                }
                Write(" Stars({0})", oneTotal);
                WriteLine("");
                WriteLine("--------------------------------------");
                WriteLine("{0}, press any key to roll the dice", twoName);
                ReadKey();
                roll = dice.Next(1, 6);
                moveTwo = roll;
                twoTotal += moveTwo;
                WriteLine("{0} rolled the dice for {1}", twoName, moveTwo);
                if (twoTotal == victory)
                {
                    Write("{0}: ", twoName);
                    for (i = 0; i < twoTotal; ++i)
                    {
                        Write("*");
                    }
                    Write(" Stars({0})", twoTotal);
                    WriteLine("");
                    WriteLine("--------------------------------------");
                    break;
                }
                else if (twoTotal > victory)
                {
                    overVictoryTwo = twoTotal - victory - 1;
                    WriteLine("Oops, you went over the victory by {0}", overVictoryTwo);
                    twoTotal = twoTotal - (moveTwo + overVictoryTwo);
                    twoTotal = Math.Abs(twoTotal);
                }
                Write("{0}: ", twoName);
                for (i = 0; i < twoTotal; ++i)
                {
                    Write("*");
                }
                Write(" Stars({0})", twoTotal);
                WriteLine("");
                WriteLine("--------------------------------------");
            }
            if (oneTotal > twoTotal)
                WriteLine("{0}, you won the game!", oneName);
            else
                WriteLine("{0}, you won the game!", twoName);
            Write("Do you want to play again? Y/N ");
            again = Convert.ToChar(ReadLine());
            while (again != 'Y' && again != 'y' && again != 'N' && again != 'n')
            {
                WriteLine("Invalid input");
                Write("Do you want to play again? Y/N ");
                again = Convert.ToChar(ReadLine());
            }
        }
        while (again != 'N' && again != 'n');
    }
}