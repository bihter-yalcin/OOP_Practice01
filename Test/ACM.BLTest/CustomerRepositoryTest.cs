using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetriveValid()
        {
            //Arrange

            var CustomerReposiory = new CustomerRepository();

            var expected = new Customer(1)
            {
            EmailAddress = "hello@gmail.com",
            FirstName = "Mary",
           LastName = "Santa"

        };


            //Act
            var actual = CustomerReposiory.Retrieve(1);
            //Assert

            //This can not help us because object karşılaştırıyor ve propertilery aynı olsa da bunlar farklı objeler. 
            //Assert.AreEqual(expected, actual);

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);


        }
    }
}
