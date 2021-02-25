using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class TstBranch
    {

        //good test data
        //create some test data to pass to the method
        string ProductId = "1b";
        string StaffId = "2c";
        string BranchDescription = "drink";
        string BranchStartDate = DateTime.Now.Date.ToString();
    

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of a class we want to create
            clsBranch aBranch = new clsBranch();
            //test to see that it exists 
            Assert.IsNotNull(aBranch);
        }

        [TestMethod]
        public void StaffAvailabilityPropertyOK()
        {
            //create an instance of the class we want to create 
            clsBranch aBranch = new clsBranch();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            aBranch.IsStaffAvailable = TestData;
            //test to see the two values are the same
            Assert.AreEqual(aBranch.IsStaffAvailable, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsBranch aBranch = new clsBranch();
            Boolean Found = false;
            Int32 BranchId = 21;
            Found = aBranch.Find(BranchId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void BranchStartDateOK()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            aBranch.BranchStartDate = TestData;
            //test to see that the tw values are the same 
            Assert.AreEqual(aBranch.BranchStartDate, TestData);

        }
        [TestMethod]
        public void BranchIdOK()
        { 
            clsBranch aBranch = new clsBranch();
            //create some test data to assign to property
            Int16 TestData = 1;
            //assign the data to the property 
            aBranch.BranchId = TestData;
            //test to see that the two vlaues are the same
            //Assert.AreEqual(aBranch.BranchId, TestData);
        }
        [TestMethod]
        public void StaffIdOK()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //create some test data to assign to the property 
            Int16 TestData = 1;
            aBranch.StaffId = TestData;
            //test to see that the two vlaues are the same
            Assert.AreEqual(aBranch.StaffId, TestData);

        }
        [TestMethod]
        public void ProductIdOK()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //create some test data to assign to the property
            Int16 TestData = 1;
            //assign data to the property
            aBranch.ProductId = TestData;
            Assert.AreEqual(aBranch.ProductId, TestData);

        }
        [TestMethod]
        public void BranchDescriptionOK()
        {
            //create an instance of the class we want to craete
            clsBranch aBranch = new clsBranch();
            //create some test data to assign to the property
            string TestData = "Describe a branch";
            //assign the data to the property 
            aBranch.BranchDescription = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(aBranch.BranchDescription, TestData);
        }

        [TestMethod]
        public void TestBranchIdFound()
        {
            //create an instance of the class we want to craete
            clsBranch aBranch = new clsBranch();
            //Boolean vraiable to store the results of the validation
            Boolean Found = false;
            //boolean variable to record if data is ok 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 BranchId = 21;
            //invoke the method
            Found = aBranch.Find(BranchId);
            //check the address no
            if (aBranch.BranchId != 21)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBranchDescriptionFound()
        {
            //create an instance of the class we want to create 
            clsBranch aBranch = new clsBranch();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BranchId = 21;
            Found = aBranch.Find(BranchId);
            if (aBranch.BranchDescription != "Juice")
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductIdFound()
        {
            clsBranch aBranch = new clsBranch();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BranchId = 21;
            Found = aBranch.Find(BranchId);
            if (aBranch.ProductId != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            clsBranch aBranch = new clsBranch();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BranchId = 21;
            Found = aBranch.Find(BranchId);
            if (aBranch.StaffId != 4)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsStaffAvailableFound()
        {
            clsBranch aBranch = new clsBranch();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BranchId = 21;
            Found = aBranch.Find(BranchId);
            if (aBranch.IsStaffAvailable != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBranchStartDateFound()
        {
            clsBranch aBranch = new clsBranch();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BranchId = 21;
            Found = aBranch.Find(BranchId);
            if (aBranch.BranchStartDate !=Convert.ToDateTime("19/06/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //string variable to store an error messafe
            String Error = "";
            //invoke the method 
            Error = aBranch.Valid(StaffId, ProductId, BranchDescription, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BranchDescriptionMinLessOne()
        {
            //create an instance of the class we want to create 
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string BranchDescription = ""; //this should trigger an error
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BranchDescriptionMin()
        {
            //create an instance of the class we want to create 
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string BranchDescription = "Juice"; //this should be ok
            //invoke the method
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BranchDescriptionPlusOne()
        {
            //create an instance of the class we want to create 
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string BranchDescription = "jjaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BranchDescrptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string BranchDescription = "aaaaa";
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void BranchDescriptionMax()
        {
            //create an instance of the class we want to create 
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string BranchDescription = "aaaaaa"; //this should be ok
            //invoke the method
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is corrcet 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void BranchDescriptionMid()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method 
            string Branchdescription = "aaa"; // this should be ok
            //invoke the method 
            Error = aBranch.Valid(Branchdescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void BranchDescriptionExtremeMax()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //craete some test data to pass to the method 
            string BranchDescription = "";
            BranchDescription = BranchDescription.PadRight(500, 'a'); //this should fail
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void BranchStartDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message 
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the ate variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void BranchStartDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //create a variable to stroe the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

       [TestMethod]
       public void BranchStartDateMin()
        {
            //create an instance of the class we want to create 
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //create variable to store the test date data 
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void BranchStartDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever he date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string ariable 
            string DateAdded = TestDate.ToString();
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void BranchStartDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void ProductIdMinLessOne()
        {
            //create an instance of the class we want to create 
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //this hsould fail
            string ProductId = "";
            //invoke the method
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductIdMin()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string ProductId = "a";
            //invoke the method
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void ProductIdMinPlusOne()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string ProductId = "aa";
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ProductIdMaxLessOne()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message 
            String Error = "";
            //this dhould pass
            string ProductId = "aaaaaa";
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductIdMax()
        {
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string ProductId = "aaaaaa";
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductIdMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //this should fail 
            string ProductId = "aaaaaaaaaa";
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, StaffId, ProductId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]

        public void ProductIdMid()
        {
            //craete an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string ProductId = "aaaa";
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, StaffId, ProductId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMinLessOne()
        {
            //create an instance of the class we want to create 
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //this should fail 
            string StaffId = "";
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, StaffId, ProductId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMin()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StaffId = "a";
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, StaffId, ProductId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StaffIdMinPlusOne()
        {
            //create an instance of the class we w ant to create
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message 
            String Error = "";
            //this should pass 
            string StaffId = "aa";
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void StaffIdMaxLEssOne()
        {
            //create an instance of the class we want to create 
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message 
            String Error = "";
            //this should pass
            string StaffId = "";
            StaffId = StaffId.PadRight(49, 'a');
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, StaffId, ProductId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StaffIdMax()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string StaffId = "";
            StaffId = StaffId.PadRight(50, 'a');
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, StaffId, ProductId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        
        }
        [TestMethod]
        public void StaffMAxPlusOne()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //this should fail 
            string StaffId = "";
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, StaffId, ProductId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void StaffIdMid()
        {
            //create an instance of the class we want to create 
            clsBranch aBranch = new clsBranch();
            //string variable to store any error message
            String Error = "";
            //this should pass 
            string StaffId = "";
            StaffId = StaffId.PadRight(25, 'a');
            //invoke the method 
            Error = aBranch.Valid(BranchDescription, ProductId, StaffId, BranchStartDate);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }

        }



    }

