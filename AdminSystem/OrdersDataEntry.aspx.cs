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
        string CustomerID = txtCustomerID.Text;
        string ProductID = txtProductID.Text;
        string ShippingCompany = txtShippingCompany.Text;
        string DateOfPurchase = txtDateOfPurchase.Text;
        string TotalPrice = txtTotalPrice.Text;
        //Variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnOrder.Valid(ShippingCompany, CustomerID, ProductID, DateOfPurchase, TotalPrice);
        if (Error == "")
        {
            AnOrder.OrderID = Convert.ToInt32(txtOrderID.Text);
            AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            AnOrder.ProductID = Convert.ToInt32(txtProductID.Text);
            AnOrder.DateOfPurchase = Convert.ToDateTime(txtDateOfPurchase.Text);
            AnOrder.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
            AnOrder.ShippingCompany = txtShippingCompany.Text;

            Session["Royal Mail"] = AnOrder;
            Response.Redirect("OrdersViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(txtOrderID.Text);
        Found = AnOrder.Find(OrderID);
        if (Found == true)
        {
            
            txtCustomerID.Text = Convert.ToString (AnOrder.CustomerID);
            txtProductID.Text = Convert.ToString(AnOrder.ProductID);
            txtDateOfPurchase.Text = Convert.ToString(AnOrder.DateOfPurchase);
            txtTotalPrice.Text = Convert.ToString(AnOrder.TotalPrice);
            txtShippingCompany.Text = Convert.ToString(AnOrder.ShippingCompany);

        }
    }
}