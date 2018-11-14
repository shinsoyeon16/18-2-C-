using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lesson1114
{
    class MainApp
    {
        // public delegate int AddDelegate(int num1, int num2);
        public delegate bool CompareDelegate(object lhs, object rhs);
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student("Mark", 1, 799),
                new Student("David", 2, 545),
                new Student("Lavish", 3, 999),
                new Student("Voora", 4, 228),
            new Student("Boll", 5, 768),
            new Student("Donna", 6, 367),
            new Student("Adam", 7, 799),
            new Student("Steve", 8, 867),
            new Student("Ricky", 9, 978),
            new Student("Brett", 10, 567)
            };
            CompareDelegate StudentCompareOp = new CompareDelegate(Student.RhsIsGreater);
            BubbleSortClass.Sort(students, StudentCompareOp);
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].ToString());
            }
            //    AddDelegate funct1 = new AddDelegate(Add);
            //    int k = funct1(7, 2);
            //    Console.WriteLine(" Sumation = {0}", k);
            //}
            //public static int Add(int num1, int num2)
            //{
            //    Console.WriteLine("I am called by Delegate");
            //    int sumation;
            //    sumation = num1 + num2;
            //    return sumation;
            //}
        }
    }
}