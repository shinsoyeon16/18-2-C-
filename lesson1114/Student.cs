using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1114
{
    class Student
    {
        private string name;
        private int rollno;
        private int marks;
        public Student(string name, int rollno, int marks)
        {
            this.name = name;
            this.rollno = rollno;
            this.marks = marks;
        }
        public override string ToString()
        {
            return string.Format(" Name => {0}, RollNumber => {1}, Mark => {2} ", name, rollno, marks);
        }
        public static bool RhsIsGreater(object lhs, object rhs)
        {
            Student stdLhs = (Student)lhs;
            Student stdRhs = (Student)rhs;
            return (stdRhs.marks > stdLhs.marks);
        }
    }
}
