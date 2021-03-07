namespace ACM.BL
{
    using System;

    /// <summary>
    /// Defines the <see cref="OrderRepository" />.
    /// </summary>
    public class OrderRepository
    {
        /// <summary>
        /// The Retrieve.
        /// </summary>
        /// <param name="orderId">The orderId<see cref="int"/>.</param>
        /// <returns>The <see cref="Order"/>.</returns>
        public Order Retrieve(int orderId)
        {
            Order order = new Order();

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        /// <summary>
        /// The Save.
        /// </summary>
        /// <param name="order">The order<see cref="Order"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool Save(Order order)
        {
            return true;
        }
    }
}
