using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrdersListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderID = 1;
            TestItem.CustomerID = 1;
            TestItem.ProductID = 1;
            TestItem.ShippingCompany = "Royal Mail";
            TestItem.DateOfPurchase = Convert.ToDateTime("21/01/2021");
            TestItem.Over18 = true;
            TestItem.TotalPrice = 6;

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Int32 SomeCount = 0;
            AllOrders.Count = SomeCount;
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }
    }
}