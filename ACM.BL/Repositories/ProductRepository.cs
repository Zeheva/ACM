using System;

namespace ACM.BL
{
   public class ProductRepository
    {

        public Product Retrieve(int productId)
        {
            Product product = new Product(1);

            if (productId == 1)
            {
                product.CurrentPrice = 5.55M;
                product.ProductName = "Hot Dog";
                product.ProductDescription = "yummie";

            }
            return product;
        }

        public bool Save()
        {
            return true;
        }
    }
}
