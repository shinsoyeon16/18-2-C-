using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1105
{

    class MainApp
    {

        //static void Main(string[] args) //수업예제 이름받아서 args문자열 출력해보기
        //{
        //    Console.WriteLine("이름입력하세여");
        //    var name = Console.ReadLine(); //약한 형식 지정 변수선언!  .. 로컬변수선언시에만 var 예약어를 쓸수있다
        //    Console.WriteLine($"your name is {name} !"); //딸라 붙이면 큰따옴표안에 있는 인수들을 문자열이 아닌 인수자체로 해석해줌
        //}

        static void Main(string[] args) //과제 수면시간 받아 출력하기
        {
            Console.WriteLine("얼마나 주무셨나요?");
            int sleeptime = Console.Read();
            if (sleeptime > 8)
            {
                Console.WriteLine("많이 주무셨네요!!!");
            }
            else
            {
                Console.WriteLine("충분한 수면이 필요합니다!!!");
            }

        }
    }
}

//lesson1105.exe soyeon seohee
//    args[0] = "soyeon"
//    args[1] = "seohee"
