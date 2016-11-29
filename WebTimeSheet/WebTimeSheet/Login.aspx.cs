﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTimeSheet
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Authentication a1 = new Authentication(txtID.Text, txtPassword.Text);
            a1.SelectDB();
            
            if (a1.worked.Equals(true))
            {
                Response.Redirect("Home.aspx");
            }
            else if (a1.worked.Equals(false))
            {
                txtID.Text = "";
                txtPassword.Text = "";
                labelIncorrect.Visible = true;
            }
        }

        protected void btnAbout_Click(object sender, EventArgs e)
        {
            Response.Redirect("About.aspx");
        }
    }
}