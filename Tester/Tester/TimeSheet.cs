using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class TimeSheet
    {
        private int count = 0;
        private string empID;
        private List<TimeIO> ts;
        DBConnect d1 = new DBConnect();

        public TimeSheet()
        {
            empID = "";
            ts = new List<TimeIO>();
        }

        public TimeSheet(string id)
        {
            empID = id;
            timeSheetSelect(getEmpID());
        }

        public void setEmpID(string id) { empID = id; }
        public string getEmpID() { return empID; }
        public List<TimeIO> getTS() { return ts; }

        public void timeSheetSelect(string id)
        {
            d1.DBSetup();

            d1.cmd = "Select * from EmpTime where EmpId ='" + id + "'";
            d1.SqlDataAdapter.SelectCommand.CommandText = d1.cmd;
            d1.SqlDataAdapter.SelectCommand.Connection = d1.SqlDbConection2;
            try
            {
                d1.SqlDbConection2.Open();

                System.Data.SqlClient.SqlDataReader dr;
                dr = d1.SqlDataAdapter.SelectCommand.ExecuteReader();

                while (dr.Read())
                {
                    TimeIO t1 = new TimeIO((String)dr.GetValue(1), (DateTime)dr.GetValue(2), (DateTime)dr.GetValue(3), (String)dr.GetValue(4));
                    getTS().Add(t1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something happened: " + e);
            }
            finally
            {
                d1.SqlDbConection2.Close();
            }
        }

        public void display()
        {
            for (int x = 0; x < ts.Count(); x++)
            {
                Console.WriteLine("EMPLOYEE -- " + ts[x].getId());
                Console.WriteLine("TIME IN  -- " + ts[x].getClockIn());
                Console.WriteLine("TIME OUT -- " + ts[x].getClockOut());
                Console.WriteLine("Reason Out -- " + ts[x].getReasonOut());
            }
        }
    }
}
