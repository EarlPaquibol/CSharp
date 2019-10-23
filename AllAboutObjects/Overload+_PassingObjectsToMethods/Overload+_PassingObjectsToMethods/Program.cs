using static System.Console;
using System;
class SalesTransactionDemo
{
    static void Main()
    {
        SalesTransaction one = new SalesTransaction("Employee 1", 22.1, 0.3);
        SalesTransaction two = new SalesTransaction("Employee 2", 22.1, 0.3);
        Display(one);
        Display(two);
        SalesTransaction three;
        three = one + two;
        DisplayTotal(three);
    }
    public static void Display(SalesTransaction s)
    {
        WriteLine("{0} {1} {2}", s.Name, s.SalesAmount, s.getRate());

    }
    public static void DisplayTotal(SalesTransaction s)
    {
        WriteLine(s.SalesAmount);
    }
}


class SalesTransaction
{
    public string Name;
    public double SalesAmount;
    public double Commission;
    private readonly double RATE;

    public SalesTransaction(string Name, double SalesAmount, double Commission)
    {
        this.Name = Name;
        this.SalesAmount = SalesAmount;
        RATE = Commission;
        this.Commission = RATE * SalesAmount;


    }

    public SalesTransaction(string Name, double SalesAmount)
    {
        this.Name = Name;
        this.SalesAmount = SalesAmount;
        this.Commission = 0;
        RATE = 0;

    }

    public SalesTransaction(string Name)
    {
        this.Name = Name;
        this.SalesAmount = 0;
        this.Commission = 0;
        RATE = 0;
    }

    public double getRate()
    {
        return RATE;
    }

    public static SalesTransaction operator +(SalesTransaction one, SalesTransaction two)
    {
        double ey = one.SalesAmount + two.SalesAmount;
        return (new SalesTransaction(null, ey));

    }
}
