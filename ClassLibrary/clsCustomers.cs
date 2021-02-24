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

        public string Valid(string customerName, string customerEmail, string password, string customerAddress, object dateOfBirth)
        {
            //create string variable to store error;
            String Error = "";
         

            //if blank
            if (customerName.Length == 0)
            {
                //record error
                Error = Error + "The name field should not be left blank. ";
            }
            //if customer name is no greater than 50 chars
            if(customerName.Length > 50)
            {
                //record error
                Error = Error + "The name field must be less than 50 characters. "; 
            }

            //Customer Email
            if(customerEmail.Length == 0)
            {
                Error = Error + "The email field cannot be left blank. ";
            }
            if(customerEmail.Length > 100)
            {
                Error = Error + "The email is too long, it should be 100 characters or less. ";
            }

            //Password
            if(password.Length < 8 )
            {
                Error = Error + "The password is too short. ";
            }
            if(password.Length > 60)
            {
                Error = Error + "The password is too long, it should be 60 characters or less. ";
            }


            //CustomerAddress
            if(customerAddress.Length == 0)
            {
                Error = Error + "The address field cannot be left blank. ";
            }
            if(customerAddress.Length > 150)
            {
                Error = Error + "The address is too long, it should be 150 characters or less. ";
            }


            //return error message
            return Error;
        }

        public string Valid2(string customerName, string customerEmail, string password, string customerAddress, string dateOfBirth)
        {

            //create string variable to store error;
            String Error = "";

            //create temp variable to store data values
            DateTime DateTemp;
            DateTime tLess16 = DateTime.Now.Date.AddYears(-16);
            DateTime tMoreThan100 = DateTime.Now.Date.AddYears (-100);

            try
            {


                //copy dateOfBirth value to DateTemp
                DateTemp = Convert.ToDateTime(dateOfBirth);


                if (DateTemp < tMoreThan100)
                {
                    Error = Error + "Too old ";
                }
                if (DateTemp > tLess16)
                {
                    Error = Error + "Too young ";
                }
            }
            catch
            {
                Error = Error + "That is not a valid date. ";
            }

            return Error;

        }
    }
}