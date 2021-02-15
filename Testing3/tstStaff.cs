using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);

        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffID, TestData);
        }
        [TestMethod]
        public void BranchIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.BranchID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.BranchID, TestData);
        }
        [TestMethod]
        public void FullNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Firstname Surname";
            //assign the data to the property
            AnStaff.FullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.FullName, TestData);

        }
        [TestMethod]
        public void DOBPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            // DateTime TestData = new DateTime (1999, 7, 10);
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.DOB, TestData);
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "ISurname@gmail.com";
            //assign the data to the property
            AnStaff.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Email, TestData);
        }
        [TestMethod]
        public void MonthlySalaryPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Decimal TestData = 1;
            //assign the data to the property
            AnStaff.MonthlySalary = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.MonthlySalary, TestData);
        }
        [TestMethod]
        public void OnHolidayPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.OnHoliday = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.OnHoliday, TestData);
        }
        [TestMethod]
        public void FindMethodPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean Found = false;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestStaffIDPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.StaffID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestBranchIDFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.BranchID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestFullNameFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.FullName != "Firstname Surname")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.Email != "ISurname@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestDOBFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.DOB != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestMonthlySalaryFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.MonthlySalary != 1) 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOnHolidayFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            if (AnStaff.OnHoliday != true) 
            {
                OK = false;
            }
            Assert.IsTrue(OK);


        }
    }
}


