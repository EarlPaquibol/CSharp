using System.Linq;
using System;
using System.Collections.Generic;
public static class Kata
{
    static void Main()
    {
        Dictionary<String, String> pairs = new Dictionary<String, String> { {"A", "T" },{"C","G" },{"T", "A" },{"G", "C"} };
        string total = "";
        foreach (char x in dna)
        {
            total += pairs[x.ToString()];
        }

    }
}



//
public static string MakeComplement(string dna)
    {
        return string.Concat(dna.Select(GetComplement));
    }

    public static char GetComplement(char symbol)
    {
        switch (symbol)
        {
            case 'A':
                return 'T';
            case 'T':
                return 'A';
            case 'C':
                return 'G';
            case 'G':
                return 'C';
            default:
                throw new ArgumentException();
        }


using System;
using System.Collections.Generic;
using System.Linq;

public class DnaStrand
{
        private static Dictionary<char, char> map =
            new Dictionary<char, char>
            {
                {'T', 'A'},
                {'A', 'T'},
                {'C', 'G'},
                {'G', 'C'}
            };

        public static string MakeComplement(string dna)
        {

            var outChars = new String(dna.Select(x => map[x]).ToArray());

            return outChars;
        }
