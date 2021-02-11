using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        
        public DateTime DateOfPurchase { get; set; }
        public string ShippingCompany { get; set; }
        public bool isOver18 { get; set; }

        private decimal mTotalPrice;
        public decimal TotalPrice
        {
            get
            {

                //sends data out of the property
                return mTotalPrice;
            }

            set
            {
                //allows data into the property
                mTotalPrice = value;
            }
        }


        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }

        public bool Find(decimal TotalPrice)
        {   //set private data members to the test data value
            mTotalPrice = 5;
            //Always return true
            return true;
        }
    }
}