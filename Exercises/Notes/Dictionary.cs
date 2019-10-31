Dictionary<String, String> pairs = new Dictionary<String, String> { {"A", "T" },{"C","G" },{"T", "A" },{"G", "C"} };
string total = "";
foreach (char x in dna)
{
    total += pairs[x.ToString()];
}

///////////////////////////////////////////
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

//https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/
Dictionary<int, string> My_dict1 =
                       new Dictionary<int, string>();
 My_dict1.Add(1123, "Welcome");
          My_dict1.Add(1124, "to");
          My_dict1.Add(1125, "GeeksforGeeks");

          foreach(KeyValuePair<int, string> ele1 in My_dict1)
          {
              Console.WriteLine("{0} and {1}",
                        ele1.Key, ele1.Value);
          }
