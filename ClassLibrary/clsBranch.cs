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
    }
}
