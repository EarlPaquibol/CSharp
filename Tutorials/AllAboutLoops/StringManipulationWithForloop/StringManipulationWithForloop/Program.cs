using System;
using static System.Console;
class WebAddress
{
    static void Main()
    {
        string input;
        Write("Enter a web address >> ");
        input = ReadLine();
        string web = "";
        for (int x = 0; x < input.Length; ++x)
        {
            if (input.Substring(x, 1) != " ")      // (1,x) >>>> 1 is kung ilang letter kukunin mo. x is kung pang ilanng letter kukunin mo
            {
                web += input.Substring(x, 1);
            }
        }

        WriteLine("www.{0}.com", web);

    }
}


/* string newstring = input.Replace(" ", "");
        WriteLine(newstring); */
