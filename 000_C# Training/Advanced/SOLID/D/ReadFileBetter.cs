using System.IO;
using System;
using System.Text;

namespace MyProject
{
    public class ReadFileBetter : IReadFile
    {
        public string Run(string fileName)
        {
            StringBuilder sb = new StringBuilder();

            byte[] buffer = new byte[16];
            int readBytes;

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                while ((readBytes = fs.Read(buffer, 0, buffer.Length)) > 0)
                    for (int i=0;i<readBytes;i++)
                        sb.Append((char)buffer[i]);
            }

            return sb.ToString();
        }
    }
}