using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomers
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();

            //Test to see that it exists
            Assert.IsNotNull(ACustomer);
        }


    }
}
