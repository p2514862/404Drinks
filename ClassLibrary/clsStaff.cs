using System;

namespace ClassLibrary
{
 
    public class clsStaff
    {
        private Int32 mStaffID;
        private Int32 mBranchID;
        private String mFullName;
        private DateTime mDOB;
        private String mEmail;
        private Decimal mMonthlySalary;
        private Boolean mOnHoliday; 

        public Int32 StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
        public string FullName
        {
            get
            {
                return mFullName;
            }
            set
            {

                mFullName = value;
            }
        }
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {

                mEmail = value;
            }
        }
        public bool OnHoliday
        {
            get
            {
                return mOnHoliday;
            }
            set
            {

                mOnHoliday = value;
            }
        }
        public int BranchID
        {
            get
            {
                return mBranchID;
            }
            set
            {

                mBranchID = value;
            }
        }
        public decimal MonthlySalary
        {
            get
            {
                return mMonthlySalary;
            }
            set
            {

                mMonthlySalary = value;
            }
        }
        public DateTime DOB
        {
            get
            {
                return mDOB;
            }
            set
            {

                mDOB = value;
            }
        }


        public bool Find(int StaffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            if (DB.Count == 1)
            {

                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mBranchID = Convert.ToInt32(DB.DataTable.Rows[0]["BranchID"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mMonthlySalary = Convert.ToDecimal(DB.DataTable.Rows[0]["MonthlySalary"]);
                mOnHoliday = Convert.ToBoolean(DB.DataTable.Rows[0]["OnHoliday"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        
        
    }

}