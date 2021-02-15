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


        public bool Find(int staffID)
        {
            mStaffID = 1;
            mBranchID = 1;
            mFullName = "Firstname Surname";
            mEmail = "ISurname@gmail.com";
            mDOB = Convert.ToDateTime("16/09/2015");
            mMonthlySalary = 1;
            mOnHoliday = true; 
            return true;
           
        }

        
        
    }

}