using System;
using static System.Console;
class GreenvilleRevenue
{
    static void Main()
    {
        string entryString;
        int numThisYear;
        int numLastYear;
        Write("Enter number of contestants last year >> ");
        entryString = ReadLine();
        numLastYear = GetContestantNumber(entryString, 0, 30);
        Write("Enter number of contestants this year >> ");
        entryString = ReadLine();
        numThisYear = GetContestantNumber(entryString, 0, 30);
        DisplayRelationship(numThisYear, numLastYear);
        string[] names = new string[numThisYear];
        char[] talents = new char[numThisYear];
        char[] talentCodes = new char[] { 'S', 'D', 'M', 'O' };
        string[] talentCodesString = new string[4];
        int[] counts = new int[4];
        GetContestantData(numThisYear, names, talents, talentCodes, talentCodesString, counts);



    }
    public static int GetContestantNumber(string when, int min, int max)
    {
        int number = Convert.ToInt32(when);
        while (number < min || number > max)
        {
            WriteLine("Number must be between {0} and {1}", min, max);
            Write("Enter number of contestants last year >> ");
            when = ReadLine();
            number = Convert.ToInt32(when);
        }
        return number;
    }
    public static void DisplayRelationship(int numThisYear, int numLastYear)
    {
        int revenue;
        const int ENTRANCE_FEE = 25;
        revenue = numThisYear * ENTRANCE_FEE;
        WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants",
           numLastYear, numThisYear);
        WriteLine("Revenue expected this year is {0}", revenue.ToString("C"));
        if (numThisYear > 2 * numLastYear)
            WriteLine("The competition is more than twice as big this year!");
        else
           if (numThisYear > numLastYear)
            WriteLine("The competition is bigger than ever!");
        else
              if (numThisYear < numLastYear)
            WriteLine("A tighter race this year! Come out and cast your vote!");
    }
    public static void GetContestantData(int numThisYear, string[] names, char[] talents, char[] talentCodes, string[] talentCodesStrings, int[] counts)
    {
        int sing = 0, dance = 0, musical = 0, others = 0;
        char tempTalent;
        for (int x = 0; x < names.Length; ++x)
        {
            Write("Enter contestants names >> ");
            string tempName = ReadLine();
            names[x] = tempName;
            Write("Enter talent >> ");
            tempTalent = Convert.ToChar(ReadLine());
            while (tempTalent != 'S' && tempTalent != 'D' && tempTalent != 'M' && tempTalent != 'O')
            {
                WriteLine("Invalid talent.");
                Write("Enter talent >> ");
                tempTalent = Convert.ToChar(ReadLine());
            }
            talents[x] = tempTalent;
        }
        for (int i = 0; i < talents.Length; ++i)
        {
            int t = 0;
            if (talents[i] == talentCodes[t])
            {
                sing++;
                counts[t] = sing;

            }
            else if (talents[i] == talentCodes[t + 1])
            {
                dance++;
                counts[t + 1] = dance;

            }
            else if (talents[i] == talentCodes[t + 2])
            {
                musical++;
                counts[t + 2] = musical;

            }
            else if (talents[i] == talentCodes[t + 3])
            {
                others++;
                counts[t + 3] = others;

            }

        }
        GetLists(numThisYear, talentCodes, talentCodesStrings, names, talents, counts);

    }
    public static void GetLists(int numThisYear, char[] talentCodes, string[] talentCodesStrings, string[] names, char[] talents, int[] counts)
    {

        Write("Enter talent code >> ");
        char temp = Convert.ToChar(ReadLine());
        while (temp != 'Z')
        {

            int t = 0;
            WriteLine("The types of talent are: ");
            WriteLine("Singing              {0}", counts[t]);
            WriteLine("Dancing              {0}", counts[t + 1]);
            WriteLine("Musical instrument   {0}", counts[t + 2]);
            WriteLine("Other                {0}", counts[t + 3]);
            Write("\nContestants with talent Musical Instrument are: ");
            for (int x = 0; x < names.Length; ++x)
            {
                if (talents[x] == 'M')
                {
                    Write(("{0} "), names[x]);
                }
            }
            Write("\nContestants with talent Dancing are: ");
            for (int x = 0; x < names.Length; ++x)
            {
                if (talents[x] == 'D')
                {
                    Write(("{0} "), names[x]);
                }
            }
            Write("\nContestants with talent Singing are: ");
            for (int x = 0; x < names.Length; ++x)
            {
                if (talents[x] == 'S')
                {
                    Write(("{0} "), names[x]);
                }
            }
            Write("\nContestants with talent Others are: \n");
            for (int x = 0; x < names.Length; ++x)
            {
                if (talents[x] == 'O')
                {
                    Write(("{0} "), names[x]);
                }
            }
            Write("Enter talent code >> ");
            temp = Convert.ToChar(ReadLine());
        }

    }
}