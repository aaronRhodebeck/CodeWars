using System;
using System.Collections.Generic;
using System.Linq;

public static class MorseCodeDecoder
{   
    public static string Decode(string morseCode)
    {
        var morseCodeDictionary = MorseCodeDictionary.morseCode;

        string[] morseCodeLetters = morseCode.Trim().Split();
        string[] translation = new string[morseCodeLetters.Length];

        for (int i = 0; i < morseCodeLetters.Length; i++)
        {
            if(morseCodeLetters[i] == string.Empty)
            {
                translation[i] = " ";
                i++;
            }
            else
            {
                translation[i] = morseCodeDictionary
                .FirstOrDefault(x => x.Value == morseCodeLetters[i])
                .Key
                .ToUpper();
            }
        }
        return String.Join("", translation);
    }

    private static class MorseCodeDictionary
    {
        public static Dictionary<string, string> morseCode = new Dictionary<string, string>()
        {
            {"0", "-----"},
            {"1", ".----"},
            {"2", "..---"},
            {"3", "...--"},
            {"4", "....-"},
            {"5", "....."},
            {"6", "-...."},
            {"7", "--..."},
            {"8", "---.."},
            {"9", "----."},
            {"a", ".-"},
            {"b", "-..."},
            {"c", "-.-."},
            {"d", "-.."},
            {"e", "."},
            {"f", "..-."},
            {"g", "--."},
            {"h", "...."},
            {"i", ".."},
            {"j", ".---"},
            {"k", "-.-"},
            {"l", ".-.."},
            {"m", "--"},
            {"n", "-."},
            {"o", "---"},
            {"p", ".--."},
            {"q", "--.-"},
            {"r", ".-."},
            {"s", "..."},
            {"t", "-"},
            {"u", "..-"},
            {"v", "...-"},
            {"w", ".--"},
            {"x", "-..-"},
            {"y", "-.--"},
            {"z", "--.."},
            {".", ".-.-.-"},
            {",", "--..--"},
            {"?", "..--.."},
            {"!", "-.-.--"},
            {"-", "-....-"},
            {"/", "-..-."},
            {"@", ".--.-."},
            {"(", "-.--."},
            {")", "-.--.-"},
            {"/n", ".-.-" },
            {"End of message", ".-.-."},
            {"Wait", ".-..."},
            {"Break", "-...-.-"},
            {"New paragraph", "-...-"},
            {"Going off the air", "-.-..-.."},
            {"Start copying", "-.-.-"},
            {"SOS", "...---..."}
        };
    }
}