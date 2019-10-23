using System;
using static System.Console;
using System.IO;
class WritePatientRecords
{
    static void Main()
    {
        const string DELIM = ",";
        Patient[] retard = new Patient[1];
        FileStream outFile = new FileStream("Patients.txt", FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(outFile);
        for (int x = 0; x < retard.Length; ++x)
        {
            retard[x] = new Patient();
            Write("Enter patients id: ");
            retard[x].IdNumber = ReadLine();
            Write("Enter patients name: ");
            retard[x].Name = ReadLine();
            Write("Enter patients balance: ");
            retard[x].Balance = Convert.ToDouble(ReadLine());
            writer.WriteLine(retard[x].IdNumber + DELIM + retard[x].Name + DELIM + retard[x].Balance + DELIM);
        }
        writer.Close();
        outFile.Close();

    }
}


class Patient
{
    public string IdNumber { get; set; }
    public string Name { get; set; }
    public double Balance { get; set; }
}


// p#, PATIENT_NAME, BALANCE