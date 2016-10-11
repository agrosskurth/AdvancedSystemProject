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
        bool _userName = false;
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

        public System.Data.OleDb.OleDbDataAdapter SqlDataAdapter;
        public System.Data.OleDb.OleDbCommand SqlDbSelectCommand2;
        public System.Data.OleDb.OleDbCommand SqlDbInsertCommand2;
        public System.Data.OleDb.OleDbCommand SqlDbUpdateCommand2;
        public System.Data.OleDb.OleDbCommand SqlDbDeleteCommand2;
        public System.Data.OleDb.OleDbConnection SqlDbConection2;
        public string cmd;

        //++++++++++++++++Setup Function

        public void DBSetup()
        {
            SqlDataAdapter = new System.Data.OleDb.OleDbDataAdapter();
            SqlDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            SqlDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            SqlDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            SqlDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            SqlDbConection2 = new System.Data.OleDb.OleDbConnection();

            SqlDataAdapter.SelectCommand = SqlDbSelectCommand2;
            SqlDataAdapter.InsertCommand = SqlDbInsertCommand2;
            SqlDataAdapter.UpdateCommand = SqlDbUpdateCommand2;
            SqlDataAdapter.DeleteCommand = SqlDbDeleteCommand2;

            SqlDbConection2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Program Files\\Microsoft SQL Server\\MSSQL11.SQLEXPRESS\\MSSQL\\DATA\\EmployeeDB.mdf";

        }//end DBSetup()

        public void SelectDB()
        {
            _employeeId = getEmployeeId();
            DBSetup();
            Console.WriteLine("After set up");

            cmd = "Select* from EmpLog where EmpId ='" + getEmployeeId() + "'";
            SqlDataAdapter.SelectCommand.CommandText = cmd;
            SqlDataAdapter.SelectCommand.Connection = SqlDbConection2;
            Console.WriteLine(cmd);
            try
            {

                SqlDbConection2.Open();
                System.Data.OleDb.OleDbDataReader dr;
                dr = SqlDataAdapter.SelectCommand.ExecuteReader();

                dr.Read();

                 if (!dr.GetValue(1).Equals(null))
                {
                    setValidateEmployeePw(dr.GetValue(1) + "");
                    Console.Out.WriteLine("Pw= " + validateEmployeePw);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);

            }
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
