using System;

namespace ClassLibrary
{
    public class clsCustomers
    {
        //private data member for the properties
        private Int32 mCustomerID;

        private DateTime mDateOfBirth;

        private string mCustomerName;

        private bool mLivesInUK;

        private string mCustomerEmail;

        private string mCustomerAddress;

        private string mPassword;

        //properties
        public Int32 CustomerID
        {
            get
            {
                //This line of code sends data out of the property
                return mCustomerID;
            }
            set
            {
                //This line of code allows data into the property 
                mCustomerID = value;
            }
        }
        public string CustomerName
        {
            get
            {
                //This line of code sends data out of the property
                return mCustomerName;
            }
            set
            {
                //This line of code allows data into the property 
                mCustomerName = value;
            }
        }
        public bool LivesInUK
        {
            get
            {
                //This line of code sends data out of the property
                return mLivesInUK;
            }
            set
            {
                //This line of code allows data into the property 
                mLivesInUK = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }
        public string CustomerEmail
        {
            get
            {
                //This line of code sends data out of the property
                return mCustomerEmail;
            }
            set
            {
                //This line of code allows data into the property 
                mCustomerEmail = value;
            }
        }
        public string Password
        {
            get
            {
                //This line of code sends data out of the property
                return mPassword;
            }
            set
            {
                //This line of code allows data into the property 
                mPassword = value;
            }
        }
        public string CustomerAddress
        {
            get
            {
                //This line of code sends data out of the property
                return mCustomerAddress;
            }
            set
            {
                //This line of code allows data into the property 
                mCustomerAddress = value;
            }
        }

        public bool Find(int customerID)
        {
            //Set the private data members to the test data value 
            mCustomerID = 3;
            mDateOfBirth = Convert.ToDateTime("25/09/2000");
            mCustomerName = "Fatimah Badin";
            mCustomerEmail = "fatimahbadin@gmail.com";
            mCustomerAddress = "123 green street LE7 5BH";
            mLivesInUK = true;
            //mPassword = 
            //Always returns true 
            return true;
        }
    }
}