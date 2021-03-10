using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomers> mCustomerList = new List<clsCustomers>();
        public List<clsCustomers> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }

        }
        public clsCustomers ThisCustomer { get; set; }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //do it later
            }
        }

        //constructor
        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomers_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCustomers ACustomer = new clsCustomers();
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                ACustomer.CustomerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                ACustomer.LivesInUK = Convert.ToBoolean(DB.DataTable.Rows[Index]["LivesInUK"]);

                mCustomerList.Add(ACustomer);
                Index++;

            }

            clsCustomers TestItem = new clsCustomers();
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Fatimah Badin";
            TestItem.CustomerEmail = "fatimah@gmail.com";
            TestItem.Password = "fatimah123";
            TestItem.CustomerAddress = "10 green street LE6 6BH";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-20);
            TestItem.LivesInUK = true;
            mCustomerList.Add(TestItem);
       
            //re initialise the object for new data 
            TestItem = new clsCustomers();
            TestItem.CustomerID = 2;
            TestItem.CustomerName = "Ayaz Suleman";
            TestItem.CustomerEmail = "asuleman@hotmail.com";
            TestItem.Password = "ayaz123";
            TestItem.CustomerAddress = "165 park street LE9 7BS";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-21);
            TestItem.LivesInUK = true;
            mCustomerList.Add(TestItem);

        }
    }
}