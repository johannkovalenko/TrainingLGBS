using System;

class MainClass
{
    public static void Main()
    {
        CompareStrings_Convenient();
        CompareStrings_Correct();
        CompareString_CaseInsensitive();
        ConcatenateStrings();
        ConcatenateStringIteratively();
        LengthOfString();
        SplitStringBySingleChar();
        SplitStringByString();
        GetFirstFourSigns();
        GetFirstFourSigns_Safe();
        GetLastFourSigns();
        GetLastFourSigns_Safe();
        GetSignsBetween();
        CheckIfStringContainsSubstring();
        GetPositionWhereSubsubstringAppearsInString();
        GetPositionWhereSubsubstringAppearsInString_FromRight();
        RestOfStringAfterKeyWord();
        ReplaceStringWithSubstring();
        DateToStringWithFormat();
        NumberToStringWithLeadingZeros();
        CreateStringWithEnterAndCarriageReturn();

        Console.ReadLine();
    }

    public static void CompareStrings_Convenient()
    {
        string myString = "abc";
        string myString2 = "aef";

        if (myString == myString2)
            Console.WriteLine("Strings are equal");
        else
            Console.WriteLine("Strings are not equal");

        //Attention, in Java and C++, this approach would not work
        //See CompareStrings_Correct()
    }

    public static void CompareStrings_Correct()
    {
        string myString = "abc";
        string myString2 = "aef";

        if (myString.Equals(myString2))
            Console.WriteLine("Strings are equal");
        else
            Console.WriteLine("Strings are not equal");
    }        

    public static void CompareString_CaseInsensitive()
    {
        string myString = "AbCDeF";
        string myString2 = "abcdef";

        if (myString.ToLower() == myString2.ToLower())
            Console.WriteLine("Strings are equal");
        else
            Console.WriteLine("Strings are not equal");

        if (myString.ToUpper() == myString2.ToUpper())
            Console.WriteLine("Strings are equal");
        else
            Console.WriteLine("Strings are not equal");        

    }

    public static void ConcatenateStrings()
    {
        string myString = "Lgbs";
        string myString2 = "Mnl";
        string myString3 = "Krk";

        string myString4 = "We work at " + myString + " " + myString2 + " and " + myString3;
        
        Console.WriteLine(myString4);
    }

    public static void ConcatenateStringIteratively()
    {
        string[] myArray = new string[] {"abc", "def", "ghi", "jkl"};
        string myFinalString = "";

        foreach (string singleString in myArray)
            myFinalString += singleString + "__";  

        Console.WriteLine(myFinalString);
    }

    public static void LengthOfString()
    {
        string myString = "LgbsMnlKrk";
        int length = myString.Length;
        Console.WriteLine(length);
    }

    public static void SplitStringBySingleChar()
    {
        string myString = "abc;def;ghi;jkl";

        string[] mySplitString = myString.Split(';');

        foreach (string singleString in mySplitString)
            Console.WriteLine(singleString);
    }

    public static void SplitStringByString()
    {
        string myString = "abc;_def;_ghi;_jkl";

        string[] mySplitString = myString.Split(new string[] {";_"}, StringSplitOptions.None);

        foreach (string singleString in mySplitString)
            Console.WriteLine(singleString);        
    }

    public static void GetFirstFourSigns()
    {
        string myString = "LgbsKrkMnl";
        string leftFourSigns = myString.Substring(0, 4);
        Console.WriteLine(leftFourSigns);
        // Attention, when myString has less than four signs, an error will be thrown. 
        // See GetFirstFourSigns_Safe() to handle this problem
    }

    public static void GetFirstFourSigns_Safe()
    {
        string myString = "LgbsKrkMnl";
        string leftFourSigns = "";

        if (myString.Length >= 4)
            leftFourSigns = myString.Substring(0, 4);
        else
            leftFourSigns = myString;

        Console.WriteLine(leftFourSigns);
    }

    public static void GetLastFourSigns()
    {
        string myString = "LgbsKrkMnl";
        string rightFourSigns = myString.Substring(myString.Length - 4);
        Console.WriteLine(rightFourSigns);
    }

    public static void GetLastFourSigns_Safe()
    {
        string myString = "LgbsKrkMnl";
        string rightFourSigns = "";
    
        if (myString.Length >= 4)
            rightFourSigns = myString.Substring(myString.Length - 4);
        else
            rightFourSigns = myString;

        Console.WriteLine(rightFourSigns);
    }

    public static void GetSignsBetween()
    {
        string myString = "LgbsKrkMnl";
        string thirdToFifthSign = myString.Substring(2, 3);
        Console.WriteLine(thirdToFifthSign);
    }

    public static void CheckIfStringContainsSubstring()
    {
        string myString = "LgbsKrkMnl";
        string mySubstring = "Krk";

        if (myString.Contains(mySubstring))
            Console.WriteLine("Contains");
        else
            Console.WriteLine("Does not contain");
    }

    public static void GetPositionWhereSubsubstringAppearsInString()
    {
        string myString = "LgbsKrkMnl";
        string mySubstring = "Krk";

        int pos = myString.IndexOf(mySubstring);

        Console.WriteLine(pos);
    }

    public static void GetPositionWhereSubsubstringAppearsInString_FromRight()
    {
        string myString = "LgbsKrkMnlKrk";
        string mySubstring = "Krk";

        int pos = myString.LastIndexOf(mySubstring);

        Console.WriteLine(pos);
    }

    public static void RestOfStringAfterKeyWord()
    {
        string myString = "LgbsKrkMnl";
        string mySubstring = "Krk";
        string restOfString = "";

        int firstSign = myString.IndexOf(mySubstring);

        if (firstSign == -1)
            firstSign = 0;
        else
            firstSign = firstSign + 3;

        restOfString = myString.Substring(firstSign);

        Console.WriteLine(restOfString);
    }

    public static void ReplaceStringWithSubstring()
    {
        string myString = "LgbsKrkMnl";
        string replaceWhat = "Krk";
        string tobeReplacedWith = "hoho";

        myString = myString.Replace(replaceWhat, tobeReplacedWith);

        Console.WriteLine(myString);
    }

    public static void DateToStringWithFormat()
    {
        DateTime myDate = DateTime.Now;
        string myString = myDate.ToString("dd.MM.yyyy HH:mm:ss");
        Console.WriteLine(myString);
    }

    public static void NumberToStringWithLeadingZeros()
    {
        int myInt = 33;
        int myInt2 = 3;
        string myString = "";
        
        myString = "000" + myInt.ToString();
        myString = myString.Substring(myString.Length - 3);
        Console.WriteLine(myString);

        myString = "000" + myInt2.ToString();
        myString = myString.Substring(myString.Length - 3);
        Console.WriteLine(myString);        
    }

    public static void CreateStringWithEnterAndCarriageReturn()
    {
        string myString = "abc\r\ndef\r\nghi";
        Console.WriteLine(myString);

        myString = "abc" + (char)13 + (char)10 + "def" + (char)13 + (char)10 + "ghi";
        Console.WriteLine(myString);
    }
}