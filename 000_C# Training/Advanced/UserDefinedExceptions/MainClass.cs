using System;

class MainClass
{
    public static void Main()
    {
        string myWord = Console.ReadLine();
        string status = CheckMyWord(myWord);

        Console.WriteLine(status);
        Console.ReadLine();
    }

    public static string CheckMyWord(string word)
    {
        if (word == "forbiddenWord")
            throw new MyException("You have used the forbidden word");
        
        return word + " OK";
    }
}