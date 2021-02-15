﻿using System;
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
        AnStock.ProductID = Convert.ToInt32(txtProductID.Text);
        AnStock.DrinkType = txtDrinkType.Text;
        AnStock.Quantity = Convert.ToInt32(txtQuantity.Text);
        AnStock.Price = Convert.ToDecimal(txtPrice.Text);
        AnStock.DateRecieved = Convert.ToDateTime(txtDateReceived.Text);
        AnStock.Availability = chkAvailability.Checked;
       // AnStock.Availability = Convert.ToBoolean(txtAvailability.Text);
        Session["AnStock"] = AnStock;
        Response.Redirect("StockViewer.aspx");
    }

}
