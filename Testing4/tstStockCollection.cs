using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }
        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Availability = true;
            TestItem.ProductID = 1;
            TestItem.DrinkType = "fizzy";
            TestItem.Quantity = 2;
            TestItem.Price = 2;
            TestItem.DateRecieved = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Availability = true;
            TestItem.ProductID = 1;
            TestItem.DrinkType = "fizzy";
            TestItem.Quantity = 2;
            TestItem.Price = 2;
            TestItem.DateRecieved = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestStock = new clsStock();
            TestStock.Availability = true;
            TestStock.ProductID = 1;
            TestStock.DrinkType = "fizzy";
            TestStock.Quantity = 2;
            TestStock.Price = 2;
            TestStock.DateRecieved = DateTime.Now.Date;
            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        }
}
