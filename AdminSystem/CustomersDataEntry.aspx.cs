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

    protected void btnConfirm_Click(object sender, EventArgs e)
    {

    }

    protected void btnConfirm_Click1(object sender, EventArgs e)
    {
        clsCustomers ACustomer = new clsCustomers();

        ACustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        ACustomer.CustomerName = txtCustomerName.Text;
        ACustomer.CustomerEmail = txtCustomerEmail.Text;
        ACustomer.Password = txtPassword.Text;
        ACustomer.CustomerAddress = txtCustomerAddress.Text;
        ACustomer.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);

        Session["ACustomer"] = ACustomer;

        //Navigate to the viewer page
        Response.Redirect("CustomersViewer.aspx");
    }
}