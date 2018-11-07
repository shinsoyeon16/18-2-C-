using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1106
{
    class MainApp
    {
        
        static void Main(string[] args)
        {
            GradeStatistics stats;
            GradeBook book = new GradeBook();
            book.AddGrade(80);
            book.AddGrade(90);
            book.AddGrade(77);
            book.AddGrade(11);
            book.AddGrade(28);

            stats = book.ComputeStatistics();

            Console.WriteLine(stats.Max);
            Console.WriteLine(stats.Min);
            Console.WriteLine(stats.Avg);

            //  float grade;
            //  float maxGrade = 0.0f;
            //  float minGrade = 100.0f;
            //  float round = 0.0f;
            //    int cnt = 0;

            //    while (true)
            //    {
            //        Console.WriteLine("성적을 입력하세요 (종료: -1)");
            //        grade = float.Parse(Console.ReadLine());
            //        if (grade == -1) break;
            //        else if (round == 0)
            //        {
            //            maxGrade = grade;
            //            minGrade = grade;
            //        }
            //        else
            //        {
            //            if (maxGrade < grade) maxGrade = grade;
            //            if (minGrade > grade) minGrade = grade;
            //        }
            //        round += grade;
            //        cnt++;
            //    }
            //    round /= (float)cnt;
            //    Console.WriteLine($"최고성적: {maxGrade}, 최저성적: {minGrade}, 평균: {round}");
            }
        }
    }
