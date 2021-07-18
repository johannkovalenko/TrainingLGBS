import java.util.Scanner;
import java.util.Date; 
import java.text.SimpleDateFormat;  

class MainClass
{
    public static void main(String[] args)
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

        new Scanner(System.in).nextLine();
    }

    public static void CompareStrings_Convenient()
    {
        //Attention, in Java and C++, this approach does not work
        //See CompareStrings_Correct()
    }

    public static void CompareStrings_Correct()
    {
        String myString = "abc";
        String myString2 = "aef";

        if (myString.equals(myString2))
            System.out.println("Strings are equal");
        else
            System.out.println("Strings are not equal");
    }        

    public static void CompareString_CaseInsensitive()
    {
        String myString = "AbCDeF";
        String myString2 = "abcdef";

        if (myString.toLowerCase().equals(myString2.toLowerCase()))
            System.out.println("Strings are equal");
        else
            System.out.println("Strings are not equal");

        if (myString.toUpperCase().equals(myString2.toUpperCase()))
            System.out.println("Strings are equal");
        else
            System.out.println("Strings are not equal");        

    }

    public static void ConcatenateStrings()
    {
        String myString = "Lgbs";
        String myString2 = "Mnl";
        String myString3 = "Krk";

        String myString4 = "We work at " + myString + " " + myString2 + " and " + myString3;
        
        System.out.println(myString4);
    }

    public static void ConcatenateStringIteratively()
    {
        String[] myArray = new String[] {"abc", "def", "ghi", "jkl"};
        String myFinalString = "";

        for (String singleString : myArray)
            myFinalString += singleString + "__";  

        System.out.println(myFinalString);
    }

    public static void LengthOfString()
    {
        String myString = "LgbsMnlKrk";
        int length = myString.length();
        System.out.println(length);
    }

    public static void SplitStringBySingleChar()
    {
        String myString = "abc;def;ghi;jkl";

        String[] mySplitString = myString.split(";");

        for (String singleString : mySplitString)
            System.out.println(singleString);
    }

    public static void SplitStringByString()
    {
        String myString = "abc;_def;_ghi;_jkl";

        String[] mySplitString = myString.split(";_");

        for (String singleString : mySplitString)
            System.out.println(singleString);        
    }

    public static void GetFirstFourSigns()
    {
        String myString = "LgbsKrkMnl";
        String leftFourSigns = myString.substring(0, 4); 
        //Attention: C#: Substring(index first signs, number of signs)
        //          Java: substring(index first sign, index last sign + 1)
        System.out.println(leftFourSigns);
        // Attention, when myString has less than four signs, an error will be thrown. 
        // See GetFirstFourSigns_Safe() to handle this problem
    }

    public static void GetFirstFourSigns_Safe()
    {
        String myString = "LgbsKrkMnl";
        String leftFourSigns = "";

        if (myString.length() >= 4)
            leftFourSigns = myString.substring(0, 4);
        else
            leftFourSigns = myString;

        System.out.println(leftFourSigns);
    }

    public static void GetLastFourSigns()
    {
        String myString = "LgbsKrkMnl";
        String rightFourSigns = myString.substring(myString.length() - 4);
        System.out.println(rightFourSigns);
    }

    public static void GetLastFourSigns_Safe()
    {
        String myString = "LgbsKrkMnl";
        String rightFourSigns = "";
    
        if (myString.length() >= 4)
            rightFourSigns = myString.substring(myString.length() - 4);
        else
            rightFourSigns = myString;

        System.out.println(rightFourSigns);
    }

    public static void GetSignsBetween()
    {
        String myString = "LgbsKrkMnl";
        String thirdToFifthSign = myString.substring(2, 5);
        System.out.println(thirdToFifthSign);
    }

    public static void CheckIfStringContainsSubstring()
    {
        String myString = "LgbsKrkMnl";
        String mySubstring = "Krk";

        if (myString.contains(mySubstring))
            System.out.println("Contains");
        else
            System.out.println("Does not contain");
    }

    public static void GetPositionWhereSubsubstringAppearsInString()
    {
        String myString = "LgbsKrkMnl";
        String mySubstring = "Krk";

        int pos = myString.indexOf(mySubstring);

        System.out.println(pos);
    }

    public static void GetPositionWhereSubsubstringAppearsInString_FromRight()
    {
        String myString = "LgbsKrkMnlKrk";
        String mySubstring = "Krk";

        int pos = myString.lastIndexOf(mySubstring);

        System.out.println(pos);
    }

    public static void RestOfStringAfterKeyWord()
    {
        String myString = "LgbsKrkMnl";
        String mySubstring = "Krk";
        String restOfString = "";

        int firstSign = myString.indexOf(mySubstring);

        if (firstSign == -1)
            firstSign = 0;
        else
            firstSign = firstSign + 3;

        restOfString = myString.substring(firstSign);

        System.out.println(restOfString);
    }

    public static void ReplaceStringWithSubstring()
    {
        String myString = "LgbsKrkMnl";
        String replaceWhat = "Krk";
        String tobeReplacedWith = "hoho";

        myString = myString.replace(replaceWhat, tobeReplacedWith);

        System.out.println(myString);
    }

    public static void DateToStringWithFormat()
    {
        Date myDate = new Date();
        SimpleDateFormat format = new SimpleDateFormat("dd.MM.yyyy HH:mm:ss");
        String myString = format.format(myDate);
        System.out.println(myString);
    }

    public static void NumberToStringWithLeadingZeros()
    {
        int myInt = 33;
        int myInt2 = 3;
        String myString = "";
        
        myString = "000" + Integer.toString(myInt);
        myString = myString.substring(myString.length() - 3);
        System.out.println(myString);

        myString = "000" + Integer.toString(myInt2);
        myString = myString.substring(myString.length() - 3);
        System.out.println(myString);        
    }

    public static void CreateStringWithEnterAndCarriageReturn()
    {
        String myString = "abc\r\ndef\r\nghi";
        System.out.println(myString);

        myString = "abc" + (char)13 + (char)10 + "def" + (char)13 + (char)10 + "ghi";
        System.out.println(myString);
    }
}