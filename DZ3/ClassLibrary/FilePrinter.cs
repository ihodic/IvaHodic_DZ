using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibrary
{
    public class FilePrinter : IPrinter
    {
        public string fileName;
        public FilePrinter(string fileName)
        {
            this.fileName = fileName;
        }
        public void Print(string message)
        {
            string outputFileName = "storage.tv";
            using (var writer = new StreamWriter(outputFileName))
            {
                writer.WriteLine($"{message}");
            }
        }
    }
}
