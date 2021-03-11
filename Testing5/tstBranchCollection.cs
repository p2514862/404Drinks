using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstBranchCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsBranchCollection AllBranches = new clsBranchCollection();
            //test to see that exist 
            Assert.IsNotNull(AllBranches);
        }

        [TestMethod]

        public void BranchListOK()
        {
            //create an instance of the class we want to create 
            clsBranchCollection AllBranches = new clsBranchCollection();
            //create some test data to assign to the branch 
            //in this case the data needs to be a list of objects
            List<clsBranch> TestList = new List<clsBranch>();
            //add an item to the list 
            //create the item of test data 
            clsBranch TestItem = new clsBranch();
            //set its properties
            TestItem.IsStaffAvailable = true;
            TestItem.BranchId = 1;
            TestItem.StaffId = 1;
            TestItem.ProductId = 21;
            TestItem.BranchStartDate = DateTime.Now.Date;
            TestItem.BranchDescription = "Juice";
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the branch
            AllBranches.BranchList = TestList;
            //test to see that the two values are the same 
            Assert.AreEqual(AllBranches.BranchList, TestList);
        }



        [TestMethod]

        public void ThisBranchDataOK()
        {
            //create an instance of the class we want to create 
            clsBranchCollection AllBranches = new clsBranchCollection();
            //create some test data to assign to the property 
            clsBranch TestBranch = new clsBranch();
            //set the data of the test object
            TestBranch.IsStaffAvailable = true;
            TestBranch.BranchId = 1;
            TestBranch.StaffId = 1;
            TestBranch.ProductId = 21;
            TestBranch.BranchStartDate = DateTime.Now.Date;
            TestBranch.BranchDescription = "Juice";
            //assign the data to the branch 
            AllBranches.ThisBranch = TestBranch;
            //test to see that the values are the same 
            Assert.AreEqual(AllBranches.ThisBranch, TestBranch);
        }

        [TestMethod]

        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsBranchCollection AllBranches = new clsBranchCollection();
            //create some test data to assign to the branch
            //in this case the data needs to be a list of objects 
            List<clsBranch> TestList = new List<clsBranch>();
            //add an item to the list 
            //create the itme of test data 
            clsBranch TestItem = new clsBranch();
            //set its data 
            TestItem.IsStaffAvailable = true;
            TestItem.ProductId = 21;
            TestItem.StaffId = 1;
            TestItem.BranchId = 1;
            TestItem.BranchStartDate = DateTime.Now.Date;
            TestItem.BranchDescription = "Juice";
            //add the item to the test list 
            TestList.Add(TestItem);
            //assign the data to the branch 
            AllBranches.BranchList = TestList;
            //test to see that values are the same 
            Assert.AreEqual(AllBranches.Count, TestList.Count);

        }

    }
}
