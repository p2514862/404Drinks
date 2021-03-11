using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsBranchCollection
    {
        //private data member of the list 
        List<clsBranch> mBranchList = new List<clsBranch>();

        public List<clsBranch> BranchList
        {
            get
            {
                //return the private data 
                return mBranchList;
            }
            set
            {
                //set the private data
                mBranchList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list 
                return mBranchList.Count;
            }
            set
            {
                //we shall worry about this later 
            }
        }
        //constructor for the class 
        public clsBranchCollection()
        {
            //var for the index 
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure 
            DB.Execute("sproc_tblBranch_SelectAll");
            //get the count of the records 
            RecordCount = DB.Count;
            //while there are records to process 
            while (Index < RecordCount)
            {
                //create a blank branch 
                clsBranch aBranch = new clsBranch();
                //read in the fields from the current record 
                aBranch.IsStaffAvailable = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsStaffAvailable"]);
                aBranch.BranchId = Convert.ToInt32(DB.DataTable.Rows[Index]["BranchId"]);
                aBranch.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                aBranch.ProductId = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductId"]);
                aBranch.BranchStartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["BranchStartDate"]);
                aBranch.BranchDescription = Convert.ToString(DB.DataTable.Rows[Index]["BranchDescription"]);
                //add the record to the private data memeber 
                mBranchList.Add(aBranch);
                //point at the next record 
                Index++;
            }

        }

        public clsBranch ThisBranch { get; set; }
    }
}