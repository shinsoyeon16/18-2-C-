using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1115_YICMS.BL
{
    class Product
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public Decimal CurrentPrice { get; set; } = '0';
        public int ProductId { get; set; }

        public Product Retrieve()
        {
            return new Product();
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
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (string.IsNullOrWhiteSpace(ProductDescription)) isValid = false;
            if (CurrentPrice==0) isValid = false;
            return isValid;
        }

    }
}
