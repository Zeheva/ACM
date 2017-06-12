using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {

        public Customer()
        {

        }

        public Customer(int customerID)
        {
            this.CustomerID = customerID;
        }
        public static int InstanceCount { get; set; }
        

        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string EmailAddress { get; set; }
        public int CustomerID { get; private set; }

        public string FullName
        {
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

        public Customer Retrieve(int customerID)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }

        public bool validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if(string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }

    }
}
