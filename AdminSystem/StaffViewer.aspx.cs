﻿using System;
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
        clsStaff AnStaff = new clsStaff();
        AnStaff = (clsStaff)Session["AnStaff"];
        Response.Write(AnStaff.StaffID);
        Response.Write(AnStaff.BranchID);
        Response.Write(AnStaff.FullName);
        Response.Write(AnStaff.DOB);
        Response.Write(AnStaff.Email);
        Response.Write(AnStaff.MonthlySalary);
        Response.Write(AnStaff.OnHoliday);

      

    }

}