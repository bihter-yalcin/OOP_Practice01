namespace ACM.BL
{
    /// <summary>
    /// Defines the <see cref="Address" />.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        public Address()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="addressId">The addressId<see cref="int"/>.</param>
        public Address(int addressId)
        {
            AddressId = addressId;
        }

        /// <summary>
        /// Gets the AddressId.
        /// </summary>
        public int AddressId { get; private set; }

        /// <summary>
        /// Gets or sets the AddressType.
        /// </summary>
        public int AddressType { get; set; }

        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the Country.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the PostalCode.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the StreetLine1.
        /// </summary>
        public string StreetLine1 { get; set; }

        /// <summary>
        /// Gets or sets the StreetLine2.
        /// </summary>
        public string StreetLine2 { get; set; }

        /// <summary>
        /// The Validate.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool Validate()
        {
            var isValid = true;
            if (PostalCode == null) isValid = false;

            return isValid;
        }
    }
}
