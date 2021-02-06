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

        [TestMethod]
        public void LivesInUKCustomerOK()
        {
            //Create an instance of the class we want ot create
            clsCustomers ACustomer = new clsCustomers();

            //Create some test data to assign to the property 
            Boolean TestData = true;

            //Assign the data to the property
            ACustomer.LivesInUK = TestData;

            //Test to see the two values are the same
            Assert.AreEqual(ACustomer.LivesInUK, TestData);
        }

        [TestMethod]
        public void DateOfBirthCustomerOK()
        {
            clsCustomers ACustomer = new clsCustomers();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateOfBirth = TestData;
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void CustomerIDCustomerOK()
        {
            clsCustomers ACustomer = new clsCustomers();
            Int32 TestData = 1;
            ACustomer.CustomerID = TestData;
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }
            
        [TestMethod]
        public void CustomerNameCustomerOK()
        {
            clsCustomers ACustomer = new clsCustomers();
            String TestData = "Fatimah Badin";
            ACustomer.CustomerName = TestData;
            Assert.AreEqual(ACustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void CustomerEmailCustomerOK()
        {
            clsCustomers ACustomer = new clsCustomers();
            String TestData = "fatimahbadin@gmail.com";
            ACustomer.CustomerEmail = TestData;
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void PasswordCustomerOK()
        {
            clsCustomers ACustomer = new clsCustomers();
            String TestData = "Fatimah123";
            ACustomer.Password = TestData;
            Assert.AreEqual(ACustomer.Password, TestData);
        }

        [TestMethod]
        public void CustomerAddressCustomerOK()
        {
            clsCustomers ACustomer = new clsCustomers();
            String TestData = "123 Green Street LE4 6HB";
            ACustomer.CustomerAddress = TestData;
            Assert.AreEqual(ACustomer.CustomerAddress, TestData);
        }



    }
}
