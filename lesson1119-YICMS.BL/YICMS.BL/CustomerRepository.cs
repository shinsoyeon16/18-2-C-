using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YICMS.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepositore { get; set; }

        public CustomerRepository()
        {
            addressRepositore = new AddressRepository();
        }

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepositore.
                RetrieveByCustomerId(customerId).ToList();

            return customer;
        }

        public List<Customer> Retrieve()
        {
            InvoiceRepository invoiceRepository = new InvoiceRepository();

           List<Customer> custList = new List<Customer>
            {
                new Customer()
                {
                    CustomerId = 1,
                    FirstName = "Frodo",
                    LastName = "Baggins",
                    EmailAddress = "fb@hob.me",
                    CustomerTypeId=1,
                    InvoiceList = invoiceRepository.Retrieve(1) },
                new Customer()
                {
                    CustomerId = 2,
                    FirstName = "Bilbo",
                    LastName = "Baggins",
                    EmailAddress = "bb@hob.me",
                    CustomerTypeId=null,
                    InvoiceList = invoiceRepository.Retrieve(2) },
                new Customer()
                {
                    CustomerId = 3,
                    FirstName = "SamWise",
                    LastName = "Gamgee",
                    EmailAddress = "sg@hob.me",
                    CustomerTypeId=4,
                    InvoiceList = invoiceRepository.Retrieve(3) },
                new Customer()
                {
                    CustomerId = 4,
                    FirstName = "Rosie",
                    LastName = "Cotton",
                    EmailAddress = "rc@hob.me",
                    CustomerTypeId=2,
                    InvoiceList = invoiceRepository.Retrieve(4) } };

            return custList;
        }
        public bool Save(Customer customer) { return true; }
    }
}
