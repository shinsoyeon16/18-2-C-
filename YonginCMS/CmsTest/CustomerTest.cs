using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lesson1115_YICMS.BL;

namespace CmsTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TFullNameTest()
        {
            //준비
            Customer cs = new Customer();
            cs.FirstName = "Soyeon";
            cs.LastName = "Shin";
            string expected = "Shin, Soyeon";
            //실행
            var actual = cs.FullName;
            //비교, Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TFullNameFirstNameEmptytest()
        {
            //준비
            Customer cs = new Customer();
            cs.LastName = "Shin";
            string expected = "Shin";
            //실행
            var actual = cs.FullName;
            //비교,Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TCustomerTest()
        {
            //준비
            Customer cs = new Customer();
            cs.LastName = "Shin";
            cs.FirstName = "Soyeon";
            cs.EmailAddress = "shinsoyeon16@yi.ac.kr";
            cs.HomeAddress = "용인시 처인구";
            cs.WorkAddress = "서울시 광진구";

            bool expected = true;
            //실행
            var actual = cs.Validate();
            //비교,Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TProductTest()
        {
            //준비
            Product p = new Product();
           p.

            bool expected = true;
            //실행
            var actual = cs.Validate();
            //비교,Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TOrderTest()
        {
            //준비
            Customer cs = new Customer();
            cs.LastName = "Shin";
            string expected = "Shin";
            //실행
            var actual = cs.FullName;
            //비교,Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TOrderItemTest()
        {
            //준비
            Customer cs = new Customer();
            cs.LastName = "Shin";
            string expected = "Shin";
            //실행
            var actual = cs.FullName;
            //비교,Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
