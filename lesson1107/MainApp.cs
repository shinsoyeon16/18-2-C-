using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1107
{
    class MainApp
    {
        public static void Swap(ref int a, ref int b)
        {
            int t = b;
            b = a;
            a = t;
        }
        static void Main(string[] args)
        {
            //5장 반복문
            //object obj = null;

            //String s = Console.ReadLine();
            //if (int.TryParse(s, out int out_i))
            //    obj = out_i;
            //else if (float.TryParse(s, out float out_f))
            //    obj = out_f;
            //else 
            //    obj = s;

            //switch(obj)
            //{
            //    case int i:
            //        Console.WriteLine($"{i}는 int"); break;
            //    case float f:
            //        Console.WriteLine($"{f}는 float"); break;
            //    default:
            //        Console.WriteLine($"{obj}는 모르는 형식입니다.");break;
            //}

            //6장
            int x = 3, y = 5;
            Console.WriteLine($"x={x}, y={y}");
            Swap(ref x, ref y);
            Console.WriteLine($"x={x}, y={y}");
        }
    }
}
