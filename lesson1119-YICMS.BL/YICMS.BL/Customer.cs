using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YICMS.BL
{
    class Customer
    {
        public Customer() :this(0) { }
        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public int CustomerType { get; set; }
        public int? CustomerTypeId { get; set; }
        public static int InstanceCount { get; set; }

        //public Address HomeAddress { get; set; }
        //public Address WorkAddress { get; set; }
        private string _lastName;
        public string LastName {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string  FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; set; }
        public string FullName {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public Customer Retrieve()
        {
            return new Customer();
        }
    }
}
