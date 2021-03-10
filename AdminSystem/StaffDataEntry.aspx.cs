using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        //String StaffID = Convert.ToInt16(txtStaffID.Text);
        String BranchID = txtBranchID.Text;
        String FullName = txtFullName.Text;
        String DOB = txtDOB.Text;
        String Email = txtEmail.Text;
        String MonthlySalary = txtMonthlyS.Text;
        //String OnHoliday = chkOnHoliday.Checked; 

        String Error = "";
        Error = AnStaff.Valid(BranchID, FullName, DOB, Email, MonthlySalary);
        if (Error == "")
        {
            AnStaff.BranchID = Convert.ToInt32(txtBranchID.Text);
            AnStaff.FullName = txtFullName.Text;
            AnStaff.DOB = Convert.ToDateTime(txtDOB.Text);
            AnStaff.Email = txtEmail.Text;
            AnStaff.MonthlySalary = Convert.ToDecimal(txtMonthlyS.Text);
            AnStaff.OnHoliday = chkOnHoliday.Checked;
            clsStaffCollection StaffList = new clsStaffCollection();
            StaffList.ThisStaff = AnStaff;
            StaffList.Add();
           // Session["AnStaff"] = AnStaff;
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

        
      
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        Int32 StaffID;
        Boolean Found = false;
        StaffID = Convert.ToInt32(txtStaffID.Text);
        Found = AnStaff.Find(StaffID);
        if (Found == true)
        {
            txtStaffID.Text = AnStaff.StaffID.ToString();
            txtBranchID.Text = AnStaff.BranchID.ToString();
            txtFullName.Text = AnStaff.FullName;
            txtDOB.Text = AnStaff.DOB.ToString();
            txtEmail.Text = AnStaff.Email;
            txtMonthlyS.Text = AnStaff.MonthlySalary.ToString();
            

        }
        
    }
}