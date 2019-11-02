using static System.Console;
using System;
public class TestClassifiedAd
{
    public static void Main()
    {
        ClassifiedAd first = new ClassifiedAd();
        ClassifiedAd second = new ClassifiedAd();
        first.Category = "Used cars";
        second.Category = "Help Wanted";
        first.Words = 100;
        second.Words = 60;
        double ey = first.Price;
        double eyy = second.Price;


        WriteLine("The classified ad with {0} words in category {1} costs {2}", first.Words, first.Category, ey.ToString("C"));
        WriteLine("The classified ad with {0} words in category {1} costs {2}", second.Words, second.Category, eyy.ToString("C"));
    }
}
class ClassifiedAd
{
    private int numofwords;
    public const double pricePerWord = 0.09;
    private double price;
    public string Category { get; set; }
    public int Words
    {
        get
        {
            return numofwords;
        }
        set
        {
            numofwords = value;
            CalcPrice();
        }
    }


    public double Price
    {
        get
        {
            return price;
        }
    }

    private void CalcPrice()
    {
        price = numofwords * pricePerWord;
    }
}
