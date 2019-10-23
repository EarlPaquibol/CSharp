using System;
using static System.Console;
class HomeSales
{
    static void Main()
    {
        char input;
        decimal totald = 0, totale = 0, totalf = 0;
        decimal diego = 0, earl = 0, fork = 0;
        do
        {
            Write("Enter your initial >> "); //d or e or f
            input = Convert.ToChar(ReadLine());
            if (input == 'D' || input == 'd')
            {
                Write("Enter amount of sales >> ");
                diego = Convert.ToInt32(ReadLine());
                totald += diego;


            }
            else if (input == 'E' || input == 'e')
            {
                Write("Enter amount of sales >> ");
                earl = Convert.ToInt32(ReadLine());
                totale += earl;


            }
            else if (input == 'F' || input == 'f')
            {
                Write("Enter amount of sales >> ");
                fork = Convert.ToInt32(ReadLine());
                totalf += fork;


            }
            else if (input == 'z' || input == 'Z')
            {
                WriteLine("Total sales of D is >> ${0:0.00}", totald);
                WriteLine("Total sales of E is >> ${0:0.00}", totale);
                WriteLine("Total sales of F is >> ${0:0.00}", totalf);
                WriteLine("Grand total for all sales ${0:0.00}", (totald + totale + totalf));
                if (totale > totalf && totale > totald)
                {
                    WriteLine("Person with highest total sales is E");
                }
                else if (totalf > totale && totalf > totald)
                {
                    WriteLine("Person with highest total sales is F");
                }
                else
                {
                    WriteLine("Person with highest total sales is D");
                }
            }
            else
            {
                WriteLine("Invalid input");
            }
        } while (input != 'Z' && input != 'z');
    }
}
