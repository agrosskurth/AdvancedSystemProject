using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Authentication
    {
        //+++properties++
        private String _employeeId;
        private String _employeePw;
        private String validateEmployeePw;
        //to confram correct username and password
        bool x = false;
        DBConnect d1 = new DBConnect();

        public Authentication()
        {
            _employeeId = "";
            _employeePw = "";
        }

        public Authentication(String emId, String emPw)
        {
            _employeeId = emId;
            _employeePw = emPw;
        }

        //++set++
        public void setEmployeeId(String emId) { _employeeId = emId; }
        public void setEmployeePw(String empw) { _employeePw = empw; }
        public void setValidateEmployeePw(String vpw) { validateEmployeePw = vpw; }
        //++gets++
        public String getEmployeeId() { return _employeeId; }
        public String getEmployeePw() { return _employeePw; }
        public String getValidateEmployeePw() { return validateEmployeePw; }


            //SelectDB Method for checking password to username. Changed by Rusty to incorporate DBConnect
            //on 10/19/2016
        public void SelectDB()
        {
            _employeeId = getEmployeeId();
            d1.DBSetup();
                
            //Console.WriteLine("After set up");

            d1.cmd = "Select * from EmpLog where EmpId ='" + getEmployeeId() + "'";
            d1.SqlDataAdapter.SelectCommand.CommandText = d1.cmd;
            d1.SqlDataAdapter.SelectCommand.Connection = d1.SqlDbConection2;
            //Console.WriteLine(cmd);
            //This part starts the connection and executes sql
            try
            {

                d1.SqlDbConection2.Open();
                //Console.Out.WriteLine("This Works");
                System.Data.SqlClient.SqlDataReader dr;
                //Console.Out.WriteLine("This Also Works");
                dr = d1.SqlDataAdapter.SelectCommand.ExecuteReader();
                //Console.Out.WriteLine("The SQL Statement works");

                //This tests if the sql statement can execute. If so, it validates the information.
                while (dr.Read())
                {
                    x = true;
                    Console.Out.WriteLine("Username is correct");
                    //If the given username matches one in the DB, validate the password.
                    if (dr.GetValue(1).Equals(getEmployeePw()))
                    {
                        Console.Out.WriteLine("Password is correct");
                    }
                    //If the above statement fails, print incorrect password.
                    else
                    {
                        Console.Out.WriteLine("Password is incorrect");
                    }
                }
                //If the sql is incorrect, the console prints incorrect username
                if (x == false)
                {
                    Console.WriteLine("Username is incorrect");
                }
            //General exception catch that will be expanded upon
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            //close the connection to the Database
            finally
            {
                d1.SqlDbConection2.Close();
            }
        }
    }
}//End Class
