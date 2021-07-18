using System;

class MainClass
{
    public static void Main()
    {
        MethodInTheSameClass();
        OtherClass.MethodInAnotherClass();
        string returnValue = MethodReturningValue();
        Console.WriteLine(returnValue);
        
        MethodReceivingValue("XYZ");

        Console.ReadLine();
    }

    public static void MethodInTheSameClass()
    {
        Console.WriteLine("Hello, i am the method in the same class. I am void meaning that I don't return anything. My VBA counterpart would be 'Sub'");
    }

    public static string MethodReturningValue()
    {
        Console.WriteLine("Hello, I return a string. So I need at least one time the key word 'return' followed by the string that I return. My VBA counterpart would be 'Function'");
        return "ABC";
    }

    public static void MethodReceivingValue(string receivedString)
    {
        Console.WriteLine("Hello, I received the string " + receivedString + ".");
    }   
}

class OtherClass
{
    public static void MethodInAnotherClass()
    {
        Console.WriteLine("Hello, I am the method in another class");
    }
}