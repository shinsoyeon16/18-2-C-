using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1115_YICMS.BL
{
    public class Customer
    {
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string FirstName { get; set; } //자동 프로퍼티
        public string FullName
        {
            get {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                    return fullName; }
        }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
        public int CustomerId { get; private set; }

        public Customer Retrieve()
        {
            return new Customer();
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
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            if (string.IsNullOrWhiteSpace(HomeAddress)) isValid = false;
            if (string.IsNullOrWhiteSpace(WorkAddress)) isValid = false;
            return isValid;
        }
    }
}
