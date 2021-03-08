namespace ACM.BL
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Customer" />.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        public Customer() : this(0) //constructor chaining used any time when constructor needs to call another 
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="customerId">The customerId<see cref="int"/>.</param>
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        //Only this class can set customer ID
        /// <summary>
        /// Gets the CustomerId.
        /// </summary>
        public int CustomerId { get; private set; }

        /// <summary>
        /// Gets or sets the FirstName.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the LastName.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the EmailAddress.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the AddressList. This is COMPOSITION address and customer class HAS A relationship
        /// </summary>
        public List<Address> AddressList { get; set; }

        public int CustomerType { get; set; }

        /// <summary>
        /// Gets the FullName.
        /// </summary>
        public string FullName
        {
            get
            {
                string fullname = LastName;

                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += ",";
                    }
                }
                fullname += FirstName;


                return fullname;
            }
        }

        /// <summary>
        /// Gets or sets the InstanceCount.
        /// </summary>
        public static int InstanceCount { get; set; }

        /// <summary>
        /// The Validate.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(FullName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }
    }
}
