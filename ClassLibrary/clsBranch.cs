using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLibrary
{
    public class clsBranch
    {


        //private data member for the BranchId property
        private Int32 mBranchId;
        public Int32 BranchId
        {
            get
            {
                return mBranchId;
            }
            set
            {
                //this line of code allows data into the property
                mBranchId = value;
            }
        }


        private Boolean mIsStaffAvailable;
        public bool IsStaffAvailable
        {
            get
            {
                return mIsStaffAvailable;
            }
            set
            {
                mIsStaffAvailable = value;
            }
        }


        private DateTime mBranchstartDate;
        public DateTime BranchStartDate
        {
            get
            {
                return mBranchstartDate;
            }
            set
            {
                mBranchstartDate = value;
            }
        }


        private Int32 mStaffId;
        public int StaffId
        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
        }


        private String mBranchDescription;
        public string BranchDescription
        {
            get
            {
                return mBranchDescription;
            }
            set
            {
                mBranchDescription = value;
            }
        }


        private Int32 mProductId;
        public int ProductId
        {
            get
            {
                return mProductId;
            }
            set
            {
                mProductId = value;
            }
        }


        public bool Find(int branchId)
        {
            //create an instance of data connection
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BranchId", branchId);
            DB.Execute("sproc_tblBranch_FilterByBranchId");

            if (DB.Count == 1)
            {
                mBranchId = Convert.ToInt32(DB.DataTable.Rows[0]["BranchId"]);
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mBranchDescription = Convert.ToString(DB.DataTable.Rows[0]["BranchDescription"]);
                mBranchstartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["BranchStartDate"]);
                mIsStaffAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["IsStaffAvailable"]);
                //return that everything worked OK
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Valid(string productId, string staffId, string branchDescription, string branchStartDate)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values 
            DateTime DateTemp;
            //if the BranchDescription is blank 
            if (branchDescription.Length == 0)
            {
                //record the error 
                Error = Error + "The branch description may not be blank : ";
            }
            //if the branch description is greater than 100 characters 
            if (branchDescription.Length > 8)
            {
                //record the error 
                Error = Error + "The branch description must be less than 8 characters : ";

            }
            try
            {
                DateTemp = Convert.ToDateTime(BranchStartDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past :";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future :";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date :";
            }


            return Error;
            }
    
        }
    }
    
