import java.util.Scanner;
import java.util.Date; 
import java.text.SimpleDateFormat;  


class MainClass
{
    public static void main(String[] args)
    {
        IntDouble();
        IntByte();
        IntToString();
        StringToInt();
        StringToByteArray();
        ByteArrayToString();
        StringToDate();
        DateToString();
        new Scanner(System.in).nextLine();
    }

    public static void IntDouble()
    {
        int myInt = 32;

        double myDouble = (double)myInt;

        System.out.println(myDouble);

        myInt = (int)myDouble;

        System.out.println(myInt);
    }

    public static void ByteToChar()
    {
        byte myDecimal = 65;
        char myChar = (char)myDecimal;
        System.out.println(myChar);
    }

    public static void IntByte()
    {
        int myInt = 257;
        byte myByte = (byte)myInt; //this won't produce an error, but will give a wrong result, because Byte contains only 256 signs

        System.out.println(myByte);
    }

    public static void IntToString()
    {
        int myInt = 257;
        String myString = Integer.toString(myInt);

        System.out.println(myString);
    }

    public static void StringToInt()
    {
        String myString = "2i57";
        //int myInt = (int)myString; this is the standard approach (using cast), but casting does not always work, for example here

        try
        {
            int myInt = Integer.parseInt(myString);
            System.out.println(myInt);
        }
        catch (NumberFormatException ex)
        {
            System.out.println("NOT A NUMBER"); 
        }     
    }

    public static void StringToByteArray()
    {
        String myString = "2i57";
        byte[] myByteArray = myString.getBytes();

        for (byte myByte : myByteArray)
        {
            System.out.println(myByte + "    " + (char)myByte);
        }
    }

    public static void ByteArrayToString()
    {
        // Attention bytes in Java are signed
        // in C# they are unsigned, so 128 to 255 in C# will be -128 to -1 in java
        byte[] myByteArray = new byte[] {222-256, 0, 22, 0, 167-256, 0, 34, 0};

        String myString = new String(myByteArray);

        System.out.println(myString);
    }

    public static void StringToDate()
    {
        String myDateString = "22.03.1986 10:32";
        SimpleDateFormat format = new SimpleDateFormat("dd.MM.yyyy HH:mm");
        
        try
        {
            Date myDate = format.parse(myDateString);
            System.out.println(myDate);
        }
        catch (Exception ex) {}
    }

    public static void DateToString()
    {
        Date myDate = new Date();
        SimpleDateFormat format = new SimpleDateFormat("dd.MM.yyyy HH:mm:ss");
        String myString = format.format(myDate);
        System.out.println(myString);
    }
}