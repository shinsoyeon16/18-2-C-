using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YICMS.BL
{
    class AddressRepository
    {
        /// <summary>
        /// Retrieve one address.
        /// </summary>
       public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int CustomerId)
        {
            var addressList = new List<Address>();
            return addressList;
        }
        public bool Save()
        {
            return true;
        }
    }
}
