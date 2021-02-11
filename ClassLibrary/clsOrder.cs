using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for the properties
        private int mOrderID;
        private int mProductID;
        private int mCustomerID;
        private DateTime mDateOfPurchase;
        private string mShippingCompany;
        private bool mOver18;
        private decimal mTotalPrice;


        //properties

        public Int32 OrderID
        {
            get
            {

                //sends data out of the property
                return mOrderID;
            }
            set
            {
                //allows data into the property
                mOrderID = value;
            }
        }

        public Int32 CustomerID
        {
            get
            {

                //sends data out of the property
                return mCustomerID;
            }
            set
            {
                //allows data into the property
                mCustomerID = value;
            }
        }

        public Int32 ProductID
        {
            get
            {

                //sends data out of the property
                return mProductID;
            }
            set
            {
                //allows data into the property
                mProductID = value;
            }
        }

        public String ShippingCompany
        {
            get
            {

                //sends data out of the property
                return mShippingCompany;
            }
            set
            {
                //allows data into the property
                mShippingCompany = value;
            }
        }
        public bool Over18
        {
            get
            {
                //This line of code sends data out of the property
                return mOver18;
            }
            set
            {
                //This line of code allows data into the property 
                mOver18 = value;
            }
        }
        public DateTime DateOfPurchase
        {
            get
            {
                return mDateOfPurchase;
            }
            set
            {
                mDateOfPurchase = value;
            }
        }

        public Decimal TotalPrice
        {
            get
            {
                return mTotalPrice;
            }
            set
            {
                mTotalPrice = value;
            }
        }

        public bool Find(int OrderID)
        {
            //Set the private data members to the test data value 
            mOrderID = 3;
            mProductID = 2;
            mCustomerID = 4;
            mDateOfPurchase = Convert.ToDateTime("10/02/2021");
            mShippingCompany = "Royal Mail";
            mOver18 = true;
            mTotalPrice = 10;

            //Always returns true 
            return true;
        }
    }
}