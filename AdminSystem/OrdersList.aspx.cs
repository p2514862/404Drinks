using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }
    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();

        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "ShippingCompany";
        lstOrderList.DataBind();
        

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Store -1 into the session oject to indicate this is a new record
        Session["OrderID"] = -1;
        //Redirect to the data entry page
        Response.Redirect("AnOrder.aspx");
    }
}