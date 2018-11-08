using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1106
{
    class Program
    {
        enum DialogResult { YES=100, NO, CANCLE };
        static void Main(string[] args)
        {

            //정수형과 문자열형 변환 방법
            // int a = 123;
            // //object b = a;
            // //int c = (int)b;

            // //Console.WriteLine(a);
            // //Console.WriteLine(b);
            // //Console.WriteLine(c);

            //string b=a.ToString();
            // Console.WriteLine(b);

            // float c = 3.14f;
            // string d = c.ToString();
            // Console.WriteLine(d);

            // string g = "12.345";
            // float h = float.Parse(g);

            // Console.WriteLine(h);




            //열거형 사용방법, 널값 사용 관련
            //DialogResult ans;

            ////int a; // int ? a; 로 하면 널값 넣을 수 있음  
            //int? a;  //a 가 nullable 타입일때만 a.value 와 a.hasvalue 사용가능
            //a = null; //c#은 변수에 널값을 넣는 것을 허용하지 않음
            //Console.WriteLine(a.HasValue);
            //// Console.WriteLine(a.Value); //널값일 경우 오류나는 문장

            //a = 10;
            //Console.WriteLine(a.HasValue);
            //Console.WriteLine(a.Value);

            //ans = DialogResult.YES;
            //Console.WriteLine(ans);
            //Console.WriteLine((int)ans);

            //ans = DialogResult.CANCLE;
            //Console.WriteLine(ans);
            //Console.WriteLine((int)ans);

            var a = 20;
            Console.WriteLine("Type : {0}, Value : {1}", a.GetType(), a);
            Console.WriteLine($"Type : {a.GetType()}, Value : {a}");

            var b = "Hello World!";
            Console.WriteLine($"Type : {b.GetType()}, Value : {b}");

            var d = new int[] { 10, 20, 30 };
            Console.Write($"Type : {d.GetType()}, Value : ");
            foreach(var e in d)
            {
                Console.Write($" {e} ");
            }
                       
        }
    }
}
