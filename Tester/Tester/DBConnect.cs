using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class DBConnect
    {
        public DBConnect()
        {

        }
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

            SqlDbConection2.ConnectionString = "Integrated Security = SSPI; Initial Catalog = EmployeeDB; Data Source = RUSTY\\SQLEXPRESS;";
            // Console.Out.WriteLine("Connection Established");
        }//end DBSetup()-
    }
}
