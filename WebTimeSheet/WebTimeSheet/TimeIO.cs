﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WebTimeSheet
{
    class TimeIO
    {
        //=============Properties===========//
        String id, reasonOut;
        DateTime clockIn;
        DateTime clockOut;
        private DBConnect d1 = new DBConnect();
        private int entId;
        bool editable, absence;
        DateTime worked = new DateTime(1990, 1, 1, 0, 0, 0);
        double total = 0;


        //=========Constructors============//
        public TimeIO()
        {
            id = "";
            clockIn = new DateTime(1990, 1, 1, 0, 0, 0);
            clockOut = new DateTime(1990, 1, 1, 0, 0, 0);
            reasonOut = "";
            entId = 00;
            editable = false;
            absence = false;
        }

        public TimeIO(String i, DateTime ci, DateTime co, String r, int e, bool ed, bool a)
        {
            setId(i);
            setClockIn(ci);
            setClockOut(co);
            setReasonOut(r);
            setEntId(e);
            setEditable(ed);
            setAbsence(a);
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
        public void setEntId(int e) { entId = e; }
        public void setEditable(bool ed) { editable = ed; }
        public void setWorked(DateTime w) { worked = w; }
        public void setTotal(double t) { total = t; }
        public void setAbsence(bool a) { absence = a; }

        public String getId() { return id; }
        public DateTime getClockIn() { return clockIn; }
        public DateTime getClockOut() { return clockOut; }
        public String getReasonOut() { return reasonOut; }
        public int getEntId() { return entId; }
        public bool getEditable() { return editable; }
        public DateTime getWorked() { return worked; }
        public double getTotal() { return total; }
        public bool getAbsence() { return absence; }

        //format date time 

        

        //==========DB-ACCESS===========//
        //The reason I made this method accept a string _id argument is to make sure that everytime that a new time pair is inserted it is
        //associated with an appropriate employee id. I'm not even sure if we need this, and there might be a different way to do this, 
        //but for now it will work.
        //-Kyle

        //Select Method for retrieving data from EmpTime table based on EmpID
        public void selectTime(string _id)
        {
            //establish connection to DB
            d1.DBSetup();

            //SQL code for selecting all from EmpTime table based on EmpId provided
            d1.cmd = "SELECT * FROM EmpTime WHERE EmpID = " + "'" + _id + "'" + "and Absence = 'false'";
            d1.SqlDataAdapter.SelectCommand.Connection = d1.SqlDbConection2;
            d1.SqlDataAdapter.SelectCommand.CommandText = d1.cmd;

            try
            {
                //console write sql code
                Console.WriteLine("SQL:" + d1.cmd);
                d1.SqlDbConection2.Open();

                //confirm connection worked
                Console.WriteLine("Connection opened...");
                System.Data.SqlClient.SqlDataReader dr;
                dr = d1.SqlDataAdapter.SelectCommand.ExecuteReader();
                Console.WriteLine("Statement execute...reader returned...");

                //while data reader is pulling out data, fill in values
                while (dr.Read())
                {
                    //Setter values for timeIO
                    setEntId(Convert.ToInt32(dr.GetValue(0)));
                    setId(dr.GetValue(1).ToString());
                    setClockIn(Convert.ToDateTime(dr.GetValue(2)));
                    setClockOut(Convert.ToDateTime(dr.GetValue(3)));
                    setEditable(Convert.ToBoolean(dr.GetValue(5)));
                    setReasonOut(Convert.ToString(dr.GetValue(4)));
                    setWorked(Convert.ToDateTime(dr.GetValue(6)));
                    setAbsence(Convert.ToBoolean(dr.GetValue(7)));

                    //Console WriteLine to confirm values are correct
                    Console.WriteLine("EntryID: " + dr.GetValue(0).ToString());
                    Console.WriteLine("EmpID: " + dr.GetValue(1).ToString());
                    Console.WriteLine("IN: " + dr.GetValue(2).ToString());
                    Console.WriteLine("OUT: " + dr.GetValue(3).ToString());
                    Console.WriteLine("Reason: " + getReasonOut());
                    Console.WriteLine("Editable: " + dr.GetValue(5));
                    Console.WriteLine("Span: " + dr.GetValue(6));
                    Console.WriteLine("Absence: " + dr.GetValue(7));
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
                d1.stmt = new SqlCommand("INSERT INTO EmpTime (EmpID, TimeIn, TimeOut, ReasonOut, Editable, Absence) VALUES (@EmpID, @TimeIn, @TimeOut, @ReasonOut, @Editable, @Absence)");
                d1.stmt.Parameters.AddWithValue("@EmpID", getId());
                d1.stmt.Parameters.AddWithValue("@TimeIn", getClockIn());
                d1.stmt.Parameters.AddWithValue("@TimeOut", getClockOut());
                d1.stmt.Parameters.AddWithValue("@ReasonOut", getReasonOut());
                d1.stmt.Parameters.AddWithValue(@"Editable", getEditable());
                d1.stmt.Parameters.AddWithValue(@"Absence", getAbsence());
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
                "ReasonOut ='" + getReasonOut() + "'," +
                "Editable = " + getEditable() +
                "Absence = " + getAbsence() +
                " Where EntryID ='" + getEntId() + "'";
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

        //Created By Rusty J. Hodge on 10/31/2016
        //DeleteTime Method for removing specific entries in the EmpTime table
        public void deleteTime()
        {
            //Establish Connection
            d1.DBSetup();

            //SQL Delete Statement
            d1.cmd = "Delete from EmpTime Where EntryID = " + getEntId();
            d1.SqlDataAdapter.DeleteCommand.CommandText = d1.cmd;
            d1.SqlDataAdapter.DeleteCommand.Connection = d1.SqlDbConection2;
            Console.WriteLine(d1.cmd);
            try
            {
                d1.SqlDbConection2.Open();

                //Execute Delete Command
                int n = d1.SqlDataAdapter.DeleteCommand.ExecuteNonQuery();
                if (n == 1)
                {
                    Console.WriteLine("Data Deleted");
                }
                else
                {
                    Console.WriteLine("ERROR: Deleting Data");
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

        //Method for Selecting hours worked between two given DateTimes.
        //Selects TimeWorked from EmpTime table between 2 provided DateTimes(ti for timeIn, to for time Out), 
        //sets double Total to figure out hours worked in that time frame.
        public void selectHours(string _id, DateTime ti, DateTime to)
        {
            //sets total hours for week to 0
            setTotal(0);
            //instantiate hours and minutes doubles for determining total time worked
            double hours = 0;
            double minutes = 0;
            //Connect to DB
            d1.DBSetup();
            d1.cmd = "SELECT TimeWorked FROM EmpTime WHERE EmpID = " + "'" + _id + "' And TimeIn >= '" + ti + "' and TimeOut <= '" + to + "' AND absence = 'false'";
            d1.SqlDataAdapter.SelectCommand.Connection = d1.SqlDbConection2;
            d1.SqlDataAdapter.SelectCommand.CommandText = d1.cmd;

            try
            {
                //run sql statement
                Console.WriteLine("SQL:" + d1.cmd);
                d1.SqlDbConection2.Open();
                Console.WriteLine("Connection opened...");
                System.Data.SqlClient.SqlDataReader dr;
                dr = d1.SqlDataAdapter.SelectCommand.ExecuteReader();
                Console.WriteLine("Statement execute...reader returned...");

                //while the data reader continues to grab elements from DB, it resets the TimeWorked field,
                //and sums up the total hours worked for the week.
                while (dr.Read())
                {
                    setWorked(Convert.ToDateTime(dr.GetValue(0)));
                    hours = Convert.ToDouble(getWorked().Hour);
                    minutes = Convert.ToDouble(getWorked().Minute);
                    minutes = minutes / 60;
                    setTotal(getTotal() + hours + minutes);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex);
            }
            finally
            {
                d1.SqlDbConection2.Close();
            }
        }
        
        //Method for Selecting hours requested off between two given DateTimes.
        //Selects TimeWorked from EmpTime table between 2 provided DateTimes(ti for timeIn, to for time Out), 
        //sets double Total to figure out hours worked in that time frame.
        //Unlike the last method, this one only selects rows where absence = true
        public void selectAbsence(string _id, DateTime ti, DateTime to)
        {
            //sets total hours for week to 0
            setTotal(0);
            //instantiate hours and minutes doubles for determining total time worked
            double hours = 0;
            double minutes = 0;
            //Connect to DB
            d1.DBSetup();
            d1.cmd = "SELECT TimeWorked FROM EmpTime WHERE EmpID = " + "'" + _id + "' And TimeIn >= '" + ti + "' and TimeOut <= '" + to + "' AND absence = 'true'";
            d1.SqlDataAdapter.SelectCommand.Connection = d1.SqlDbConection2;
            d1.SqlDataAdapter.SelectCommand.CommandText = d1.cmd;

            try
            {
                //run sql statement
                Console.WriteLine("SQL:" + d1.cmd);
                d1.SqlDbConection2.Open();
                Console.WriteLine("Connection opened...");
                System.Data.SqlClient.SqlDataReader dr;
                dr = d1.SqlDataAdapter.SelectCommand.ExecuteReader();
                Console.WriteLine("Statement execute...reader returned...");

                //while the data reader continues to grab elements from DB, it resets the TimeWorked field,
                //and sums up the total hours worked for the week.
                while (dr.Read())
                {
                    setWorked(Convert.ToDateTime(dr.GetValue(0)));
                    hours = Convert.ToDouble(getWorked().Hour);
                    minutes = Convert.ToDouble(getWorked().Minute);
                    minutes = minutes / 60;
                    setTotal(getTotal() + hours + minutes);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex);
            }
            finally
            {
                d1.SqlDbConection2.Close();
            }
        }

        //I just realized that updating the time might be tricky. How we will determine what needs to be updated? 
    }
}
