using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {
            //to overload a constructor we have to declare constructor. 
            //we can not overload automatic generated constructor.
        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

       //Only this class can set customer ID
        public int CustomerId { get; private set; }
       
        private string _lastname;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EmailAddress { get; set; }

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
