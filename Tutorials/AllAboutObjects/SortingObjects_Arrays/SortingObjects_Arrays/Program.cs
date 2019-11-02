using System;
using static System.Console;
class ConferencesDemo
{
    static void Main()
    {

        Conference[] sort = new Conference[3];

        for (int x = 0; x < sort.Length; ++x)
        {
            sort[x] = new Conference();
        }
        for (int i = 0; i < sort.Length; ++i)
        {
            string temp;
            Write("enter event >> ");
            temp = ReadLine();
            sort[i].Group = temp;
            Write("enter date >> ");
            temp = ReadLine();
            sort[i].Date = temp;
            Write("enter number of attendees >> ");
            temp = ReadLine();
            int re;
            while (!Int32.TryParse(temp, out re))
            {
                WriteLine("invalid input");
                Write("enter number of attendees >> ");
                temp = ReadLine();
            }
            sort[i].Attendees = re;
        }
        Array.Sort(sort);
        for (int z = 0; z < sort.Length; ++z)
        {
            WriteLine("{0} Conference starts on {1} and has {2} attendees", sort[z].Group, sort[z].Date, sort[z].Attendees);
        }

    }
}

class Conference : IComparable
{
    private string group;
    private string date;
    private int attendees;

    public string Group
    {
        get
        {
            return group;
        }
        set
        {
            group = value;
        }
    }
    public string Date
    {
        get
        {
            return date;
        }
        set
        {
            date = value;
        }
    }

    public int Attendees
    {
        get
        {
            return attendees;
        }
        set
        {
            attendees = value;
        }
    }

    int IComparable.CompareTo(Object a)
    {
        int returnVal;
        Conference temp = (Conference)a;
        if (this.attendees > temp.attendees)
        {
            returnVal = 1;
        }
        else if (this.attendees < temp.attendees)
        {
            returnVal = -1;
        }
        else
            return 0;

        return returnVal;
    }



}
