using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hi ^> there << I'm+ telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later.";
        string output = CleanText(input);
        Console.WriteLine(output);
    }

    static string CleanText(string input)
    {
        // Define a regular expression pattern to match unwanted characters
        string pattern = @"[\^<>&+@%$]";
        
        // Use Regex.Replace to replace unwanted characters with an empty string
        string cleanedText = Regex.Replace(input, pattern, "");
        
        return cleanedText;
    }
}