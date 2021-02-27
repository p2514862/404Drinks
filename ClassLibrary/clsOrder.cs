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

        public string Valid(string shippingCompany, string customerID, string productID, string dateOfPurchase, string totalPrice)
        {
            //create string variable to store error;
            String Error = "";

            //create temp variable to store data values
            DateTime DateTemp;


            //Shipping Company

            //if blank
            if (shippingCompany.Length == 0)
            {
                Error = Error + "Shipping company field cannot be left blank. ";
            }

            //if shippingCompany is greater than 50 characters
            if (shippingCompany.Length > 50)
            {
                //record error
                Error = Error + "Shipping company field must be less than 50 characters. ";
            }




            //Date Of Purchase
            try
            {   
                //copy dateOfPurchase value to DateTemp
                DateTemp = Convert.ToDateTime(dateOfPurchase);
                if (DateTemp <= DateTime.Now.Date.AddYears(-100))
                {
                    //record any error messages
                    Error = Error + "Date of purchase cannot be older than 100 years ";
                }
                if (DateTemp >= DateTime.Now.Date.AddDays(1))
                {
                    Error = Error + "Date of purchase cannot be in the future. ";
                }
            }
            catch
            {
                Error = Error + "Invalid date entered. ";
            }


            //CustomerID
            //if blank
            try
            {
                decimal i;
                bool result = decimal.TryParse(customerID, out i);

                if (i <= 0)
                {
                    Error = Error + "The data entered in customerID field cannot be 0 or less. ";
                }


                //if CustomerID is greater than 100,000 characters
                if (customerID.Length > 100000)
                {
                    //record error
                    Error = Error + "The data entered in customerID field must be less than 100,000 characters. ";
                }
            }
            catch
            {
                Error = Error + "Invalid CustomerID entered. ";
            }


            //ProductID
            try
            {
                Int32 i;
                bool result = Int32.TryParse(productID, out i);

                if (result == false) //data type check
                {
                    Error = Error + "Please only input numbers within the ProductID field. ";
                }
                        
                if (i <= 0)
                {
                    Error = Error + "The data entered in ProductID field cannot be 0 or less. ";
                }

                if (productID.Length > 100000)
                {
                    Error = Error + "The data entered in ProductID field must be less than 100,000 characters. ";
                }
            }
            catch
            {
                Error = Error + "Invalid ProductID entered. ";
            }
         

        
            //TotalPrice
            try
            {
                decimal i;
                bool result = decimal.TryParse(totalPrice, out i);                

                if (i <= 0) //min
                {
                    Error = Error + "The data entered in in the Total Price field cannot be 0 or less. ";
                }

                if (totalPrice.Length == 0)//empty
                {
                    Error = Error + "Total Price field cannot be left blank. ";
                }
            }

            catch
            {
                Error = Error + "The data entered within Total Price field is not valid. ";
            }
            
            //return any error messages
            return Error;        
        }
    }
}