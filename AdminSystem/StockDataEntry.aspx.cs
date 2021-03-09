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

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        string DrinkType = txtDrinkType.Text;
        string Quantity = txtQuantity.Text;
        string Price = txtPrice.Text;
        string DateRecieved = txtDateReceived.Text;
        string Error = "";
        Error = AnStock.Valid(DrinkType, Quantity, Price, DateRecieved);
        if (Error == "")
        {
            AnStock.ProductID = Convert.ToInt32(txtProductID.Text);
            AnStock.DrinkType = txtDrinkType.Text;
            AnStock.Quantity = Convert.ToInt32(txtQuantity.Text);
            AnStock.Price = Convert.ToDecimal(txtPrice.Text);
            AnStock.DateRecieved = Convert.ToDateTime(txtDateReceived.Text);
            AnStock.Availability = chkAvailability.Checked;
            // AnStock.Availability = Convert.ToBoolean(txtAvailability.Text);
            Session["AnStock"] = AnStock;
            //Response.Write("StockViewer.aspx");
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        Int32 ProductID;
        Boolean Found = false;
        ProductID = Convert.ToInt32(txtProductID.Text);
        Found = AnStock.Find(ProductID);
        if (Found == true)
        {
            txtProductID.Text = AnStock.ProductID.ToString();
            txtDrinkType.Text = AnStock.DrinkType;
            txtQuantity.Text = AnStock.Quantity.ToString();
            txtPrice.Text = AnStock.Price.ToString();
            txtDateReceived.Text = AnStock.DateRecieved.ToString();
        }
    }
}
