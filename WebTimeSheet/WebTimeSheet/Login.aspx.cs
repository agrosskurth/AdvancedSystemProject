using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTimeSheet
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //Instantiate the string that will be used later for the session id
        string eid;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Clear any previous employee's information from the session
            Session["EmployeeID"] = null;
            Session["EmployeeFName"] = null;
            Session["EmployeeLName"] = null;
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Connect to the DB and authenticate the information the user has input
            Authentication a1 = new Authentication(txtID.Text, txtPassword.Text);
            a1.SelectDB();
            
            if (a1.worked.Equals(true))
            {
                /*
                Set our local variable equal to the authenticated user id
                Use our employee class to retrieve the users first and last name from the Database
                Finally we redirect the user to our home.aspx page
                */
                eid = txtID.Text;
                Employee e1 = new Employee();
                e1.selectEmp(eid);
                Session["EmployeeFName"] = e1.getFName();
                Session["EmployeeLName"] = e1.getLName();
                Session["EmployeeID"] = eid;
                Response.Redirect("Home.aspx");
            }
            else if (a1.worked.Equals(false))
            {
                //If the authentication fails, we clear the text boxes and 
                //make the error lable visible on the webpage
                txtID.Text = "";
                txtPassword.Text = "";
                labelIncorrect.Visible = true;
            }
        }

        protected void btnAbout_Click(object sender, EventArgs e)
        {
            //Clicking the about button redirects the user to our about.aspx page
            Response.Redirect("About.aspx");
        }

        
        //This mirrors the login button for the most part
        protected void btnLoginSR_Click(object sender, EventArgs e)
        {
            //Connect to the DB and authenticate the information the user has input
            Authentication a1 = new Authentication(txtID.Text, txtPassword.Text);
            a1.SelectDB();

            //The nested if statment checks if the user is a supervisor or an hr employee,
            //and will redirect them to the supervisor home page.
            if (a1.worked.Equals(true))
            {
                eid = txtID.Text;
                Employee e1 = new Employee();
                e1.selectEmp(eid);
                if(e1.getSR().Equals(true))
                {
                    Session["EmployeeFName"] = e1.getFName();
                    Session["EmployeeLName"] = e1.getLName();
                    Session["EmployeeID"] = eid;
                    Session["EmployeeSR"] = true;
                    Session["EmployeeHR"] = false;
                    Response.Redirect("HomeSR.aspx");
                }
                else if(e1.getHR().Equals(true))
                {
                    Session["EmployeeFName"] = e1.getFName();
                    Session["EmployeeLName"] = e1.getLName();
                    Session["EmployeeID"] = eid;
                    Session["EmployeeSR"] = false;
                    Session["EmployeeHR"] = true;
                    Response.Redirect("HomeSR.aspx");
                }
                else
                {
                    txtID.Text = "";
                    txtPassword.Text = "";
                    labelIncorrect.Visible = true;
                }
            }
            else if (a1.worked.Equals(false))
            {
                //If the authentication fails, we clear the text boxes and 
                //make the error lable visible on the webpage
                txtID.Text = "";
                txtPassword.Text = "";
                labelIncorrect.Visible = true;
            }
        }
    }
}