using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1112
{
    class FileLogger : Logger, ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
            this.WriteMyLog("Log파일 생성");
        }
        public void WriteMyLog(string message)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
}