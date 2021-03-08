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
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            AnOrder.ProductID = Convert.ToInt32(ProductID);
            AnOrder.TotalPrice = Convert.ToDecimal(TotalPrice);
            AnOrder.DateOfPurchase = Convert.ToDateTime(DateOfPurchase);
            AnOrder.ShippingCompany = ShippingCompany;
            AnOrder.Over18 = chkOver18.Checked;

            clsOrderCollection OrderList = new clsOrderCollection();
            OrderList.ThisOrder = AnOrder;
            OrderList.Add();
            Response.Redirect("OrderList.aspx");
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