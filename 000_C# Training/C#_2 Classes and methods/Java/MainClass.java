import java.util.Scanner;

class MainClass
{
    public static void main(String[] args)
    {
        MethodInTheSameClass();
        OtherClass.MethodInAnotherClass();
        String returnValue = MethodReturningValue();
        System.out.println(returnValue);
        
        MethodReceivingValue("XYZ");

        new Scanner(System.in).nextLine();
    }

    public static void MethodInTheSameClass()
    {
        System.out.println("Hello, i am the method in the same class. I am void meaning that I don't return anything. My VBA counterpart would be 'Sub'");
    }

    public static String MethodReturningValue()
    {
        System.out.println("Hello, I return a string. So I need at least one time the key word 'return' followed by the string that I return. My VBA counterpart would be 'Function'");
        return "ABC";
    }

    public static void MethodReceivingValue(String receivedString)
    {
        System.out.println("Hello, I received the string " + receivedString + ".");
    }   
}