using System;
using static System.Console;
using System.IO;
class DirectoryInformation
{
    static void Main()
    {
        string fileName;
        string[] listOfFiles;
        Write("Enter directory name: ");
        fileName = ReadLine();
        while (fileName != "end")
        {
            if (Directory.Exists(fileName))
            {
                WriteLine("\nDirectory exists");
                listOfFiles = Directory.GetFiles(fileName);
                for (int x = 0; x < listOfFiles.Length; ++x)
                {
                    WriteLine("{0}", listOfFiles[x]);
                }
            }
            else
            {
                WriteLine("\nDirectory {0} does not exist", fileName);
            }
            Write("Enter directory name: ");
            fileName = ReadLine();
        }

    }
}
