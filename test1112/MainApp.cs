using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace test1112
{
    class MainApp
    {
        static FileLogger logger = new FileLogger("randomLogFile.txt"); //로그를 저장할 파일 생성
        static void Main(string[] args)
        {
            Timer timer = new System.Timers.Timer();
            timer.Interval = 1000; //1초마다 반복되도록 설정
                                   //1초마다 timer_event 메소드 실행
            timer.Elapsed += new ElapsedEventHandler(timer_event);
            timer.Start();

            Console.WriteLine("(Log 저장 종료 키 : 엔터키)");
            Console.ReadLine();
        }

        //난수 생성 후 파일과 콘솔에 출력하는 메소드
        private static void timer_event(object sender, ElapsedEventArgs e)
        {
            Random r = new Random(); //랜덤 수 생성을 위한 r객체 생성
            logger.WriteMyLog("   " + r.Next());
            logger.WriteLog("저장된 수: " + r.Next(int.MinValue, int.MaxValue));
            throw new NotImplementedException();
        }
    }

