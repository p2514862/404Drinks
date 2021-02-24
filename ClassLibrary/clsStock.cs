using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data memeber for the address no property 
        private Int32 mProductID;

        public Int32 ProductID
        {
            get
            {
                //this line of code allows data into the property
                return mProductID;
            }
            set
            {
                //this line of code allows data into the property
                mProductID = value;
            }
        }
        private string mDrinkType;
        public string DrinkType
        {
            get
            {
                return mDrinkType;
            }
            set
            {
                mDrinkType = value;
            }
        }
        private int mQuantity;
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }

        private decimal mPrice;
        public Decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        private DateTime mDateRecieved;
        public DateTime DateRecieved
        {
            get
            {
                return mDateRecieved;
            }
            set
            {
                mDateRecieved = value;
            }
        }

        private Boolean mAvailability;
        public bool Availability
        {
            get
            {
                //return the private data
                return mAvailability;
            }
            set
            {
                //set the private data
                mAvailability = value;
            }
        }


        public bool Find(int ProductID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", ProductID);
            // DB.Execute("sproc_tblStock_FilterByProductID");
            DB.Execute("sproc_tblStock_FilterByProductID");
            if (DB.Count == 1)
            {
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mDrinkType = Convert.ToString(DB.DataTable.Rows[0]["DrinkType"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mDateRecieved = Convert.ToDateTime(DB.DataTable.Rows[0]["DateRecieved"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                //mDrinkType = Convert.ToString("To String");
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string drinkType, string quantity, string price, string dateRecieved)
        {
            //return "";
            String Error = "";
            DateTime DateTemp;
            if (drinkType.Length == 0)
            {
                Error = Error + "This Drink type cannot be blank :";
            }
            if (drinkType.Length > 15)
            {
                Error = Error + "The Drink type must be less than 15 characters.";
            }
            if (quantity.Length == 0)
            {
                Error = Error + "The quantity must not be left blank :";
            }
            if (quantity.Length > 2)
            {
                Error = Error + "The quantity must be less than 99: ";
            }
            if (price.Length == 0)
            {
                Error = Error + "The price must not be left empty:";
            }
            if (price.Length > 18)
            {
                Error = Error + "The price cannot be more than 18 characters";
            }
            try
            {
                DateTemp = Convert.ToDateTime(dateRecieved);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future :";
                }
            }
            catch
            {
                Error = Error + "The date is not a valid date";
            }
                return Error;
            }
        }
    }





