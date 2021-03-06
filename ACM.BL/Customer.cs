using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer():this (0) //constructor chaining used any time when constructor needs to call another 
        {
            //to overload a constructor we have to declare constructor. 
            //we can not overload automatic generated constructor.
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

       //Only this class can set customer ID
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EmailAddress { get; set; }
        public List<Address> AddressList { get; set; }

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
                } fullname += FirstName;

            
            return fullname;
            }
        }
    
        
    public static int InstanceCount { get; set; }
        

public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(FullName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }
    }
}
