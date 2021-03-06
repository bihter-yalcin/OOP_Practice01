using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
   public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            //Temporary hard-coded values to return a populated customer

            if (customerId==1)
            {
                customer.EmailAddress = "hello@gmail.com";
                customer.FirstName = "Mary";
                customer.LastName = "Santa";
            }

            return customer;
        }


        public bool Save(Customer customer)
        {

            //code that saves the passed in customer.
            return true;

        }


    }
}
