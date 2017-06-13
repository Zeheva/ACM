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
            public void FullNameLastNameEmpty()
            {
                //Arrange
                Customer customer = new Customer();
                customer.FirstName = "Bilbo";

                string expected = "Bilbo";
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

                string expected = "Baggins";

                string actual = customer.FullName;

                Assert.Equal(expected, actual);
            }

            [Fact]
            public void ValidateEmailMissing()
            {
                Customer customer = new Customer();
                customer.LastName = "LastName";
                var expected = false;
                var actual = customer.validate();
                Assert.Equal(expected, actual);

            }
            [Fact]
            public void ValidateLastNameMissing()
            {
                Customer customer = new Customer();
                customer.EmailAddress = "test@test.com";

                var expected = false;

                var actual = customer.validate();
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void ValidateOrderItemsAreValid()
            {
                OrderItem order = new OrderItem();
                order.ProductId = 4;
                order.OrderQuantity = 3;

                var expected = false;

                var actual = order.Validate();

                Assert.Equal(expected, actual);


            }
        }
    }
}
    
