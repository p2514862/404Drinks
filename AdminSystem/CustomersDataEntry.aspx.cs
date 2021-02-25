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


        //ACustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        string CustomerName = txtCustomerName.Text;
        string CustomerEmail = txtCustomerEmail.Text;
        string Password = txtPassword.Text;
        string CustomerAddress = txtCustomerAddress.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        string Error = "";
        Error = ACustomer.Valid(CustomerName, CustomerEmail, Password, CustomerAddress, DateOfBirth);
        

        if (Error == "")
        {
            ACustomer.CustomerName = CustomerName;
            ACustomer.CustomerEmail = CustomerEmail;
            ACustomer.Password = Password;
            ACustomer.CustomerAddress = CustomerAddress;
            ACustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);

            Session["ACustomer"] = ACustomer;


            //Navigate to the viewer page
            Response.Redirect("CustomersViewer.aspx");

        }
        else
        {
            lblError.Text = Error;
            
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of customer class
        clsCustomers ACustomer = new clsCustomers();

        //Variable to store the primary key
        Int32 CustomerID;

        //variable to store the result of the find operation
        Boolean Found = false;

        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);

        //find the record
        Found = ACustomer.Find(CustomerID);

        //if found
        if (Found == true)
        {
            //Display values of the properties of the form
            txtCustomerName.Text = ACustomer.CustomerName;
            txtCustomerEmail.Text = ACustomer.CustomerEmail;
            txtPassword.Text = ACustomer.Password;
            txtDateOfBirth.Text = ACustomer.DateOfBirth.ToString();
        }

    }
}