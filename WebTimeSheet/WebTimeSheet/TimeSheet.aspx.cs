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
           year = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
           date = DateTime.Parse(year);
            lblDate.Text = date.Date.ToString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            hin = ddlHoursIn.SelectedIndex;
            min = ddlMinutesIn.SelectedIndex;
            hout = ddlHoursOut.SelectedIndex;
            mout = ddlMinutesOut.SelectedIndex;
            r = ddlReason.SelectedValue;
            year = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            try
            {
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
                }
            }
            catch(Exception)
            {
            
            }
            finally
            {
                ddlHoursIn.SelectedIndex = 0;
                ddlHoursOut.SelectedIndex = 0;
                ddlMinutesIn.SelectedIndex = 0;
                ddlMinutesOut.SelectedIndex = 0;
                ddlReason.SelectedIndex = 0;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}