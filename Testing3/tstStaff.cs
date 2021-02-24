using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        // String BranchID = "4";
        String FullName = "Parth Patel";
        String DOB = DateTime.Now.Date.ToString();
        String Email = "PPatel@gmail.com.uk";
        String MonthlySalary = "1000";

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
            string TestData = "Parth Patel";
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
            string TestData = "PPatel@gmail.com.uk";
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
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffID = 1;
            Found = AnStaff.Find(StaffID);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestStaffIDFound()
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
            if (AnStaff.BranchID != 4)
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
            if (AnStaff.FullName != "Parth Patel")
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
            if (AnStaff.Email != "PPatel@gmail.com.uk")
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
            if (AnStaff.DOB != Convert.ToDateTime("12/02/1999"))
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
            if (AnStaff.MonthlySalary != 1000)
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
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            String Email = "";
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void EmailMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Email = "a";
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Email = "aa";
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(49, 'a');
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(50, 'a');
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(51, 'a');
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(25, 'a');
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void EmailEtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(1000, 'a');
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            String FullName = "";
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void FullNameMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FullName = "aa";
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FullName = "aaa";
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(99, 'a');
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(100, 'a');
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(101, 'a');
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(50, 'a');
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void FullNameEtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(10000, 'a');
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void MonthlySalaryMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            String FullName = "";
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void MonthlySalaryMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string MonthlySalary = "aa";
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MonthlySalaryMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string MonthlySalary = "aaa";
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MonthlySalaryMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string MonthlySalary = "aaaaaaaaa";
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MonthlySalaryMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string MonthlySalary = "aaaaaaaaaa";
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MonthlySalaryMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string MonthlySalary = "";
            MonthlySalary = FullName.PadRight(11, 'a');
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void MonthlySalaryMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string MonthlySalary = "aaaaa";
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void MonthlySalaryEtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string MonthlySalary = "";
            MonthlySalary = FullName.PadRight(10000, 'a');
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DOBMinLessOne()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-65);
            string DateAdded = TestDate.ToString();
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DOBMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DOBMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(16);
            string DateAdded = TestDate.ToString();
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DOBInvalidData()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            //String FullName = "Parth Patel";
            //String Email = "PPatel@gmail.com.uk";
            //String MonthlySalary = "1000";
            String DOB = "This is not a date!";
            Error = AnStaff.Valid(FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");

        }
    }
}

