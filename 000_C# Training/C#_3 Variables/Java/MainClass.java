import java.util.Scanner;

class MainClass
{
    public static String globalVariableInHomeClass = "DEF";

    public static void main(String[] args)
    {
        MyStrings();
        MyInts();
        MyArray();
        AccessGlobalVariables();

        new Scanner(System.in).nextLine();
    }  

    public static void MyStrings()
    {
        String myString1 = "ABC";
        String myString2 = "DEF";
        String myString3 = myString1 + myString2;
        System.out.println(myString3);
    } 

    public static void MyInts()
    {
        int myInt1 = 7;
        int myInt2 = 5;
        int myInt3 = myInt1 * myInt2;
        System.out.println(myInt3);
    }

    public static void MyArray()
    {
        String[] myStringArray = new String[] {"abc", "def", "ghi"};
        String myString = myStringArray[2];
        System.out.println(myString);

        String[] myStringArray2 = new String[3];
        myStringArray2[0] = "abc";
        myStringArray2[1] = "def";
        myStringArray2[2] = "ghi";
        System.out.println(myStringArray2[2]);
    }

    public static void AccessGlobalVariables()
    {
        String myConcatString = globalVariableInHomeClass + OtherClass.globalVariableInOtherClass;
        System.out.println(myConcatString);
    }

}