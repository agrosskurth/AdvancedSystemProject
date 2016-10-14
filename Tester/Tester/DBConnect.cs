﻿using System;
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

            SqlDbConection2.ConnectionString = "Data Source=ANDREW\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True";
            // Console.Out.WriteLine("Connection Established");
        }//end DBSetup()-

        public void DBSelect()
        {

        }

        public void DBInsert(String id, String fn, String ln, String str, String c, String sta, String z, String e, bool n, bool s, bool h, String sr, bool f)
        {
            try
            {
                SqlCommand stmt = new SqlCommand("INSERT INTO EmpInfo (EmpID, First_Name, Last_Name, Street, City, State_, Zipcode, EMail, NE, SR, HR, SRID, FullTime) VALUES (@EmpID, @First_Name, @Last_Name, @Street, @City, @State_, @Zipcode, @EMail, @NE, @SR, @HR, @SRID, @FullTime)");
                stmt.Parameters.AddWithValue("@EmpID", id);
                stmt.Parameters.AddWithValue("@First_Name", fn);
                stmt.Parameters.AddWithValue("@Last_Name", ln);
                stmt.Parameters.AddWithValue("@Street", str);
                stmt.Parameters.AddWithValue("@City", c);
                stmt.Parameters.AddWithValue("@State_", sta);
                stmt.Parameters.AddWithValue("@Zipcode", z);
                stmt.Parameters.AddWithValue("@EMail", e);
                stmt.Parameters.AddWithValue("@NE", n);
                stmt.Parameters.AddWithValue("@SR", s);
                stmt.Parameters.AddWithValue("@HR", h);
                stmt.Parameters.AddWithValue("@SRID", sr);
                stmt.Parameters.AddWithValue("@FullTime", f);
                SqlDbConection2.Open();
                stmt.Connection = SqlDbConection2;
                stmt.ExecuteNonQuery();
                Console.Out.WriteLine("It worked!");
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Something happened: " + ex);
            }
            finally
            {
                SqlDbConection2.Close();
            }
        }
    }
}