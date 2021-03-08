namespace ACM.BL
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Order" />.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class.
        /// </summary>
        public Order(): this(0)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class.
        /// </summary>
        /// <param name="orderId">The orderId<see cref="int"/>.</param>
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
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

        //THIS TWO PROPERTIES ARE MAKE CONNECTION BETWEEN ORDER AND CUSTOMER,ADDRESS 
        public int CustomerId { get; set; }

        public int ShippingAddressId { get; set; }

        public List<OrderItem> OrderItems { get; set; } //Composition between order and orderıtems use in constructor 




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
