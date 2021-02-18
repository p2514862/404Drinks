using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AnStock = new clsStock();
            Assert.IsNotNull(AnStock);
        }
        [TestMethod]
        public void ProductIDPropertOK()
        {
            clsStock AnStock = new clsStock();
            Int32 TestData = 1;
            AnStock.ProductID = TestData;
            Assert.AreEqual(AnStock.ProductID, TestData);
        }
        [TestMethod]
        public void DrinkTypePropertyOK()
        {
            clsStock AnStock = new clsStock();
            string TestData = "fizzy";
            AnStock.DrinkType = TestData;
            Assert.AreEqual(AnStock.DrinkType, TestData);
        }
        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsStock AnStock = new clsStock();
            Int32 TestData = 1;
            AnStock.Quantity = TestData;
            Assert.AreEqual(AnStock.Quantity, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            clsStock AnStock = new clsStock();
            Decimal TestData = 1;
            AnStock.Price = TestData;
            Assert.AreEqual(AnStock.Price, TestData);
        }

        [TestMethod]
        public void DateRecievedPropertyOK()
        {
            clsStock AnStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
           // DateTime TestData = DateTime.Now.ToString("MM/dd/yyyy");
            AnStock.DateRecieved = TestData;
            Assert.AreEqual(AnStock.DateRecieved, TestData);
        }
        [TestMethod]
        public void AvailabilityPropertyOK()
        {
            clsStock AnStock = new clsStock();
            Boolean TestData = true;
            AnStock.Availability = TestData;
            Assert.AreEqual(AnStock.Availability, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Int32 ProductID = 1;
            Found = AnStock.Find(ProductID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductIDFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 3;
            Found = AnStock.Find(ProductID);
            if (AnStock.ProductID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDrinkTypeFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 3;
            Found = AnStock.Find(ProductID);
            if (AnStock.DrinkType != "Tea")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 3;
            Found = AnStock.Find(ProductID);
            if (AnStock.Quantity != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 3;
            Found = AnStock.Find(ProductID);
            if (AnStock.Price != 6)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateRecievedFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 3;
            Found = AnStock.Find(ProductID);
            if (AnStock.DateRecieved != Convert.ToDateTime("14/06/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailabilityFound()
        {
            clsStock AnStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 3;
            Found = AnStock.Find(ProductID);
            if (AnStock.Availability != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
