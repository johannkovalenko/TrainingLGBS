using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        string txt = "AbCdEfGhIjKlMnOpQrStUvWxYZ1234567890!@#$";

        for (int i = 0; i < txt.Length; i++)
            if (txt[i] >= 65 && txt[i] <= 90)
                sb.Append((char)(txt[i] | 32));
            else
                sb.Append((char)txt[i]);

        Console.WriteLine(sb.ToString());
        Console.ReadLine();
    }
}
