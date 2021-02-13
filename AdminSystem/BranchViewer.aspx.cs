using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsBranch
        clsBranch aBranch = new clsBranch();
        //get the data from the session object
        aBranch = (clsBranch)Session["aBranch"];
        //displays the product description for this entry 
        Response.Write(aBranch.BranchDescription + "\n\n");
        Response.Write(aBranch.BranchId + "\n\n");
        Response.Write(aBranch.StaffId + "\n\n");
        Response.Write(aBranch.ProductId + "\n\n");
        Response.Write(aBranch.BranchStartDate + "\n\n");
        Response.Write(aBranch.IsStaffAvailable + "\n\n");


    }
    
}