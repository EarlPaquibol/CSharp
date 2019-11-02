using static System.Console;
class Flights
{
    static void Main()
    {
        string output;
        int tempo;
        int flight = 0;
        string code = "";
        int[] flightNumbers = { 201, 321, 510, 633 };
        string[] codes = { "AUS", "CRP", "DFW", "HOU" };
        string[] names = { "Austin", "Corpus Christi", "Dallas Fort Worth", "Houston" };
        string[] times = { "0710", "0830", "0915", "1140" };
        Write("Enter flight number or flight code >> ");
        string temp = ReadLine();
        if (!int.TryParse(temp, out tempo))
        {
            code = temp;
            output = GetFlightInfo(code, flightNumbers, codes, names, times);
        }
        else
        {
            flight = tempo;
            output = GetFlightInfo(flight, flightNumbers, codes, names, times);
        }
        WriteLine(output);
    }

    public static string GetFlightInfo(int flight, int[] flightNumbers, string[] codes, string[] names, string[] times)
    {
        int y = 0;
        string random = "";
        for (int x = 0; x < flightNumbers.Length; ++x)
        {
            if (flight == flightNumbers[x])
            {
                random = $"Flight #{flight} {codes[x]} {names[x]} Scheduled at: {times[x]}\n";
                y++;
                break;
            }
        }
        if (y == 0)
        {
            random = $"Flight #{flight} was not found";
        }
        return random;
    }
    public static string GetFlightInfo(string code, int[] flightNumbers, string[] codes, string[] names, string[] times)
    {
        string random = "";
        int y = 0;
        for (int x = 0; x < flightNumbers.Length; ++x)
        {
            if (code == codes[x])
            {
                random = $"Flight #{flightNumbers[x]} {code} {names[x]} Scheduled at: {times[x]}";
                y++;
                break;
            }
        }
        if (y == 0)
        {
            random = $"Flight #{code} was not found";
        }
        return random;
    }
}