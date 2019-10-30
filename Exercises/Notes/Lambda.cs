//Lambda in phyton to C#
public static class SpacesRemover
{
    public static string NoSpace(string input) => String.Concat(input.Split(" "));
}



// List to store numbers
        List<int> numbers = new List<int>() {36, 71, 12,
                             15, 29, 18, 27, 17, 9, 34};

        // foreach loop to dislay the list
        Console.Write("The list : ");
        foreach(var value in numbers)
        {
            Console.Write("{0} ", value);
        }
        Console.WriteLine();

        // Using lambda expression
        // to calculate square of
        // each value in the list
        var square = numbers.Select(x => x * x);


// Using Lambda exression to
        // find all numbers in the list
        // divisible by 3
        List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);


//shortest word
return s.Split(' ').Min(x => x.Length);


//contains
return str.Count(i => "aeiou".Contains(i));
