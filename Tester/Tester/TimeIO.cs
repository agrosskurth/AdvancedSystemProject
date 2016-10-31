using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Tester
{
    class TimeIO
    {
        //=============Properties===========//
        String id, reasonOut;
        DateTime clockIn;
        DateTime clockOut;
        private DBConnect d1 = new DBConnect();


        //=========Constructors============//
        public TimeIO()
        {
            id = "";
            clockIn = new DateTime(0, 0, 0, 0, 0, 0);
            clockOut = new DateTime(0, 0, 0, 0, 0, 0);
            reasonOut = "";
        }

        public TimeIO(String i, DateTime ci, DateTime co, String r)
        {
            setId(i);
            setClockIn(ci);
            setClockOut(co);
            setReasonOut(r);
        }

        //==========Behaviors===========//
        public void Display()
        {
            Console.WriteLine(getId());
            Console.WriteLine(getClockIn());
            Console.WriteLine(getClockOut());

        }

        public void setId(String i) { id = i; }
        public void setClockIn(DateTime ci) { clockIn = ci; }
        public void setClockOut(DateTime co) { clockOut = co; }
        public void setReasonOut(String r) { reasonOut = r; }

        public String getId() { return id; }
        public DateTime getClockIn() { return clockIn; }
        public DateTime getClockOut() { return clockOut; }
        public String getReasonOut() { return reasonOut; }

        //format date time 

        

        //==========DB-ACCESS===========//
        //The reason I made this method accept a string _id argument is to make sure that everytime that a new time pair is inserted it is
        //associated with an appropriate employee id. I'm not even sure if we need this, and there might be a different way to do this, 
        //but for now it will work.
        //-Kyle

        public void selectTime(string _id)
        {
            d1.DBSetup();
            d1.cmd = "SELECT * FROM EmpTime WHERE EmpID = " + "'" + _id + "'";
            d1.SqlDataAdapter.SelectCommand.Connection = d1.SqlDbConection2;
            d1.SqlDataAdapter.SelectCommand.CommandText = d1.cmd;

            try
            {
                Console.WriteLine("SQL:" + d1.cmd);
                d1.SqlDbConection2.Open();
                Console.WriteLine("Connection opened...");
                System.Data.SqlClient.SqlDataReader dr;
                dr = d1.SqlDataAdapter.SelectCommand.ExecuteReader();
                Console.WriteLine("Statement execute...reader returned...");

                while (dr.Read())
                {
                    Console.WriteLine("ID: " + dr.GetValue(0).ToString());
                    Console.WriteLine("DATE: " + dr.GetValue(1).ToString());
                    Console.WriteLine("IN: " + dr.GetValue(2).ToString());
                    Console.WriteLine("OUT: " + dr.GetValue(3).ToString());
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR: " + ex);
            }
            finally{
                d1.SqlDbConection2.Close();
            }
        }

        //Created By Rusty J. Hodge 10/31/2016
        //This method inserts a clock in/out with the associated ID and reason  
        public void insertTime()
        {
            //connect to database
            d1.DBSetup();
            try
            {
                //SQL Insert Statement
                d1.stmt = new SqlCommand("INSERT INTO EmpTime (EmpID, TimeIn, TimeOut, ReasonOut) VALUES (@EmpID, @TimeIn, @TimeOut, @ReasonOut)");
                d1.stmt.Parameters.AddWithValue("@EmpID", getId());
                d1.stmt.Parameters.AddWithValue("@TimeIn", getClockIn());
                d1.stmt.Parameters.AddWithValue("@TimeOut", getClockOut());
                d1.stmt.Parameters.AddWithValue("@ReasonOut", getReasonOut());
                d1.SqlDbConection2.Open();
                d1.stmt.Connection = d1.SqlDbConection2;
                
                //Execute Insert Command
                d1.stmt.ExecuteNonQuery();
                Console.Out.WriteLine("It worked!");
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Something happened: " + ex);
            }
            finally
            {
                d1.SqlDbConection2.Close();
            }

        }

        //Created by Rusty J. Hodge on 10/31/2016
        //Update a specific timein/out
        public void updateTime()
        {
            //Call DBSetup, establish connection
            d1.DBSetup();
            //SQL Update Statement
            d1.cmd = "Update EmpTime set TimeIn ='" + getClockIn() + "'," +
                "TimeOut ='" + getClockOut() + "'," +
                "ReasonOut ='" + getReasonOut() + "'" +
                " Where EmpID ='" + getId() + "'";
            d1.SqlDataAdapter.UpdateCommand.CommandText = d1.cmd;
            d1.SqlDataAdapter.UpdateCommand.Connection = d1.SqlDbConection2;
            //Confirm SQL statement
            Console.WriteLine(d1.cmd);
            try
            {
                //open connection
                d1.SqlDbConection2.Open();

                //try command
                int n = d1.SqlDataAdapter.UpdateCommand.ExecuteNonQuery();
                if (n == 1)
                {
                    Console.WriteLine("Data Updated");
                }
                else
                {
                    Console.WriteLine("ERROR: Updating Data");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                //Close Connection
                d1.SqlDbConection2.Close();
            }
        }
        //I just realized that updating the time might be tricky. How we will determine what needs to be updated? 
    }
}
