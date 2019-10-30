using System;

namespace Solution
{
    public static class SpacesRemover
    {
        public static string NoSpace(string input) => String.Concat(input.Split(" "));
    }
}
