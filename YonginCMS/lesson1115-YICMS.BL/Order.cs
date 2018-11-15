using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1115_YICMS.BL
{
    class Order
    {
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public string shippingAddress { get; set; }

        public Order Retrieve()
        {
            return new Order();
        }
        public bool Save()
        {
            // Data Access 레이어의 객체를 생성, 호출해서 
            // 사용자 정보를 저장.
            return true;
        }
        public bool Validate()
        {
            var isValid = true;
            if (!Customer.Validate()) isValid = false;
            if (OrderDate==null) isValid = false;
            if (string.IsNullOrWhiteSpace(shippingAddress)) isValid = false;
            return isValid;
        }
    }
}
