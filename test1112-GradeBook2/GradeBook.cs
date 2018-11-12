using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1112_GradeBook2
{
    public class GradeBook
    {
        List<float> grades;

        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        public int GetCount()
        {
            return grades.Count;
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
            stats.Avg = (sum-stats.Min) / (grades.Count-1);

            return stats;
        }
    }
}
