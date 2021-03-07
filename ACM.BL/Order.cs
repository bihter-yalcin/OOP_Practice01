namespace ACM.BL
{
    using System;

    /// <summary>
    /// Defines the <see cref="Order" />.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class.
        /// </summary>
        public Order()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class.
        /// </summary>
        /// <param name="orderId">The orderId<see cref="int"/>.</param>
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        //different time zone için işimize yarıyor
        /// <summary>
        /// Gets or sets the OrderDate.
        /// </summary>
        public DateTimeOffset OrderDate { get; set; }

        /// <summary>
        /// Gets or sets the OrderId.
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// The Validate.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
