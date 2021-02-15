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
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStock.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Quantity, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Decimal TestData = 1;
            //assign the data to the property
            AnStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Price, TestData);
        }

        [TestMethod]
        public void DateRecievedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
           // DateTime TestData = DateTime.Now.ToString("MM/dd/yyyy");
            //assign the data to the property
            AnStock.DateRecieved = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.DateRecieved, TestData);
        }
        [TestMethod]
        public void AvailabilityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStock.Availability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Availability, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //check the address no
            if (AnStock.ProductID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDrinkTypeFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //check the property
            if (AnStock.DrinkType != "fizzy")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //check the address no
            if (AnStock.Quantity != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //check the address no
            if (AnStock.Price != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateRecievedFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //check the property
            if (AnStock.DateRecieved != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAvailabilityFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductID = 1;
            //invoke the method
            Found = AnStock.Find(ProductID);
            //check the property
            if (AnStock.Availability != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
