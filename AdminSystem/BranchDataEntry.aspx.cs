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
        //create a new instance of clsBranch
        clsBranch aBranch = new clsBranch();

        //capture the branch description
        string BranchDescription = txtBranchDescription.Text;
        string BranchId = txtBranchId.Text;
        string ProductId = txtProductId.Text;
        string StaffId = txtStaffId.Text;
        string BranchStartDate = txtBranchStartDate.Text;
        //variable to store any error messages
        string Error ="";
        //validate the data
        Error = aBranch.Valid(BranchDescription, StaffId, ProductId, BranchStartDate);
        if (Error == "")
        {
            //capture the attributes 
            aBranch.BranchDescription = BranchDescription;
            aBranch.StaffId = Convert.ToInt32(StaffId);
            aBranch.ProductId = Convert.ToInt32(ProductId);
            aBranch.BranchStartDate = Convert.ToDateTime(BranchStartDate);

            //IsStaffAvailable = chkIsStaffAvailable.Checked;
            Session["aBranch"] = aBranch;
            //navigate to the viewer page
            Response.Write("BranchViewer.aspx");
        }
        else
        {
            //display the error message 
            lblError.Text = Error;
            
        }
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsBranch aBranch = new clsBranch();
        Int32 branchId;
        Boolean Found = false;
        branchId = Convert.ToInt32(txtBranchId.Text);
        Found = aBranch.Find(branchId);
        if (Found == true)
        {
            txtProductId.Text = aBranch.ProductId.ToString();
            txtStaffId.Text = aBranch.StaffId.ToString();
            txtBranchDescription.Text = aBranch.BranchDescription;
            txtBranchStartDate.Text = aBranch.BranchStartDate.ToString();
        }
    }
}

    
