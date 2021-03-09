using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffID = 1;
            TestItem.BranchID = 4;
            TestItem.FullName = "FullName";
            TestItem.DOB = Convert.ToDateTime("12/02/1999");
            TestItem.Email = "PPatel@gmail.com.uk";
            TestItem.MonthlySalary = 1000;
            TestItem.OnHoliday = true;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);


        }
       
        [TestMethod]
        public void ThisStaffPropertyOK()

        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.StaffID = 1;
            TestStaff.BranchID = 4;
            TestStaff.FullName = "FullName";
            TestStaff.DOB = Convert.ToDateTime("12/02/1999");
            TestStaff.Email = "PPatel@gmail.com.uk";
            TestStaff.MonthlySalary = 1000;
            TestStaff.OnHoliday = true;
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.StaffID = 1;
            TestItem.BranchID = 4;
            TestItem.FullName = "FullName";
            TestItem.DOB = Convert.ToDateTime("12/02/1999");
            TestItem.Email = "PPatel@gmail.com.uk";
            TestItem.MonthlySalary = 1000;
            TestItem.OnHoliday = true;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
        
        }


    }

