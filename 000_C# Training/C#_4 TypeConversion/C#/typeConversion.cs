using System;

class MainClass
{
    public static void Main()
    {
        IntDouble();
        IntByte();
        IntToString();
        StringToInt();
        StringToByteArray();
        ByteArrayToString();
        StringToDate();
        DateToString();
        Console.ReadLine();
    }

    public static void IntDouble()
    {
        int myInt = 32;

        double myDouble = (double)myInt;

        Console.WriteLine(myDouble);

        myInt = (int)myDouble;

        Console.WriteLine(myInt);
    }

    public static void ByteToChar()
    {
        byte myDecimal = 65;
        char myChar = (char)myDecimal;
        Console.WriteLine(myChar);
    }

    public static void IntByte()
    {
        int myInt = 257;
        byte myByte = (byte)myInt; //this won't produce an error, but will give a wrong result, because Byte contains only 256 signs

        Console.WriteLine(myByte);
    }

    public static void IntToString()
    {
        int myInt = 257;
        string myString = myInt.ToString();

        Console.WriteLine(myString);
    }

    public static void StringToInt()
    {
        string myString = "2i57";
        //int myInt = (int)myString; this is the standard approach (using cast), but casting does not always work, for example here

        int myInt;

        if(int.TryParse(myString, out myInt))
            Console.WriteLine(myInt);
        else
            Console.WriteLine("NOT A NUMBER");      
    }

    public static void StringToByteArray()
    {
        string myString = "2i57";
        byte[] myByteArray = System.Text.Encoding.ASCII.GetBytes(myString);

        foreach (byte myByte in myByteArray)
        {
            Console.WriteLine(myByte + "    " + (char)myByte);
        }
    }

    public static void ByteArrayToString()
    {
        
        byte[] myByteArray = new byte[] {222, 0, 22, 0, 167, 0, 34, 0};

        string myString = System.Text.Encoding.ASCII.GetString(myByteArray);

        Console.WriteLine(myString);
    }

    public static void StringToDate()
    {
        string myDateString = "22.03.1986 10:32";

        DateTime myDate;
        
        bool sukces = DateTime.TryParseExact(myDateString, "dd.MM.yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out myDate);

        Console.WriteLine(myDate + "\t" + sukces);
    }

    public static void DateToString()
    {
        DateTime myDate = DateTime.Now;
        string myString = myDate.ToString("dd.MM.yyyy HH:mm:ss");
        Console.WriteLine(myString);
    }
}