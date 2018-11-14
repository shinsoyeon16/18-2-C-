using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lesson1114.MainApp;

namespace lesson1114
{
    class BubbleSortClass
    {
        static public void Sort(object[] sortArray, CompareDelegate gtMethod)
        {
            for (int i = 0; i < sortArray.Length; i++)
            {
                for (int j = 0; j < sortArray.Length; j++)
                {
                    if (gtMethod(sortArray[j], sortArray[i]))
                    {
                        object temp = sortArray[i];
                        sortArray[i] = sortArray[j];
                        sortArray[j] = temp;
                    }
                }
            }
        }
    }
}
