using System;
using static System.Console;
static class AutomobileDemo2                     //extension methods can only be used in static classes
{
    static void Main()
    {
        FinancedAutomobile[] automobiles = new FinancedAutomobile[1];
        int x, y;
        double grandTotal = 0;
        double grandTotalFinanced = 0;
        bool goodNum;
        for (x = 0; x < automobiles.Length; ++x)
        {
            automobiles[x] = new FinancedAutomobile();
            Write("Enter automobile ID number ");
            automobiles[x].IdNumber = Convert.ToInt32(ReadLine());
            goodNum = true;
            for (y = 0; y < x; ++y)
            {
                if (automobiles[x].Equals(automobiles[y]))
                    goodNum = false;
            }
            while (!goodNum)
            {
                Write("Sorry, the ID number " +
                   automobiles[x].IdNumber + " is a duplicate. " +
                   "\nPlease reenter ");
                automobiles[x].IdNumber = Convert.ToInt32(ReadLine());
                goodNum = true;
                for (y = 0; y < x; ++y)
                {
                    if (automobiles[x].Equals(automobiles[y]))
                        goodNum = false;
                }
            }
            Write("Enter make ");
            automobiles[x].Make = ReadLine();
            Write("Enter year ");
            automobiles[x].Year = Convert.ToInt32(ReadLine());
            Write("Enter price ");
            automobiles[x].Price = Convert.ToDouble(ReadLine());
            Write("Enter financed price ");
            automobiles[x].AmtFinanced = Convert.ToDouble(ReadLine());
        }
        Array.Sort(automobiles);
        WriteLine("\nSummary:\n");
        for (x = 0; x < automobiles.Length; ++x)
        {
            WriteLine(automobiles[x].ToString());
            grandTotal += automobiles[x].Price;
            grandTotalFinanced += automobiles[x].AmtFinanced;
        }
        WriteLine("\nTotal for all Automobiles is " + grandTotal.ToString("C"));
        WriteLine("\nTotal financed all Automobiles is " + grandTotalFinanced.ToString("C"));
        double monthlyPayment;
        for (x = 0; x < automobiles.Length; ++x)
        {
            monthlyPayment = GetPaymentAmount(automobiles[x].AmtFinanced);
            WriteLine("\nMonthy payment for {0} is {1}", automobiles[x].Make, monthlyPayment);
        }
    }
    public static double GetPaymentAmount(this double num)          //extension method is placed with the Main() class. must use a public static and a this parameter to work.
    {
        double result = num * (0.0416667);
        return result;
    }
}

class Automobile : IComparable
{
    public Automobile(int num, string make, int year, double price)
    {
        IdNumber = num;
        Make = make;
        Year = year;
        Price = price;
    }
    public Automobile() : this(999, "ZZZ", 0, 0)
    {
    }
    public int IdNumber { get; set; }
    public string Make { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
    public override string ToString()
    {
        return (GetType() + " " + IdNumber + " " + Year +
           " " + Make + " Price is " + Price.ToString("C"));
    }
    public override bool Equals(Object e)
    {
        bool isEqual;
        Automobile temp = (Automobile)e;
        if (IdNumber == temp.IdNumber)
            isEqual = true;
        else
            isEqual = false;
        return isEqual;
    }
    public override int GetHashCode()
    {
        return IdNumber;
    }
    int IComparable.CompareTo(Object o)
    {
        int returnVal;
        Automobile temp = (Automobile)o;
        if (this.IdNumber > temp.IdNumber)
            returnVal = 1;
        else
           if (this.IdNumber < temp.IdNumber)
            returnVal = -1;
        else
            returnVal = 0;
        return returnVal;
    }
}
class FinancedAutomobile : Automobile
{
    public double AmtFinanced { get; set; }
    public override string ToString()
    {
        return (base.ToString() + " Amount financed " + AmtFinanced.ToString("C"));
    }
}
