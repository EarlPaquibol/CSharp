//Lambda in phyton to C#
public static class SpacesRemover
{
    public static string NoSpace(string input) => String.Concat(input.Split(" "));
}





//map or select
var square = numbers.Select(x => x * x);


//Filter or find all
List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);


//shortest word
return s.Split(' ').Min(x => x.Length);


//contains
return str.Count(i => "aeiou".Contains(i));


//count
return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');


//aggregate or map
var a = list.Aggregate((x, y) => x + y);
