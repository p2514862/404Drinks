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
        AnStaff.StaffID = Convert.ToInt16(txtStaffID.Text);
        AnStaff.BranchID = Convert.ToInt16(txtBranchID.Text);
        AnStaff.FullName = txtFullName.Text;
        AnStaff.DOB = Convert.ToDateTime(txtDOB.Text);
        AnStaff.Email = txtEmail.Text;
        AnStaff.MonthlySalary = Convert.ToDecimal(txtMonthlyS.Text); 
        AnStaff.OnHoliday = chkOnHoliday.Checked; 
        Session["AnStaff"] = AnStaff;
        Response.Redirect("StaffViewer.aspx");

        
      
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