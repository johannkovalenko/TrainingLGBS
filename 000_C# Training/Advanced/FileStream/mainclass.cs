using System.IO;
using System;
using System.Text;

public class MainClass
{
    public static void Main()
    {
        //InputStream();
        //OutputStream();
        Reader();
        //Writer();

        Console.ReadLine();
    }

    public static void InputStream()
    {
        byte[] bytes = new byte[16];
        int bytesRead;
        StringBuilder sb = new StringBuilder();

        using (FileStream fs = new FileStream("textexample.txt", FileMode.Open))
        {
            while ((bytesRead = fs.Read(bytes, 0, bytes.Length)) > 0)
                for (int i=0;i<bytesRead;i++)
                    sb.Append((char)bytes[i]);

            Console.WriteLine(sb.ToString());
        } 
    }

    public static void OutputStream()
    {
        using (FileStream fs = new FileStream("textexample.txt", FileMode.Append))
        {
            string textToAppend = "\r\nThis is a test.";
            byte[] bytes = Encoding.ASCII.GetBytes(textToAppend);
            
            fs.Write(bytes, 0, bytes.Length);
        } 
    }

    public static void Reader()
    {
        string rawText;

        using (FileStream fs = new FileStream("textexample.txt", FileMode.Open))
        using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
        {
            while ((rawText = sr.ReadLine()) != null)
                Console.WriteLine(rawText);

            //.Read() .ReadToEnd()
        } 
    }

    public static void Writer()
    {
        using (FileStream fs = new FileStream("textexample.txt", FileMode.Append))
        using (StreamWriter sw = new StreamWriter(fs))
        {
            string textToAppend = "\r\nThis is a test.";

            sw.Write(textToAppend);

            //.WriteLine()
        } 
    }

}