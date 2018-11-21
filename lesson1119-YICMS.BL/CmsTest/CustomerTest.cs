using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YICMS.BL;

namespace CmsTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void GetCustomerListTest()
        {
            CustomerRepository cr = new CustomerRepository();
            var customerList = cr.Retrieve();

            Assert.IsNotNull(customerList);
            Assert.AreEqual(customerList[1].CustomerId, 2);
            Assert.AreEqual(customerList[1].LastName, "Baggins");
            Assert.AreEqual(customerList[1].FirstName, "Bilbo");
        }
    }
}
