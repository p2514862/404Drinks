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
        /*
        lstOrders.DataSource = Orders.OrderList;
        lstOrders.DateValueField = "OrderID";
        lstOrders.DataText = "ShippingCompany";
        lstOrders.DataBind();
        */

    }
}