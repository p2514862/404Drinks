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

        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();

            //Boolean variable to store the results of validation
            Boolean Found = false;

            //Create some test data to use with the method
            Int32 CustomerID = 1;

            //Invoke the method 
            Found = ACustomer.Find(CustomerID);

            //Test to see if the result is true 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //Create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();

            //boolean varibale to store the results of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method 
            Int32 CustomerID = 3;

            //Invoke the method
            Found = ACustomer.Find(CustomerID);

            //check the customer id
            if (ACustomer.CustomerID != 3)
            {
                OK = false;
            }

            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //Create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();

            //boolean varibale to store the results of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method 
            Int32 CustomerID = 3;

            //Invoke the method
            Found = ACustomer.Find(CustomerID);

            //check the customer id
            if (ACustomer.DateOfBirth != Convert.ToDateTime("25/09/2000"))
            {
                OK = false;
            }

            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            //Create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();

            //boolean varibale to store the results of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method 
            Int32 CustomerID = 3;

            //Invoke the method
            Found = ACustomer.Find(CustomerID);

            //check the customer id
            if (ACustomer.CustomerName != "Fatimah Badin")
            {
                OK = false;
            }

            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //Create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();

            //boolean varibale to store the results of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method 
            Int32 CustomerID = 3;

            //Invoke the method
            Found = ACustomer.Find(CustomerID);

            //check the customer id
            if (ACustomer.CustomerEmail != "fatimahbadin@gmail.com")
            {
                OK = false;
            }

            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //Create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();

            //boolean varibale to store the results of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method 
            Int32 CustomerID = 3;

            //Invoke the method
            Found = ACustomer.Find(CustomerID);

            //check the customer id
            if (ACustomer.CustomerAddress != "123 green street LE7 5BH")
            {
                OK = false;
            }

            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {

        }

        [TestMethod]
        public void TestLivesInUKFound()
        {
            //Create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();

            //boolean varibale to store the results of the search
            Boolean Found = false;

            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method 
            Int32 CustomerID = 3;

            //Invoke the method
            Found = ACustomer.Find(CustomerID);

            //check the customer id
            if (ACustomer.LivesInUK != true)
            {
                OK = false;
            }

            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }
    }
}
