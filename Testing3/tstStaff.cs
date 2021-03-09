using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStaff
    {
        String BranchID = "4";
        String FullName = "Parth Patel";
        String DOB = DateTime.Now.Date.AddYears(-16).ToString();
        String Email = "PPatel@gmail.com.uk";
        String MonthlySalary = "1000";

        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AnStaff = new clsStaff();
            Assert.IsNotNull(AnStaff);

        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            Int32 TestData = 1;
            AnStaff.StaffID = TestData;
            Assert.AreEqual(AnStaff.StaffID, TestData);
        }
        [TestMethod]
        public void BranchIDPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            Int32 TestData = 1;
            AnStaff.BranchID = TestData;
            Assert.AreEqual(AnStaff.BranchID, TestData);
        }
        [TestMethod]
        public void FullNamePropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            string TestData = "Parth Patel";
            AnStaff.FullName = TestData;
            Assert.AreEqual(AnStaff.FullName, TestData);

        }
        [TestMethod]
        public void DOBPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            // DateTime TestData = new DateTime (1999, 7, 10);
            DateTime TestData = DateTime.Now.Date;
            AnStaff.DOB = TestData;
            Assert.AreEqual(AnStaff.DOB, TestData);
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            string TestData = "PPatel@gmail.com.uk";
            AnStaff.Email = TestData;
            Assert.AreEqual(AnStaff.Email, TestData);
        }
        [TestMethod]
        public void MonthlySalaryPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            Decimal TestData = 1;
            AnStaff.MonthlySalary = TestData;
            Assert.AreEqual(AnStaff.MonthlySalary, TestData);
        }
        [TestMethod]
        public void OnHolidayPropertyOK()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean TestData = true;
            AnStaff.OnHoliday = TestData;
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
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
            

        }
        [TestMethod]
        public void BranchIDMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            String BranchID = "";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void BranchIDMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string BranchID = "a";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BranchIDMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string BranchID = "aa";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BranchIDMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string BranchID = "a";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void BranchIDMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string BranchID = "aa";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void BranchIDMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string BranchID = "aaa";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void BranchIDMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string BranchID = "a";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void BranchIDExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string BranchID = "";
            BranchID = BranchID.PadRight(1000, 'a');
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            String Email = "";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void EmailMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Email = "a";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Email = "aa";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(49, 'a');
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void EmailMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(50, 'a');
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(51, 'a');
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void EmailMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(25, 'a');
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void EmailextremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(1000, 'a');
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            String FullName = "";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void FullNameMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FullName = "aa";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FullName = "aaa";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(99, 'a');
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(100, 'a');
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(101, 'a');
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void FullNameMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(50, 'a');
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void FullNameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string FullName = "";
            FullName = FullName.PadRight(10000, 'a');
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void MonthlySalaryMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            String FullName = "";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void MonthlySalaryMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string MonthlySalary = "aa";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MonthlySalaryMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string MonthlySalary = "aaa";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MonthlySalaryMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string MonthlySalary = "aaaaaaaaa";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MonthlySalaryMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string MonthlySalary = "aaaaaaaaaa";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MonthlySalaryMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string MonthlySalary = "";
            MonthlySalary = FullName.PadRight(11, 'a');
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void MonthlySalaryMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string MonthlySalary = "aaaaa";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void MonthlySalaryExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string MonthlySalary = "";
            MonthlySalary = FullName.PadRight(10000, 'a');
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DOBMinLessOne()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-15);
            string DOB = TestDate.ToString();
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-16);
            string DOB = TestDate.ToString();
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DOBMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-17);
            string DOB = TestDate.ToString();
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DOBMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-65);
            string DOB = TestDate.ToString();
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DOBMaxPluseone()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-66);
            string DOB = TestDate.ToString();
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DOBMaxlessone()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-64);
            string DOB = TestDate.ToString();
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DOBExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DOB = TestDate.ToString();
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DOBInvalidData()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            String DOB = "This is not a date!";
            Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
            Assert.AreNotEqual(Error, "");

        }
    }
}

