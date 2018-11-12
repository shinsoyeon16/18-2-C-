using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1112_GradeBook2
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            Min = float.MaxValue;
            Max = 0;
        }

        public float Min;
        public float Max;
        public float Avg;
    }
}
