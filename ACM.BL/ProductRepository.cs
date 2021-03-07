namespace ACM.BL
{
    /// <summary>
    /// Defines the <see cref="ProductRepository" />.
    /// </summary>
    public class ProductRepository
    {
        /// <summary>
        /// The Retrieve.
        /// </summary>
        /// <param name="productId">The productId<see cref="int"/>.</param>
        /// <returns>The <see cref="Product"/>.</returns>
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            //COLLABORATION 1 class uses another class instances.

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Yellow sunflowers";
                product.CurrentPrice = 15.96M;


            }

            return product;
        }

        //save method access data store to save user changes
        /// <summary>
        /// The Save.
        /// </summary>
        /// <param name="product">The product<see cref="Product"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool Save(Product product)
        {
            return true;
        }
    }
}
