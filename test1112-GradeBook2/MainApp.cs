using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1112_GradeBook2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            GradeStatistics stats;

            int num = 0;
            while (true)
            {
                Console.WriteLine("성적을 입력하세요. (종료키 : -1)");
                num = int.Parse(Console.ReadLine());
                if (num == -1) break;
                book.AddGrade(num);
            }

            stats = book.ComputeStatistics();

            Console.WriteLine("전체 학생 수 : "+book.GetCount());
            Console.WriteLine("최저 점수 : " + stats.Min);
            Console.WriteLine("최고 점수 : " + stats.Max);
            Console.WriteLine("최저 점수를 제외한 평균 점수 : " + stats.Avg);
        }
    }
}