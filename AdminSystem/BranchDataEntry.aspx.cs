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
        //capture the house branch id
        aBranch.BranchDescription = txtBranchDescription.Text;
        //store the branch in the session object 
        Session["aBranch"] = aBranch;
        //navigate to the viewer page
        Response.Redirect("BranchViewer.aspx");
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
}