namespace ACM.BL
{
    /// <summary>
    /// Defines the <see cref="OrderItem" />.
    /// </summary>
    public class OrderItem
    {
        /// <summary>
        /// Gets or sets the ProductId.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the Quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the PurchasePrice.
        /// </summary>
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Gets the OrderItemId.
        /// </summary>
        public int OrderItemId { get; private set; }

        /// <summary>
        /// The Validate.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool Validate()
        {
            var isValid = true;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// The Retrive.
        /// </summary>
        /// <param name="OrderItemId">The OrderItemId<see cref="int"/>.</param>
        /// <returns>The <see cref="OrderItem"/>.</returns>
        public OrderItem Retrive(int OrderItemId)
        {
            return new OrderItem();
        }

        /// <summary>
        /// The Save.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool Save()
        {
            return true;
        }
    }
}
