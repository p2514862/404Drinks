using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void IsOver18OK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.isOver18 = TestData;
            Assert.AreEqual(AnOrder.isOver18, TestData);
        }
        [TestMethod]
        public void DateOfPurchaseOk()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.DateOfPurchase = TestData;
            Assert.AreEqual(AnOrder.DateOfPurchase, TestData);
        }
        [TestMethod]
        public void TotalPriceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Decimal TestData = 1;
            AnOrder.TotalPrice = TestData;
            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }

        [TestMethod]
        public void ShippingCompanyOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "Royal Mail";
            AnOrder.ShippingCompany = TestData;
            Assert.AreEqual(AnOrder.ShippingCompany, TestData);

        }
        [TestMethod]
        public void OrderIDOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 001;
            AnOrder.OrderID = TestData;
            Assert.AreEqual(AnOrder.OrderID, TestData);

        }

        [TestMethod]
        public void CustomerIDOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 001;
            AnOrder.CustomerID = TestData;
            Assert.AreEqual(AnOrder.CustomerID, TestData);

        }

        [TestMethod]
        public void ProductIDOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 001;
            AnOrder.ProductID = TestData;
            Assert.AreEqual(AnOrder.ProductID, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            decimal TotalPrice = 5;
            Found = AnOrder.Find(TotalPrice);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Decimal TotalPrice = 5;
            Found = AnOrder.Find(TotalPrice);
            if (AnOrder.TotalPrice != 5)
            {
                OK = false;
                            }
            Assert.IsTrue(OK);

        }
    }
}
