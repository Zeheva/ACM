using ACM.BL;
using Xunit;

namespace AMC.BL2.Tests
{
    public class ProductRepositoryTests
    {
        [Fact]
        public void RetrieveExitingProductWithRetrieve()
        {
            var productRepo = new ProductRepository();

            var expected = new Product(1)
            {
                CurrentPrice = 5.55M,
                ProductName = "Hot Dog",
                ProductDescription = "yummie"
            };

            var actual = productRepo.Retrieve(1);

            Assert.Equal(expected.ProductId, actual.ProductId);
            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
            Assert.Equal(expected.ProductName, actual.ProductName);
            Assert.Equal(expected.ProductDescription, actual.ProductDescription);

        }

    }
}
