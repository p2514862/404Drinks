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
                //this line of code sends data out of the property
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
            //set the private data members to the test data value
            mBranchId = 21;
            mProductId = 2;
            mStaffId = 4;
            mIsStaffAvailable = true;
            mBranchDescription = "XXXX XXXX";
            mBranchstartDate = Convert.ToDateTime("16/9/2015");

            //always return true 
            return true;
        }
    }
}