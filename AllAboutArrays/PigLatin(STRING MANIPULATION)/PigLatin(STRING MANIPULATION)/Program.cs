using System;
using static System.Console;

class Planet
{
    static void Main()
    {
        const string noob = "ay";
        string word;
        WriteLine("Enter a word: ");
        word = ReadLine();
        string FirstLetter = word.Substring(0, 1); //example "love" , word.Substring(0, 1) =  "l"
        string translated = word.Substring(1);     //example "love", word.Substring(1) = "ove"
        WriteLine("Pig latin of the word {0} is {1}", word, translated + FirstLetter + noob);


    }
}