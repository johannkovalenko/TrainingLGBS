using System.Net.Sockets;
using System.Net;
using System.Text;
using System;
using System.Threading;
using System.IO;

public class MainClass
{
    public static void Main()
    {
        Standard();
        StandardAddHeaders();
        StandardAddBody();
        StandardWithProxy();
        LowLevel();

        Console.ReadLine();
    }

    public static void Standard()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://ws17236894-lpa.ads.dlh.de:9000");
        Request(request);
    }

    public static void StandardAddHeaders()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://ws17236894-lpa.ads.dlh.de:9000");
        request.ContentType = "text/html";
        request.Headers.Add("MyParameter", "MyValue");
        Request(request);
    }

    public static void StandardAddBody()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://ws17236894-lpa.ads.dlh.de:9000");

        string requestBody = "This is the request body";
        byte[] bytes = Encoding.ASCII.GetBytes(requestBody);

        request.Method = "POST";
        request.GetRequestStream().Write(bytes, 0, bytes.Length);

        Request(request);
    }

    public static void StandardWithProxy()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://news.orf.at");

        IWebProxy proxy = request.Proxy; 

        if (proxy != null)
        {
            Console.WriteLine(proxy.GetProxy(request.RequestUri));

            WebProxy myProxy = new WebProxy();
            Uri proxyAddress = new Uri("http://prx-fralh-v01.sec.fra.dlh.de:8080/");
            myProxy.Address = proxyAddress;
            myProxy.Credentials = new NetworkCredential("u540929", "x2jQwh3V");
            request.Proxy = myProxy;
        }

        Request(request);
    }

    public static void Request(HttpWebRequest request)
    {
        HttpWebResponse response;

        try
        {
            response = (HttpWebResponse)request.GetResponse();
            Read(response);
        }
        catch (WebException ex)
        {
            using (WebResponse webResponse = ex.Response)
            {
                response = (HttpWebResponse) webResponse;
                Read(response);
            }
        }
    }

    public static void Read(HttpWebResponse response)
    {
        int responseCode = (int)response.StatusCode;
        string answer;

        using (Stream s = response.GetResponseStream())
        using (StreamReader sr = new StreamReader(s))
        {
            answer = sr.ReadToEnd();
        }

        Console.WriteLine(responseCode);
        Console.WriteLine(answer);
    }

    public static void LowLevel()
    {
        byte[] bytes;
        int bytesRead;
        StringBuilder sb = new StringBuilder();

        using (TcpClient client = new TcpClient("57.20.206.17", 9000))
        using (NetworkStream ns = client.GetStream())
        {
            string rawRequest = "POST /index.html HTTP/1.1\r\nContent-Type: text/html\r\n\r\nThis is the request body";
            bytes = Encoding.ASCII.GetBytes(rawRequest);

            ns.Write(bytes, 0, bytes.Length);

            bytes = new byte[8192];

            bytesRead = ns.Read(bytes, 0, bytes.Length);

            for (int i=0;i<bytesRead;i++)
                sb.Append((char)bytes[i]);

            Console.WriteLine(sb.ToString());
        }
    }
}