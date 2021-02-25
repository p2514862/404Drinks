using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomers
    {
        //Good test data
        //create some test data to pass to the method 
        string CustomerName = "Fatimah Badin";
        string CustomerEmail = "fatimahbadin@gmail.com";
        string Password = "hello123";
        string CustomerAddress = "123 Green Street";
        string DateOfBirth = DateTime.Now.Date.AddYears(-16).ToString();


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
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.DateOfBirth != Convert.ToDateTime("23/09/1999"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerName != "Fatimah Badin")
            {
                OK = false;
            }
            
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerEmail != "fatimah@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerAddress != "10 green street LE6 6BH")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPasswordFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.Password != "fatimah123")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLivesInUKFound()
        {
            clsCustomers ACustomer = new clsCustomers();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.LivesInUK != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //Create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store any error message 
            String Error = "";
           // String Error2 = "";
            //invoke method 
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
           // Error2 = ACustomer.Valid2(DateOfBirth);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerName = ""; //this should trigger an error
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMin()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerName = "f"; //this should be ok
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, ""); 
        }

        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerName = "ff";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(49, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(50, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMid()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerName = "";
            CustomerName =  CustomerName.PadRight(25, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(51, 'f'); //should fail
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(1000, 'f'); //should fail
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            string DateOfBirth = TestDate.ToString();
            //Error = ACustomer.Valid2(DateOfBirth);
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-15);
            string DateOfBirth = TestDate.ToString();
            //Error = ACustomer.Valid2(DateOfBirth);
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-16);
            string DateOfBirth = TestDate.ToString();
            //Error = ACustomer.Valid2(DateOfBirth);
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-17);
            string DateOfBirth = TestDate.ToString();
            //Error = ACustomer.Valid2(DateOfBirth);
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-99);
            string DateOfBirth = TestDate.ToString();
            //Error = ACustomer.Valid2(DateOfBirth);
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateOfBirth = TestDate.ToString();
            //Error = ACustomer.Valid2(DateOfBirth);
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMaxPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-101);
            string DateOfBirth = TestDate.ToString();
            //Error = ACustomer.Valid2(DateOfBirth);
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMid()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-42);
            string DateOfBirth = TestDate.ToString();
            //Error = ACustomer.Valid2(DateOfBirth);
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1000);
            string DateOfBirth = TestDate.ToString();
            //Error = ACustomer.Valid2(DateOfBirth);
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string DateOfBirth = "this is not a date";
            //Error = ACustomer.Valid2(DateOfBirth);
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);

            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerEmail = "";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMin()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerEmail = "f";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerEmail = "ff";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(99, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(100, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(101, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMid()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(50, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerEmail = "";
            CustomerEmail = CustomerEmail.PadRight(10000, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMin()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Password = "";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(7, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMin()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(8, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(9, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(59, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(60, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(61, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(30, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordExtremeMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string Password = "";
            Password = Password.PadRight(1000, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerAddressMinLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerAddress = "";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMin()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerAddress = "f";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMinPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerAddress = "ff";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxLessOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(149, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(150, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(151, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressMid()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(75, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadRight(10000, 'f');
            Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }



    }
}
