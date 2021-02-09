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
        clsOrder AnOrder = new clsOrder();
        AnOrder.OrderIDOK = Convert.ToInt16(txtOrderID.Text);
        AnOrder.CustomerIDOK = Convert.ToInt16(txtCustomerID.Text);
        AnOrder.ProductIDOK = Convert.ToInt16(txtProductID.Text);
        AnOrder.DateOfPurchase = Convert.ToDateTime(txtDateOfPurchase.Text);     
        AnOrder.TotalPriceOK = Convert.ToInt16 (txtTotalPrice.Text);
        AnOrder.ShippingCompany = txtShippingCompany.Text;

        Session["Royal Mail"] = AnOrder;
        Response.Redirect("OrdersViewer.aspx");
    }
}