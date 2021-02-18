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
    }
}

