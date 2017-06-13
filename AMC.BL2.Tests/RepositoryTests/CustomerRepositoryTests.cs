using ACM.BL;
using Xunit;

namespace AMC.BL2.Tests
{
    public class CustomerRepositoryTests
    {
        [Fact]
        public void RetrieveExitingFromCustomerRepo()
        {
            var customerRepo = new CustomerRepository();

            var expected = new Customer(1)
            {
                EmailAddress = "test@email.com",
                FirstName = "Brad",
                LastName = "Pitt"
            };
            var actual = customerRepo.Retrieve(1);

           // Assert.Equal(expected, actual);

            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
        }

       
    }
}
