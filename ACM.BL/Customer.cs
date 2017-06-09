namespace ACM.BL
{
    public class Customer
    {
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string FirstName { get; set; }
        public string MyProperty { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerID { get; private set; }

        public string FullName { get { return LastName + ", " + FullName; } }

    }
}
