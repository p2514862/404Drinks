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
        //create a new instance of class
        clsStock AnStock = new clsStock();
        AnStock = (clsStock)Session["Anstock"];
        Response.Write(AnStock.ProductID);
        Response.Write(AnStock.DrinkType);
        Response.Write(AnStock.Quantity);
        Response.Write(AnStock.Price);
        Response.Write(AnStock.DateRecieved);
        Response.Write(AnStock.Availability);

    }
}