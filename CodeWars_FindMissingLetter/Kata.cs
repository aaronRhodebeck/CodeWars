using System;

public class Kata
{
    private const string LowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
    private const string UppercaseAlphabet = "ABCDEFGHIJKLMNOPQRDTUVWXYZ";

    public static char FindMissingLetter(char[] array)
    {
        char[] alphabet = SelectAlphabet(array);
        var index = Array.IndexOf(alphabet, array[0]);
        char missingLetter;
        foreach (var letter in array)
        {
            if (letter != alphabet[index])
            {
                missingLetter = alphabet[index];
                return missingLetter;
            }
            index++;
        }
        throw new System.InvalidOperationException("Could not find missing letter");
    }

    private static char[] SelectAlphabet(char[] input)
    {
        if(LowercaseAlphabet.Contains(input[0].ToString()))
        {
            return LowercaseAlphabet.ToCharArray();
        }
        else if (UppercaseAlphabet.Contains(input[0].ToString()))
        {
            return UppercaseAlphabet.ToCharArray();
        }

        throw new System.ArgumentException("Input not part of the alphabet");
    }
}