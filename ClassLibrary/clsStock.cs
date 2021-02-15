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


        public bool Find(int productID)
        {
            //set the private data members to the test data value
            mProductID = 1;
            mDrinkType = "fizzy";
            mQuantity = 1;
            mPrice = 1;
            mDateRecieved = Convert.ToDateTime("16/9/2015");
            mAvailability = true;
            //mDrinkType = Convert.ToString("To String");
            return true;
        }
    }
}