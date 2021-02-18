using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class TstBranch
    {
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
        public void BranchStartDate()
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
        public void BranchId()
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
        public void StaffId()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //create some test data to assign to the property 
            Int16 TestData = 1;
            //assign data to the property
            aBranch.StaffId = TestData;
            //test to see that the two vlaues are the same
            Assert.AreEqual(aBranch.StaffId, TestData);

        }
        [TestMethod]
        public void ProductId()
        {
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //create some test data to assign to the property
            Int16 TestData = 1;
            //assign data to the property
            aBranch.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aBranch.ProductId, TestData);

        }
        [TestMethod]
        public void BranchDescription()
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
            clsBranch aBranch = new clsBranch();
            Boolean Found = false;
            Boolean OK = true;
            Int32 BranchId = 21;
            Found = aBranch.Find(BranchId);
            if (aBranch.BranchDescription != "Juice")
            {
                OK = false;
            }
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
    }
}
