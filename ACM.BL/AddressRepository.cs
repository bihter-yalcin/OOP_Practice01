namespace ACM.BL
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="AddressRepository" />.
    /// </summary>
    internal class AddressRepository
    {
        /// <summary>
        /// The Retrieve.
        /// </summary>
        /// <param name="addressId">The addressId<see cref="int"/>.</param>
        /// <returns>The <see cref="Address"/>.</returns>
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            //Temporary hard-coded values to return a populated customer

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Eart";
                address.PostalCode = "144";

            }

            return address;
        }

        /// <summary>
        /// The RetrieveByCustomerId.
        /// </summary>
        /// <param name="customerId">The customerId<see cref="int"/>.</param>
        /// <returns>The <see cref="IEnumerable{Address}"/>.</returns>
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {

            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Eart",
                PostalCode = "144",

            };

            addressList.Add(address);



            address = new Address(1)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Eart",
                PostalCode = "146",

            };

            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// The Save.
        /// </summary>
        /// <param name="address">The address<see cref="Address"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool Save(Address address)
        {


            return true;
        }
    }
}
