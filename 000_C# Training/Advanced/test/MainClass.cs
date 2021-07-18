using System;

public class MainClass
{
    public static bool IsPalindrome(string word)
    {
        int maxIndex = word.Length / 2;
        
        for (int i=0;i<=maxIndex;i++)
        {
            Console.WriteLine(word[i] + " " + word[word.Length - i - 1]);
            if (word[i] != word[word.Length - i - 1])
                return false;
        }
        return true;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome("Deleveled"));
    }
}