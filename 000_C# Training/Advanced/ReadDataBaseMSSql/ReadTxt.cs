using System.IO;
using System.Collections.Generic;

namespace FSO
{
    public class ReadTxt : List<string[]>
    {
        public ReadTxt(string fileName)
        {
            string[] rawLines = File.ReadAllLines(fileName);

            foreach (string rawLine in rawLines)
                base.Add(rawLine.Split(';'));
        }
    }
}