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
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderID = 1;
            TestOrder.CustomerID = 1;
            TestOrder.ProductID = 1;
            TestOrder.ShippingCompany = "Royal Mail";
            TestOrder.DateOfPurchase = Convert.ToDateTime("21/01/2021");
            TestOrder.Over18 = true;
            TestOrder.TotalPrice = 6;

            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }
        [TestMethod]
        public void ListAndCountOK()
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
            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethod()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.OrderID = 3;
            TestItem.CustomerID = 3;
            TestItem.ProductID = 3;
            TestItem.ShippingCompany = "DHL";
            TestItem.DateOfPurchase = Convert.ToDateTime("09/03/2021");
            TestItem.Over18 = true;
            TestItem.TotalPrice = 15;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.OrderID = PrimaryKey;

            AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

    }
}
