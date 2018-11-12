using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////디펜더스
//ExInterface a = new ExInterface(ILogger a = new FileLogger()); 
//ExInterface a = new ExInterface(ILogger a = new ConsoleLogger());

namespace lesson1112 // 인터페이스를 사용하여 클래스 호출하는 쪽에서 컨트롤하기 연습
{
    class ExInterface
    {
        //ILogger logger;
        //public ExInterface(ILogger logger)
        //{
        //    this.logger = logger;
        //}

        static void Main(string[] args) // 메인클래스가 서브함수에 의해 바뀌고, 의존성이 심한 상태임 - 해결방법1 인터페이스
        {

            ConsoleLogger logger = new ConsoleLogger();
            logger.WriteLog("Hello!");
            logger.WriteLog("hahah!!!");

            //// 클래스 변경시 메인클래스가 서브함수에 의해 바뀌고, 의존성이 심한 상태임
            //FileLogger loggers = new FileLogger();  
            //loggers.WriteLogFile("Hello!");
            //loggers.WriteLogFile("hahaha!!");

            //// 해결방법1 인터페이스
            //ILogger loggerc = new ConsoleLogger();
            //loggerc.WriteLog("Hello!");
            //loggerc.WriteLog("hahah!!!");

            //ILogger loggerf = new FileLogger(); 
            //loggerf.WriteLogFile("Hello!");
            //loggerf.WriteLogFile("hahaha!!");


        }
    }
}
