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
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["Royal Mail"];
        Response.Write(AnOrder.OrderIDOK);
        Response.Write(AnOrder.CustomerIDOK);
        Response.Write(AnOrder.ProductIDOK);
        Response.Write(AnOrder.DateOfPurchase);
        Response.Write(AnOrder.TotalPriceOK);        
        Response.Write(AnOrder.ShippingCompany);

    }
}