using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class BranchList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayBranches();
        }

    }
    public void DisplayBranches()
    {
        //create an instance of the County Collection 
        clsBranchCollection Branches = new clsBranchCollection();

        //set the data source to the list of counties in the collection
        lstBranchList.DataSource = Branches.BranchList;
        //set the name of the primary key
        lstBranchList.DataValueField = "BranchId";
        //set the data feild to display 
        lstBranchList.DataTextField = "ProductId";
        //bind the data to the list 
        lstBranchList.DataBind();
    }
}