﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaffs();

        }

    }
    void DisplayStaffs()
    {
        clsStaffCollection Staffs = new clsStaffCollection();
        lstStaffList.DataSource = Staffs.StaffList;
        lstStaffList.DataValueField = "StaffID";
        lstStaffList.DataTextField = "Email";
        lstStaffList.DataBind();



    }
}