using System.Net.Sockets;
using System.Net;
using System.Text;
using System;
using System.Threading;

public class MainClass
{
    public static NetworkStream ns;
    public static void Main()
    {
        TcpListener server = new TcpListener(IPAddress.Parse("57.20.206.17"), 9000);
        server.Start();

        TcpClient client;

        while (true)
        {
            client = server.AcceptTcpClient();
            ns = client.GetStream();
            new Thread(ReadAndWrite).Start();
        }
    }

    public static void ReadAndWrite()
    {
        StringBuilder sb = new StringBuilder();
        byte[] bytes = new byte[1024];
        int bytesRead;

        bytesRead = ns.Read(bytes, 0, bytes.Length);

        for (int i=0;i<bytesRead;i++)
            sb.Append((char)bytes[i]);

        Console.WriteLine(sb.ToString());
        
        string response = "HTTP/1.0 200 OK\r\nContent-Type: text/html\r\n\r\n<html><body><h1>Answer</h1></body></html>";
        bytes = Encoding.ASCII.GetBytes(response);
        ns.Write(bytes, 0, bytes.Length);
        ns.Close();

        sb.Clear();
    }

}