using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int StaffID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool OnHoliday { get; set; }
        public int BranchID { get; set; }
        
        public decimal MonthlySalary { get; set; }
        public DateTime DOB { get; set; }
    }
}