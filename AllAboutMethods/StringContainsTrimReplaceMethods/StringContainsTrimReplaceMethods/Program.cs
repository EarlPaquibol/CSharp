using static System.Console;
using System;
public class Auction
{
    static void Main()
    {
        const int min = 10;
        int temp;
        double ey;
        WriteLine("Hey enter a fucking number >> ");
        string input = ReadLine();
        if (input.Contains("$") || input.Contains("dollars"))
        {
            AcceptBid(input, min);
        }
        else if (!int.TryParse(input, out temp))
        {
            ey = Convert.ToDouble(input);
            AcceptBid(ey, min);
        }
        else if (int.TryParse(input, out temp) == true)
        {
            AcceptBid(temp, min);
        }

    }

    public static void AcceptBid(int bid, int min)
    {
        if (bid < min)
        {
            Write("Bid not high enough");
        }
        else
        {
            Write("Bid accepted");
        }
    }
    public static void AcceptBid(double bid, int min)
    {
        if (bid < min)
        {
            Write("Bid not high enough");
        }
        else
        {
            Write("Bid accepted");
        }
    }
    public static void AcceptBid(string bid, int min)
    {
        string temp = "";
        if (bid.Contains("$") || bid.Contains("dollars"))
        {
            if (bid.Contains("1") || bid.Contains("2") || bid.Contains("3") || bid.Contains("4") || bid.Contains("5")
                || bid.Contains("6") || bid.Contains("7") || bid.Contains("8") || bid.Contains("9") || bid.Contains("0"))
            {
                temp = bid.Replace("dollars", "").Replace("$", "");
                int num = Convert.ToInt32(temp);
                if (num < min)
                {
                    Write("Bid not high enough");
                }
                else
                {
                    Write("Bid accepted");
                }
            }
            else
            {
                Write("Bid was not in correct format");
            }


        }

    }

}