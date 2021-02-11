﻿using System;
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
        aBranch.BranchDescription = txtBranchDescription.Text;
        aBranch.BranchId = Convert.ToInt16(txtBranchId.Text);
        aBranch.ProductId = Convert.ToInt16(txtProductId.Text);
        aBranch.StaffId = Convert.ToInt16(txtStaffId.Text);
        aBranch.BranchStartDate = Convert.ToDateTime(txtBranchStartDate.Text);
        aBranch.IsStaffAvailable = chkIsStaffAvailable.Checked;
        Session["aBranch"] = aBranch;
        //navigate to the viewer page
        Response.Redirect("BranchViewer.aspx");
    }
    
    }

    
