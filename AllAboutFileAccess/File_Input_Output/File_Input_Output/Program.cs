using System;
using static System.Console;
using System.IO;


class File
{
    static void Main()
    {
        FileStream outFile = new FileStream("HeyThere.txt", FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(outFile);
        WriteLine("What do you want to write?");
        string input = ReadLine();
        writer.WriteLine(input);
        writer.Close();
        outFile.Close();
    }
}

