using System.IO;
using System;

namespace MyProject
{
    public class ReadFile : IReadFile
    {
        public string Run(string fileName)
        {
            return File.ReadAllText(fileName);
        }
    }
}