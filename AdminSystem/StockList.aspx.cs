using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        //create an instance of the County collection
        clsStockCollection Stock = new clsStockCollection();
        lstStockList.DataSource = Stock.StockList;
        //set the data source to the list of counties in the collection
        lstStockList.DataValueField = "ProductID";
        //set the data field to display
        lstStockList.DataTextField = "DrinkType";
        //bind the data to the list
        lstStockList.DataBind();
    }
}