using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1112
{
    class FileLogger : ILogger
    {
        private StreamWriter writer;
        public FileLogger()
        {
            writer = File.AppendText("a.txt");
            writer.AutoFlush = true;
        }
        public void WriteLogFile(string message)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
}
