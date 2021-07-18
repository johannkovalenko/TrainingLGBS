using System;
using System.Diagnostics;
using System.IO;

class MainClass
{
    public static void Main()
    {
        StandardOut();
        StandardIn();
    }

    public static void StandardOut()
    {
        ProcessStartInfo startInfo = new ProcessStartInfo()
        {
            WindowStyle = ProcessWindowStyle.Normal,
            Arguments = "",
            FileName = "consolewrite.exe",
            CreateNoWindow = false,
            RedirectStandardOutput = true,
            RedirectStandardInput = true,
            UseShellExecute = false
        };

        Process myProcess = new Process()
        {
            StartInfo = startInfo
            //EnableRaisingEvents = true
        };

        myProcess.OutputDataReceived += new DataReceivedEventHandler
        (
            delegate(object sender, DataReceivedEventArgs e)
            {
                Console.WriteLine(e.Data);
            }
        );

        myProcess.Start();
        myProcess.BeginOutputReadLine();
        myProcess.WaitForExit();
    }
}