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
            AnOrder.isOver18OK = TestData;
            Assert.AreEqual(AnOrder.isOver18OK, TestData);
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
            Int32 TestData = 1;
            AnOrder.TotalPriceOK = TestData;
            Assert.AreEqual(AnOrder.TotalPriceOK, TestData);
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
            AnOrder.OrderIDOK = TestData;
            Assert.AreEqual(AnOrder.OrderIDOK, TestData);

        }
    }
}
