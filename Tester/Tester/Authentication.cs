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
        private String validateEmployeeId;
        private String validateEmployeePw;
        //to confram correct username and password
        bool x = false;
        bool _password = false;

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
        //++++++++++++++DataBase Element 

        public System.Data.SqlClient.SqlDataAdapter SqlDataAdapter;
        public System.Data.SqlClient.SqlCommand SqlDbSelectCommand2;
        public System.Data.SqlClient.SqlCommand SqlDbInsertCommand2;
        public System.Data.SqlClient.SqlCommand SqlDbUpdateCommand2;
        public System.Data.SqlClient.SqlCommand SqlDbDeleteCommand2;
        public System.Data.SqlClient.SqlConnection SqlDbConection2;
        public string cmd;

        //++++++++++++++++Setup Function

        public void DBSetup()
        {
            SqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter();
            SqlDbSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            SqlDbInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            SqlDbUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            SqlDbDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            SqlDbConection2 = new System.Data.SqlClient.SqlConnection();

            SqlDataAdapter.SelectCommand = SqlDbSelectCommand2;
            SqlDataAdapter.InsertCommand = SqlDbInsertCommand2;
            SqlDataAdapter.UpdateCommand = SqlDbUpdateCommand2;
            SqlDataAdapter.DeleteCommand = SqlDbDeleteCommand2;
            //Variable and Switch Case made by Boyle
            string compName = Environment.MachineName;
            switch (compName)
            {
                case "CLEOPATRA":
                    //Andrew Boyle's Computer
                    SqlDbConection2.ConnectionString = "Data Source=CLEOPATRA;Initial Catalog=EmployeeDB;Integrated Security=True";
                    break;
                case "MORNINGSTAR":
                    //Rusty's Computer
                    SqlDbConection2.ConnectionString = "Data Source=MORNINGSTAR;Initial Catalog=employeeDB;Integrated Security=True;";
                    break;
                case "DESKTOP-RCIQMS7":
                    //Osi's Computer
                    SqlDbConection2.ConnectionString = "Data Source=DESKTOP-RCIQMS7;Initial Catalog=EmployeeDB;Integrated Security=True";
                    break;
                case "ANDREW\\SQLEXPRESS":
                    //Andrew Grosskurth's Computer
                    SqlDbConection2.ConnectionString = "Data Source=ANDREW\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True";
                    break;
                case "KYLE-TOSHIBA\\SQLEXPRESS":
                    //Kyle's Computer
                    SqlDbConection2.ConnectionString = "Data Source=KYLE-TOSHIBA\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                    break;
                default:
                    Console.WriteLine("No computer found");
                    break;
            }

            //Code Below is the old code. If this works for all 5 computers this can be deleted -Boyle
            //RUSTY-- SqlDbConection2.ConnectionString = "Data Source=MORNINGSTAR;Initial Catalog=employeeDB;Integrated Security=True;";
            //SqlDbConection2.ConnectionString = "Data Source=DESKTOP-RCIQMS7;Initial Catalog=EmployeeDB;Integrated Security=True";
            //SqlDbConection2.ConnectionString = "Data Source=ANDREW\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True";
            // Console.Out.WriteLine("Connection Established");
        }//end DBSetup()-

        public void SelectDB()
        {
            _employeeId = getEmployeeId();
            DBSetup();
                
            //Console.WriteLine("After set up");

            cmd = "Select* from EmpLog where EmpId ='" + getEmployeeId() + "'";
            SqlDataAdapter.SelectCommand.CommandText = cmd;
            SqlDataAdapter.SelectCommand.Connection = SqlDbConection2;
            //Console.WriteLine(cmd);
            //This part starts the connection and executes sql
            try
            {

                SqlDbConection2.Open();
                //Console.Out.WriteLine("This Works");
                System.Data.SqlClient.SqlDataReader dr;
                //Console.Out.WriteLine("This Also Works");
                dr = SqlDataAdapter.SelectCommand.ExecuteReader();
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
                SqlDbConection2.Close();
            }

        }//End SelectDB()
        /*
                    public void InsertDB(string cii, string cnn, string cdd, int chh)
                    {
                        _courseId = cii;
                        _courseName = cnn;
                        _courseDesc = cdd;
                        _creditHours = chh;

                        DBSetup();
                        Console.WriteLine("After set up two");

                        cmd = "Insert into courses values('" + cii + "','"
                            + cnn + "','"
                            + cdd + "',"
                            + chh + ")";

                        OleDbDataAdapter2.InsertCommand.CommandText = cmd;
                        OleDbDataAdapter2.InsertCommand.Connection = OleDbConection2;
                        Console.WriteLine(cmd);
                        try
                        {

                            OleDbConection2.Open();
                            int n = OleDbDataAdapter2.InsertCommand.ExecuteNonQuery();
                            if (n == 1)
                            {
                                Console.WriteLine("Data Inserted");
                            }
                            else {
                                Console.WriteLine("Error: Inserting Data");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        finally
                        {
                            OleDbConection2.Close();
                        }


                    }//end InsertDB

                    public void UpdateDB()
                    {

                        cmd = "Update courses set courseName ='" + _courseName + "',"
                             + "Description ='" + _courseDesc + "',"
                             + "creditHours = " + _creditHours +
                             " where courseId = '" + _courseId + "'";

                        OleDbDataAdapter2.UpdateCommand.CommandText = cmd;
                        OleDbDataAdapter2.UpdateCommand.Connection = OleDbConection2;
                        Console.WriteLine(cmd);
                        try
                        {

                            OleDbConection2.Open();
                            int n = OleDbDataAdapter2.UpdateCommand.ExecuteNonQuery();
                            if (n == 1)
                            {
                                Console.WriteLine("Data Updateed");
                            }
                            else {
                                Console.WriteLine("Error: In Updateing Data");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        finally
                        {
                            OleDbConection2.Close();
                        }


                    }//end UpdateDB

                    public void DeleteDB()
                    {


                        cmd = "Delete from courses where courseId='" + getCourseId() + "'";


                        OleDbDataAdapter2.DeleteCommand.CommandText = cmd;
                        OleDbDataAdapter2.DeleteCommand.Connection = OleDbConection2;
                        Console.WriteLine(cmd);
                        try
                        {

                            OleDbConection2.Open();
                            int n = OleDbDataAdapter2.DeleteCommand.ExecuteNonQuery();
                            if (n == 1)
                            {
                                Console.WriteLine("Data Delete");
                            }
                            else {
                                Console.WriteLine("Error: In Deleteing Data");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                        finally
                        {
                            OleDbConection2.Close();
                        }


                    }//end DeleteDB 

               */

    }
}//End Class
