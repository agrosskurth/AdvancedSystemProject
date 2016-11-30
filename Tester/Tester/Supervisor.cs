using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Supervisor
    {
        private string srId;
        private List<Employee> emps;
        DBConnect d1 = new DBConnect();
        private List<string> empIds;

        public Supervisor()
        {
            srId = "";
            emps = new List<Employee>();
        }

        public Supervisor(string sid)
        {
            setSrId(sid);
            selectEmps(getSrId());
        }

        public void setSrId(string sid) { srId = sid; }
        public string getSrId() { return srId; }
        public List<Employee> getEmps() { return emps; }
        public List<string> getEmpIds() { return empIds; }

        public void selectEmps(string sid)
        {
            d1.DBSetup();

            d1.cmd = "Select * from EmpInfo where SRID ='" + sid + "'";
            d1.SqlDataAdapter.SelectCommand.CommandText = d1.cmd;
            d1.SqlDataAdapter.SelectCommand.Connection = d1.SqlDbConection2;
            try
            {
                d1.SqlDbConection2.Open();

                System.Data.SqlClient.SqlDataReader dr;
                dr = d1.SqlDataAdapter.SelectCommand.ExecuteReader();

                while (dr.Read())
                {
                    Employee e1 = new Employee(dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(5).ToString(), dr.GetValue(6).ToString(), dr.GetValue(7).ToString(), Convert.ToBoolean(dr.GetValue(8)), Convert.ToBoolean(dr.GetValue(9)), Convert.ToBoolean(dr.GetValue(10)), dr.GetValue(11).ToString(), Convert.ToBoolean(dr.GetValue(12)));
                    e1.Display();
                    getEmps().Add(e1);
                    Console.WriteLine(Convert.ToString(emps.Count()));
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

        //Method for Selecting hours worked between two given DateTimes.
        //Selects TimeWorked from EmpTime table between 2 DateTimes, sets double Total to figure out hours worked in that time frame.
        public void selectOvertime(DateTime i, DateTime o)
        {
            TimeIO tio = new TimeIO();
            for (int x = 0; x < emps.Count(); x++)
            {
                Console.WriteLine(emps[x].getId() + "");
                tio.selectHours(emps[x].getId(), i, o);
                if (tio.getTotal() < 40)
                {
                    getEmpIds().Add(emps[x].getId());
                }
            }
            for (int x = 0; x < empIds.Count(); x++)
            {
                Console.WriteLine("EmpId = " + empIds[x]);
                tio.selectHours(empIds[x], i, o);
                Console.WriteLine(tio.getTotal());
            }
        }
        

        public void display()
        {
            for (int x = 0; x < emps.Count(); x++)
            {
                Console.WriteLine("EMPLOYEE -- " + emps[x].getId());
            }
        }
    }
}
