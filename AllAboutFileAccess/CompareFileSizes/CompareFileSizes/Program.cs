using System;
using static System.Console;
using System.IO;
class FileComparison
{
    static void Main()
    {
        long size1, size2;
        FileInfo fileInfo = new FileInfo("C:/Users/earli/Desktop/HelloWorld.txt");
        size1 = fileInfo.Length;
        fileInfo = new FileInfo("C:/Users/earli/Desktop/Subomo.txt");
        size2 = fileInfo.Length;
        WriteLine("The size of the Word file is {0} " +
                    "and the size of the Notepad file is {1} " +
                    "The Notepad file is {2} % of the size of the " +
                    "Word file", size2, size1, 0.13);
    }
}