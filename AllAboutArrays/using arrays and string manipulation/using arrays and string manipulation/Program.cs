using System;
using static System.Console;
//PIGLATIN USING ARRAY
class Planet
{
    const string Pig = "ay";

    static void Main()
    {
        string translation = ""; // initialize the final output
        string input;
        WriteLine("Enter a phrase: ");
        input = ReadLine();
        string[] tempInput = input.Split(" ");    //takes input and splits the phrase into words removing the spaces and stores to tempINput
        for (int i = 0; i < tempInput.Length; i++)
        {
            translation += getPigLatin(tempInput[i]);    //store the word in getpiglatin to tempinput         
        }
        WriteLine("Pig latin:");
        WriteLine(translation);
    }
    static string getPigLatin(string input)
    {
        string word;
        string firstLetter = input.Substring(0, 1);
        string leftOver = input.Substring(1);
        word = leftOver + firstLetter + Pig + " ";
        return (word);    //return the word to the main function

    }
}