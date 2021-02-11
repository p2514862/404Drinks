using System;
using System.Collections.Generic;
using System.Linq;
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
        //AnStaff.MonthlySalary = Convert.ToInt16(txtMonthlyS.Text); 
       // AnStaff.OnHoliday = Convert.ToBoolean(chkOnHoliday);
        Session["AnStaff"] = AnStaff;
        Response.Redirect("StaffViewer.aspx");

        
      
    }
}