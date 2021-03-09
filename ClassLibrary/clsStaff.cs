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

        public string Valid(string branchID, string fullName, string dOB, string email, string monthlySalary)
        {
            DateTime DateTemp;
            String Error = "";
            if (branchID.Length == 0)
            {
                Error = Error + "This branch does not exist)"; 
            }
            if (branchID.Length > 2)
            {
                Error = Error + "This branch does not exist, It Showld be two  digit number";
            }
            if (email.Length == 0) 
            {
                Error = Error + "The email may not be blank : ";
            }
            if (email.Length > 50)
            {

                Error = Error + "The email must be less than 50 characters : ";
            }
            if (fullName.Length == 0)
            {
                Error = Error + "The fullname may not be blank : ";
            }
            if (fullName.Length > 100)
            {

                Error = Error + "The fullname must be less than 100 characters : ";
            }
            if (monthlySalary.Length == 0)
            {
                Error = Error + "The monthly salary may not be blank : ";
            }
            if (monthlySalary.Length > 10)
            {

                Error = Error + "The monthlysalary must be less than 10 characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(dOB);

                if (DateTemp < DateTime.Now.Date.AddYears(-65))
                {

                    Error = Error + "The Date of birth shows the person is too old : ";
                }

                if (DateTemp > DateTime.Now.Date.AddYears(-16))
                {
                    Error = Error + "The Date of birth shows the person is too young : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";

            }
            return Error;
        }
    }
}






