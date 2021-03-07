namespace ACM.BL
{
    /// <summary>
    /// Defines the <see cref="Product" />.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="productId">The productId<see cref="int"/>.</param>
        public Product(int productId)
        {
            ProductId = productId;
        }

        /// <summary>
        /// Gets or sets the ProductId.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the ProductName.
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets the ProductDescription.
        /// </summary>
        public string ProductDescription { get; set; }

        //? means variable is nullable and It can be null
        /// <summary>
        /// Gets or sets the CurrentPrice.
        /// </summary>
        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// The Validate.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }
    }
}
