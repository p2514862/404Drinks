using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsStaffCollection
    {

        List<clsStaff> mStaffList = new List<clsStaff>();

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;

            }
            set
            {
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStaffList.Count;

            }
            set
            {
                //worry about it later
            }
        }
        public clsStaff ThisStaff { get; set; }
       
        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                AnStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnStaff.BranchID = Convert.ToInt32(DB.DataTable.Rows[Index]["BranchID"]);
                AnStaff.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                AnStaff.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                AnStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnStaff.OnHoliday = Convert.ToBoolean(DB.DataTable.Rows[Index]["OnHoliday"]);
                mStaffList.Add(AnStaff);
                Index++;


            }
            
        }


    }
}
  

    
