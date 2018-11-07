using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1106
{
    public class GradeBook
    {
        GradeStatistics stats;
        List<float> grades;

        public GradeBook()
        {
             grades = new List<float>();
        }
       
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0;
            foreach (float v in grades)
            {
                stats.Min = Math.Min(v, stats.Min);
                stats.Max = Math.Max(v, stats.Max);
                sum += v;
            }
            stats.Avg = sum / grades.Count();
            return stats;
        }
    }
}
