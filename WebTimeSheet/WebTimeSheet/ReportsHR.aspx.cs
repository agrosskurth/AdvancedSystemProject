using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTimeSheet
{
    public partial class ReportsHR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAllTimeSheets_Click(object sender, EventArgs e)
        {
            lbReports.Items.Clear();
            Employee e1 = new Employee();
            HR h1 = new HR();
            h1.selectEmps();
            h1.selectOvertime(new DateTime(2014, 5, 5, 0, 0, 0), new DateTime(2014, 5, 9, 23, 59, 59));
            for(int x = 0; x < h1.empIds.Count(); x++)
            {
                e1.selectEmp(h1.empIds[x]);
                string a = (h1.empIds[x] + " " + ((int)(h1.hours[x] - 40) + " Hours and " + (h1.hours[x] - (int)h1.hours[x]) * 60) + " minutes.");
                lbReports.Items.Add(a);
            }
        }
    }
}