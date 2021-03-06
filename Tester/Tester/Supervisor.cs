﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Supervisor
    {
        //supervisor ID
        private string srId;
        //list of all employees
        private List<Employee> emps;
        DBConnect d1 = new DBConnect();
        //list of employee ids who have overtime(OT)/Paid Time Off(PTO) hours
        private List<string> empIds;
        //list of OT/PTO Hours 
        private List<double> hours;

        public Supervisor()
        {
            srId = "";
            emps = new List<Employee>();
            empIds = new List<string>();
            hours = new List<double>();
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
        public List<double> getHours() { return hours; }

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
                tio.selectHours(emps[x].getId(), i, o);
                if (tio.getTotal() > 40 && tio.getTotal() != 0)
                {
                    getEmpIds().Add(emps[x].getId());
                    getHours().Add(tio.getTotal());
                }
            }
        }

        //Method for selecting reported Paid Time Off and Absences
        //Selects TimeWorked from EmpTime Table between 2 DateTimes where Absence = true, sets double Total to figure out how many
        //absence hours were reported
        public void selectAbsence(DateTime i, DateTime o)
        {
            TimeIO tio = new TimeIO();
            for (int x = 0; x < emps.Count(); x++)
            {
                tio.selectAbsence(emps[x].getId(), i, o);
                if (tio.getTotal() > 0)
                {
                    getEmpIds().Add(emps[x].getId());
                    getHours().Add(tio.getTotal());
                }
            }
        }

        public void display()
        {
            Employee e1 = new Employee();
            //list all employees
            for (int x = 0; x < emps.Count(); x++)
            {
                Console.WriteLine("EMPLOYEE -- " + emps[x].getId());
            }

            //all overtime Employees with ot hours
            for (int x = 0; x < empIds.Count(); x++)
            {
                e1.selectEmp(empIds[x]);
                Console.WriteLine("Overtime Employee: " + e1.getFName() + " " + e1.getLName());
                Console.WriteLine("Overtime Hours Worked: " + (((int)(hours[x]) - 40) + " Hours and " + (hours[x] - (int)hours[x]) * 60) + " minutes.");
            }

            //all pto hours
            for (int x = 0; x < empIds.Count(); x++)
            {
                e1.selectEmp(empIds[x]);
                Console.WriteLine("Absent Employee: " + e1.getFName() + " " + e1.getLName());
                Console.WriteLine("PTO reported: " + ((int)(hours[x]) + " Hours and " + (hours[x] - (int)hours[x]) * 60) + " minutes.");
            }
        }
    }
}
