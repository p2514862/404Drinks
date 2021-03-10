using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //test data - list of objects
            List<clsCustomers> TestList = new List<clsCustomers>();

            //add item to list - create item of test data 
            clsCustomers TestItem = new clsCustomers();

            //set properties
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Fatimah Badin";
            TestItem.CustomerEmail = "fatimah@gmail.com";
            TestItem.Password = "fatimah123";
            TestItem.CustomerAddress = "10 green street LE6 6BH";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-20);
            TestItem.LivesInUK = true;

            //add ietsm to test list
            TestList.Add(TestItem);

            //assign data to property
            AllCustomers.CustomerList = TestList;

            //test that the values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList); 
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomers TestCustomer = new clsCustomers();
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerName = "Fatimah Badin";
            TestCustomer.CustomerEmail = "fatimah@gmail.com";
            TestCustomer.Password = "fatimah123";
            TestCustomer.CustomerAddress = "10 green street LE6 6BH";
            TestCustomer.DateOfBirth = DateTime.Now.Date.AddYears(-20);
            TestCustomer.LivesInUK = true;
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomers> TestList = new List<clsCustomers>();
            clsCustomers TestItem = new clsCustomers();
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Fatimah Badin";
            TestItem.CustomerEmail = "fatimah@gmail.com";
            TestItem.Password = "fatimah123";
            TestItem.CustomerAddress = "10 green street LE6 6BH";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-20);
            TestItem.LivesInUK = true;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

    }
}
