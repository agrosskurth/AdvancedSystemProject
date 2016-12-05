using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class HR {

        //====Properties=====

        //list of all employees
        private List<Employee> emps;
        //Database Connect Object
        DBConnect d1 = new DBConnect();
        //list of employee ids who have overtime(OT)/Paid Time Off(PTO) hours
        private List<string> empIds;
        //list of OT/PTO Hours 
        private List<double> hours;

        //====Constructors====

        public HR()
        {
            emps = new List<Employee>();
            empIds = new List<string>();
            hours = new List<double>();
        }

        public HR(string sid)
        {
            selectEmps();
        }

        //====Setters/Getters=====
        public List<Employee> getEmps() { return emps; }
        public List<string> getEmpIds() { return empIds; }
        public List<double> getHours() { return hours; }

        //====Behaviors====
        
        //populates emp list with employees selected from the EmpInfo table
        public void selectEmps()
        {
            d1.DBSetup();

            //select statement for populating emp list
            d1.cmd = "Select * from EmpInfo";
            d1.SqlDataAdapter.SelectCommand.CommandText = d1.cmd;
            d1.SqlDataAdapter.SelectCommand.Connection = d1.SqlDbConection2;
            try
            {
                d1.SqlDbConection2.Open();

                System.Data.SqlClient.SqlDataReader dr;
                dr = d1.SqlDataAdapter.SelectCommand.ExecuteReader();

                while (dr.Read())
                {
                    //create employee object from database
                    Employee e1 = new Employee(dr.GetValue(0).ToString(), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetValue(3).ToString(), dr.GetValue(4).ToString(), dr.GetValue(5).ToString(), dr.GetValue(6).ToString(), dr.GetValue(7).ToString(), Convert.ToBoolean(dr.GetValue(8)), Convert.ToBoolean(dr.GetValue(9)), Convert.ToBoolean(dr.GetValue(10)), dr.GetValue(11).ToString(), Convert.ToBoolean(dr.GetValue(12)));
                    //add employee object to emp list
                    getEmps().Add(e1);                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something happened: " + e);
            }
            finally
            {
                //close connection
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
                //selectHours for all employees
                tio.selectHours(emps[x].getId(), i, o);
                //if employee's hours are greater than 40 and not equal to zero, populate lists
                if (tio.getTotal() > 40 && tio.getTotal() != 0)
                {
                    //adds employee ids to empIds list
                    getEmpIds().Add(emps[x].getId());
                    //add total from TimeIO BO to hours list
                    getHours().Add(tio.getTotal());
                }
            }

            //Display results
            for (int x = 0; x < empIds.Count(); x++)
            {
                tio.selectHours(empIds[x], i, o);
                Employee e1 = new Employee();
                e1.selectEmp(empIds[x]);


                Console.WriteLine("Hours worked between " + i + " and " + o + " for Employee " + e1.getFName() + " " + e1.getLName());
                Console.WriteLine("Overtime Hours Worked: " + ((int)(hours[x]) - 40) + " Hours and " + ((hours[x] - (int)(hours[x])) * 60) + " minutes.");
                Console.WriteLine(hours[x] - (int)hours[x] + "");
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

        //Display function to show the list of employees in the Emps and EmpIds lists
        public void display()
        {
            Employee e1 = new Employee();

            //display all employees
            for (int x = 0; x < emps.Count(); x++)
            {
                Console.WriteLine("EMPLOYEE -- " + emps[x].getId());
            }
            
            //display all overtime employees
            for(int x = 0; x<empIds.Count(); x++)
            {
                Console.WriteLine("Overtime Employees -- " + empIds[x]);
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
