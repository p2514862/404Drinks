using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstBranch
    {
        [TestMethod]
        public void InstanceOK()
        {
           //create an instance of the class we want to create
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
            //create an instance of the class we want to create
            clsBranch aBranch = new clsBranch();
            //create some test data to assign to the property
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
    }
}
