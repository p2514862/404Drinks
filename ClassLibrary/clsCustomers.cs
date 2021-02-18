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

        public bool Find(int CustomerID)
        {
            //create an intance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the customer id to search for
            DB.AddParameter("CustomerID", CustomerID);
            //Execute the stored procedure
            DB.Execute("sproc_tblCustomers_FilterByCustomerID");
            //if one record found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mLivesInUK = Convert.ToBoolean(DB.DataTable.Rows[0]["LivesInUK"]);

                //Return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //resturn false indicating a problem
                return false;
            }

        }
    }
}