namespace ACM.BL
{
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="CustomerRepository" />.
    /// </summary>
    public class CustomerRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerRepository"/> class.
        /// </summary>
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        /// <summary>
        /// Gets or sets the addressRepository.
        /// </summary>
        private AddressRepository addressRepository { get; set; }

        /// <summary> 
        /// The Retrieve.
        /// </summary>
        /// <param name="customerId">The customerId<see cref="int"/>.</param>
        /// <returns>The <see cref="Customer"/>.</returns>
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            //Temporary hard-coded values to return a populated customer

            if (customerId == 1)
            {
                customer.EmailAddress = "hello@gmail.com";
                customer.FirstName = "Mary";
                customer.LastName = "Santa";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }

            return customer;
        }

        /// <summary>
        /// The Save.
        /// </summary>
        /// <param name="customer">The customer<see cref="Customer"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool Save(Customer customer)
        {

            //code that saves the passed in customer.
            return true;
        }
    }
}
