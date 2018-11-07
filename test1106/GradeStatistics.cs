using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1106
{
    public class GradeStatistics
    { 
        public float Max;
        public float Min;
        public float Avg; //art 누르고 줄잡으면 동일부분 선택가능, 변수이름바꿀때 바로가기메뉴에서 바꾸면 전체코드 다 바꿔줌

        public GradeStatistics() //ctor 탭탭 누르면 생성자 만들어줌
        {
            Min = float.MaxValue;
            Max = 0;
        }
    }
}
