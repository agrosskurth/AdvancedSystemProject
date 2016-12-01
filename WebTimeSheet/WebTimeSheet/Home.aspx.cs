﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTimeSheet
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //On page load, we use the session first name and last name(acquired from the login page)
            //to fill out the welcome message with their registered name in the Database
            lblFName.Text = Session["EmployeeFName"].ToString();
            lblLName.Text = Session["EmployeeLName"].ToString();
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            //Clicking the logout button redirects the user to the login.aspx page
            Response.Redirect("~/Login.aspx");
        }
    }
}