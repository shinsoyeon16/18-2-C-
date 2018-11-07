using System;
using test1106;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test1106.Test

{
    [TestClass]
    public class GradeBookTest
    {
        [TestMethod]
        public void TestMin()
        {
            //준비
            GradeBook  book = new GradeBook();
            GradeStatistics stat;
            book.AddGrade(10);
            book.AddGrade(90);
            //실행
            stat = book.ComputeStatistics();
            //확인
            Assert.AreEqual(stat.Min, 11);
        }
    }
}