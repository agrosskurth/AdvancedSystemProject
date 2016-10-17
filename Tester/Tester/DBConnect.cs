using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Tester
{
    class DBConnect
    {        
        //++++++++++++++DataBase Element 
        public System.Data.SqlClient.SqlDataAdapter SqlDataAdapter;
        public System.Data.SqlClient.SqlCommand SqlDbSelectCommand2;
        public System.Data.SqlClient.SqlCommand SqlDbInsertCommand2;
        public System.Data.SqlClient.SqlCommand SqlDbUpdateCommand2;
        public System.Data.SqlClient.SqlCommand SqlDbDeleteCommand2;
        public System.Data.SqlClient.SqlConnection SqlDbConection2;
        public string cmd;
        public SqlCommand stmt;

        //++++++++++++++++++++Setup Function
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

            //RUSTY-- SqlDbConection2.ConnectionString = "Data Source=MORNINGSTAR;Initial Catalog=employeeDB;Integrated Security=True;";
            //SqlDbConection2.ConnectionString = "Data Source=DESKTOP-RCIQMS7;Initial Catalog=EmployeeDB;Integrated Security=True";
            SqlDbConection2.ConnectionString = "Data Source=ANDREW\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True";
            // Console.Out.WriteLine("Connection Established");
        }//end DBSetup()
    }//End Class
}
