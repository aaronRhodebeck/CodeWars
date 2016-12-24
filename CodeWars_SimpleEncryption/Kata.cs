using System;
using System.Text;

public class Kata
{
    public static string Encrypt(string text, int n)
    {
        if (String.IsNullOrEmpty(text) || n < 1)
        {
            return text;
        }
        else
        {
            text = ShiftLetters(text);
            n--;
            return Encrypt(text, n);
        }
    }

    private static string ShiftLetters(string text)
    {
        var encryptedText = new StringBuilder();

        for (int i = 1; i < text.Length; i += 2)
        {
            encryptedText.Append(text[i]);
        }
        for (int i = 0; i < text.Length; i += 2)
        {
            encryptedText.Append(text[i]);
        }

        return encryptedText.ToString();
    }


    public static string Decrypt(string encryptedText, int n)
    {
        if (String.IsNullOrEmpty(encryptedText) || n < 1)
        {
            return encryptedText;
        }
        else
        {
            encryptedText = ShiftLettersBackwards(encryptedText);
            n--;
            return Decrypt(encryptedText, n);
        }
    }

    private static string ShiftLettersBackwards(string encryptedText)
    {
        var decryptedText = new StringBuilder();
        int midpoint = encryptedText.Length / 2;
        var firstHalfText = encryptedText.Remove(midpoint);
        var secondHalfText = encryptedText.Substring(midpoint);
        
        for (int i = 0; i < encryptedText.Length; i++)
        {
            if (i % 2 == 0)
            {
                decryptedText.Append(secondHalfText[i/2]);
            }
            else
            {
                decryptedText.Append(firstHalfText[i/2]);
            }
        }

        return decryptedText.ToString();
    }
}