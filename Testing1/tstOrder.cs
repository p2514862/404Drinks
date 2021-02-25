using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {
        //Good Test Data
        String CustomerID = "1";
        String ProductID = "1";
        String TotalPrice = "6";
        String ShippingCompany = "RoyalMail";
        String DateOfPurchase = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void Over18OK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.Over18 = TestData;
            Assert.AreEqual(AnOrder.Over18, TestData);
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
            Int32 TestData = 1;
            AnOrder.OrderID = TestData;
            Assert.AreEqual(AnOrder.OrderID, TestData);

        }

        [TestMethod]
        public void CustomerIDOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.CustomerID = TestData;
            Assert.AreEqual(AnOrder.CustomerID, TestData);

        }

        [TestMethod]
        public void ProductIDOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.ProductID = TestData;
            Assert.AreEqual(AnOrder.ProductID, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = true;
            Int32 OrderID = 2;
            Found = AnOrder.Find(OrderID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.CustomerID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.ProductID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfPurchaseFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.DateOfPurchase != Convert.ToDateTime("21/01/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestShippingCompanyFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.ShippingCompany != "RoyalMail")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOver18Found()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.Over18 != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTotalPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.TotalPrice != 6)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Error = AnOrder.Valid(ShippingCompany, CustomerID, ProductID, DateOfPurchase, TotalPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingCompanyMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingCompany = ""; //this should trigger an error
            Error = AnOrder.Valid(ShippingCompany, CustomerID, ProductID, DateOfPurchase, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingCompanyMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingCompany = "a"; //this should be ok
            Error = AnOrder.Valid(ShippingCompany, CustomerID, ProductID, DateOfPurchase, TotalPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingCompanyPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingCompany = "aa"; //this should be ok
            Error = AnOrder.Valid(ShippingCompany, CustomerID, ProductID, DateOfPurchase, TotalPrice);
            Assert.AreEqual(Error, "");
        }

         [TestMethod]
        public void ShippingCompanyMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingCompany = ""; 
            ShippingCompany = ShippingCompany.PadRight(49, 'a');
            Error = AnOrder.Valid(ShippingCompany, CustomerID, ProductID, DateOfPurchase, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ShippingCompanyMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingCompany = ""; 
            ShippingCompany = ShippingCompany.PadRight(50, 'a');
            Error = AnOrder.Valid(ShippingCompany, CustomerID, ProductID, DateOfPurchase, TotalPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingCompanyMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingCompany = "";
            ShippingCompany = ShippingCompany.PadRight(25, 'a');
            Error = AnOrder.Valid(ShippingCompany, CustomerID, ProductID, DateOfPurchase, TotalPrice);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShippingCompanyMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingCompany = ""; 
            ShippingCompany = ShippingCompany.PadRight(51, 'a'); //should fail
            Error = AnOrder.Valid(ShippingCompany, CustomerID, ProductID, DateOfPurchase, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShippingCompanyExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string ShippingCompany = ""; 
            ShippingCompany = ShippingCompany.PadRight(1000, 'a'); //should fail
            Error = AnOrder.Valid(ShippingCompany, CustomerID, ProductID, DateOfPurchase, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfPurchaseExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateOfPurchase = TestDate.ToString();
            Error = AnOrder.Valid(ShippingCompany, CustomerID, ProductID, DateOfPurchase, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfPurchaseMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateOfPurchase = TestDate.ToString();
            Error = AnOrder.Valid(ShippingCompany, CustomerID, ProductID, DateOfPurchase, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfPurchaseMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateOfPurchase = TestDate.ToString();
            Error = AnOrder.Valid(ShippingCompany, CustomerID, ProductID, DateOfPurchase, TotalPrice);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfPurchaseMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateOfPurchase = TestDate.ToString();
            Error = AnOrder.Valid(ShippingCompany, CustomerID, ProductID, DateOfPurchase, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfPurchaseExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateOfPurchase = TestDate.ToString();
            Error = AnOrder.Valid(ShippingCompany, CustomerID, ProductID, DateOfPurchase, TotalPrice);
            Assert.AreNotEqual(Error, "");
        }


    }
}
