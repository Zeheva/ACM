using ACM.BL;
using Xunit;

namespace AMC.BL2.Tests
{
    public class BLTests
    {
     
        public class CustomerTest
        {
            [Fact]
            public void FullNameTestValid()
            {
                //Arrange
                Customer customer = new Customer();
                customer.FirstName = "Bilbo";
                customer.LastName = "Baggins";
                string expected = "Baggins, Bilbo";
                //Act
                string actual = customer.FullName;
                //Assert
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void FullNameTestValid2()
            {
                //Arrange
                Customer customer = new Customer();
                customer.FirstName = "Bilbo";
                customer.LastName = "Baggins";
                string expected = "Baggins, Bilbo";
                //Act
                string actual = customer.FullName;
                //Assert
                Assert.Equal(expected, actual);
            }
            [Fact]
            public void FullNameFirstNameEmpty()
            {
                Customer customer = new Customer();
                customer.LastName = "Baggins";
                customer.FirstName = "Bilbo";
                string expected = "Bilbo, Baggins";

                string actual = customer.FullName;

                Assert.Equal(expected, actual);
            }
        }
    }
}
    
