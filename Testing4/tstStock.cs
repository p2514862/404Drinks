using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStock
    {
        string DrinkType = "fizzy";
        string Quantity = "1";
        string Price = "2";
        string DateRecieved = DateTime.Now.Date.ToString();



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
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DrinkTypeMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string DrinkType = "";
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DrinkTypeMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string DrinkType = "a";
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DrinkTypePlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string DrinkType = "aa";
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DrinkTypeMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            String DrinkType = "";
            DrinkType = DrinkType.PadRight(14, 'a');
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DrinkTypeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            String DrinkType = "";
            DrinkType = DrinkType.PadRight(15, 'a');
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DrinkTypeMid()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string DrinkType = "aaa";
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DrinkTypeMaxPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            String DrinkType = "";
            DrinkType = DrinkType.PadRight(16, 'a');
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DrinkTypeExtremeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string DrinkType = "";
            DrinkType = DrinkType.PadRight(17, 'a');
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Quantity = "";
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Quantity = "a";
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Quantity = "aa";
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            String Quantity = "";
            Quantity = Quantity.PadRight(1, 'a');
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            //String Quantity = "aaa";
            Quantity = Quantity.PadRight(2, 'a');
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMid()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Quantity = "aa";
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            String Quantity = "";
            Quantity = Quantity.PadRight(3, 'a');
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(5, 'a');
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Price = "";
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Price = "a";
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PricePlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Price = "aa";
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            String Price = "";
            Price = Price.PadRight(17, 'a');
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            String Price = "";
            Price = Price.PadRight(18, 'a');
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Price = "aaa";
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            String Price = "";
            Price = Price.PadRight(19, 'a');
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string Price = "";
            Price = Price.PadRight(20, 'a');
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRecievedExtremeMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateRecieved = TestDate.ToString();
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateRecievedMinLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateRecieved = TestDate.ToString();
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateRecievedMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateRecieved = TestDate.ToString();
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateRecievedMinPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateRecieved = TestDate.ToString();
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateRecievedExtremeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateRecieved = TestDate.ToString();
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateRecievedInvalidData()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string DrinkType = "fizzy";
            string Quantity = "2";
            string Price = "1";
            string DateRecieved = "This is not a date!";
            Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
            Assert.AreNotEqual(Error, "");
        }







    }



}

