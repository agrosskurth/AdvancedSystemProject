using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTimeSheet
{
    public partial class TimeSheet1 : System.Web.UI.Page
    {
        //Instantiate all variables
        private int hin;
        private int hout;
        private int min;
        private int mout;
        private string r;
        private int hoursIn;
        private int minutesIn;
        private int hoursOut;
        private int minutesOut;
        private string year;
        private DateTime date;
        private DateTime dtIn;
        private DateTime dtOut;
        protected void Page_Load(object sender, EventArgs e)
        {
           //Get the current date from the operating system
           //and set the lables to display the date to the user
           year = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
           date = DateTime.Parse(year);
           lblDay.Text = date.Day.ToString();
           lblMonth.Text = date.Month.ToString();
           lblYear.Text = date.Year.ToString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Set variables equal to the selected index number from the dropdown lists
            hin = ddlHoursIn.SelectedIndex;
            min = ddlMinutesIn.SelectedIndex;
            hout = ddlHoursOut.SelectedIndex;
            mout = ddlMinutesOut.SelectedIndex;
            r = ddlReason.SelectedValue;
            year = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            //Try catch the if statement
            try
            {
                /*
                Use the employee id session object we got from the login page to
                use for the TimeIO constructor.
                We use the index number to tell which item is selected, 
                and we have a filler item for each dropdown list. This means
                we have to subtract the index number by 1 to get the proper number
                for the hours and minutes.
                Create two date time objects for clock in and clock out and run insertTime().
                */
                if(hin > 0 && min > 0 && hout > 0 && mout > 0)
                {
                    string id = Session["EmployeeID"].ToString();
                    hoursIn = hin - 1;
                    minutesIn = min - 1;
                    hoursOut = hout - 1;
                    minutesOut = mout - 1;
                    dtIn = new DateTime(date.Year, date.Month, date.Day, hoursIn, minutesIn, 00);
                    dtOut = new DateTime(date.Year, date.Month, date.Day, hoursOut, minutesOut, 00);
                    TimeIO t1 = new TimeIO( id , dtIn , dtOut , r , 0);
                    t1.insertTime();

                    //Change the visibility of the lables depending on if the user is successful in
                    //inserting a time sheet
                    lblError.Visible = false;
                    lblSuccess.Visible = true;
                }
                else
                {
                    //If the user hasn't selected an item for all dropdown lists
                    //we set the error label visible and success label invisible
                    lblSuccess.Visible = false;
                    lblError.Visible = true;
                }
            }
            catch(Exception)
            {
                
            }
            finally
            {
                //Finally we set the dropdown lists to the default index
                ddlHoursIn.SelectedIndex = 0;
                ddlHoursOut.SelectedIndex = 0;
                ddlMinutesIn.SelectedIndex = 0;
                ddlMinutesOut.SelectedIndex = 0;
                ddlReason.SelectedIndex = 0;
            }
        }
    }
}