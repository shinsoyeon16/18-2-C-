using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1115_YICMS.BL
{
    class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; } = '0';
        public int PurchasePrice { get; set; } = '0';

        public OrderItem Retrieve()
        {
            return new OrderItem();
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
            if (!Product.Validate()) isValid = false;
            if (Quantity==0) isValid = false;
            if (PurchasePrice==0) isValid = false;
            return isValid;
        }

    }
}
