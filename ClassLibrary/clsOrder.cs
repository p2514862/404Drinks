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
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");
            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mDateOfPurchase = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfPurchase"]);
                mShippingCompany = Convert.ToString(DB.DataTable.Rows[0]["ShippingCompany"]);
                mOver18 = Convert.ToBoolean(DB.DataTable.Rows[0]["Over18"]);
                mTotalPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["TotalPrice"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
             else
            {
                //return false indicating a problem
                return false;
            }

        }

        public string Valid(int customerID, int productID, string dateOfPurchase, decimal totalPrice, string shippingCompany)
        {
            return"";
        }
    }
}