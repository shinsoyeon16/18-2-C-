using System;

namespace lesson1112
{
    internal class ConsoleLogger : ILogger
    {
        public string Name { get; set; }    //자동으로 getter와 setter를 생성 //public이면 대문자로, private면 언더바로 시작

        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
        
    }
}