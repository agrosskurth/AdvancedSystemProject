using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Tester
{
    class Employee
    {
        //==========Properties===========//
        private bool SR, HR, NE, FuTime;
        private String id, fName, lName, street, city, state, zip, email, SRID;
        DBConnect d1 = new DBConnect();
        

        //==========Constructors===========//
        public Employee()
        { 
            SR = false;
            HR = false;
            NE = false;
            FuTime = false;
            id = "";
            fName = "";
            lName = "";
            street = "";
            city = "";
            state = "";
            zip = "";
            email = "";
            SRID = "";
            
        }

        public Employee(String i, String fn, String ln, String str, String c, String sta, String z, String e, bool s, bool h, bool n, String sid, bool f)
        {
            setSR(s);
            setHR(h);
            setNE(n);
            setFuTime(f);
            setId(i);
            setFName(fn);
            setLName(ln);
            setStreet(str);
            setCity(c);
            setState(sta);
            setZip(z);
            setEmail(e);
            setSRID(sid);
        }

        //==========Properties===========//     
        public void setSR(bool s) { SR = s; }
        public void setHR(bool h) { HR = h; }
        public void setNE(bool n) { NE = n; }
        public void setFuTime(bool f) { FuTime = f; }
        //----------------------------------------------
        public void setId(String i) { id = i; }
        public void setFName(String fn) { fName = fn; }
        public void setLName(String ln) { lName = ln; }
        public void setStreet(String str) { street = str; }
        public void setCity(String c) { city = c; }
        public void setState(String sta) { state = sta; }
        public void setZip(String z) { zip = z; }
        public void setEmail(String e) { email = e; }
        public void setSRID(String sid) { SRID = sid; }
        //--------------------------------------------------
        public bool getSR() { return SR; }
        public bool getHR() { return HR; }
        public bool getNE() { return NE; }
        public bool getFuTime() { return FuTime; }
        //-----------------------------------------------
        public String getId() { return id; }
        public String getFName() { return fName; }
        public String getLName() { return lName; }
        public String getStreet() { return street; }
        public String getCity() { return city; }
        public String getState() { return state; }
        public String getZip() { return zip; }
        public String getEmail() { return email; }
        public String getSRID() { return SRID; }

        //---------------------Display
        public void Display()
        {
            Console.WriteLine(getFName());
            Console.WriteLine(getLName());
            Console.WriteLine(getStreet());
            Console.WriteLine(getCity());
            Console.WriteLine(getState());
            Console.WriteLine(getZip());
            Console.WriteLine(getEmail());
            Console.WriteLine(getNE());
            Console.WriteLine(getSR());
            Console.WriteLine(getHR());
            Console.WriteLine(getSRID());
            Console.WriteLine(getFuTime());
        }

        //-------SelectEmp
        public void selectEmp(string id)
        {
            d1.DBSetup();

            Console.WriteLine("After set up");

            //This part starts the connection and executes sql
            d1.cmd = "Select* from EmpInfo where EmpId ='" + id + "'";
            d1.SqlDataAdapter.SelectCommand.CommandText = d1.cmd;
            d1.SqlDataAdapter.SelectCommand.Connection = d1.SqlDbConection2;
            Console.WriteLine(d1.cmd);

            try
            {

                d1.SqlDbConection2.Open();
                System.Data.SqlClient.SqlDataReader dr;
                dr = d1.SqlDataAdapter.SelectCommand.ExecuteReader();

                dr.Read();

                setFName(dr.GetValue(1) + "");
                setLName(dr.GetValue(2) + "");
                setStreet(dr.GetValue(3) + "");
                setCity(dr.GetValue(4) + "");
                setState(dr.GetValue(5) + "");
                setZip(dr.GetValue(6) + "");
                setEmail(dr.GetValue(7) + "");
                setNE(Convert.ToBoolean(dr.GetValue(8)));
                setSR(Convert.ToBoolean(dr.GetValue(9)));
                setHR(Convert.ToBoolean(dr.GetValue(10)));
                setSRID(dr.GetValue(11) + "");
                setFuTime(Convert.ToBoolean(dr.GetValue(12)));

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

        }//end selectEmp

        //--------InsertEmp
        public void insertEmp()
        {
            d1.DBSetup();

            try
            {
                d1.stmt = new SqlCommand("INSERT INTO EmpInfo (EmpID, First_Name, Last_Name, Street, City, State_, Zipcode, EMail, NE, SR, HR, SRID, FullTime) VALUES (@EmpID, @First_Name, @Last_Name, @Street, @City, @State_, @Zipcode, @EMail, @NE, @SR, @HR, @SRID, @FullTime)");
                d1.stmt.Parameters.AddWithValue("@EmpID", getId());
                d1.stmt.Parameters.AddWithValue("@First_Name", getFName());
                d1.stmt.Parameters.AddWithValue("@Last_Name", getLName());
                d1.stmt.Parameters.AddWithValue("@Street", getStreet());
                d1.stmt.Parameters.AddWithValue("@City", getCity());
                d1.stmt.Parameters.AddWithValue("@State_", getState());
                d1.stmt.Parameters.AddWithValue("@Zipcode", getZip());
                d1.stmt.Parameters.AddWithValue("@EMail", getEmail());
                d1.stmt.Parameters.AddWithValue("@NE", getNE());
                d1.stmt.Parameters.AddWithValue("@SR", getSR());
                d1.stmt.Parameters.AddWithValue("@HR", getHR());
                d1.stmt.Parameters.AddWithValue("@SRID", getSRID());
                d1.stmt.Parameters.AddWithValue("@FullTime", getFuTime());
                d1.SqlDbConection2.Open();
                d1.stmt.Connection = d1.SqlDbConection2;
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

        //---------UpdateEmp-----------
        //Created by Rusty J. Hodge 10/31/2016
        public void updateEmp()
        {
            //Call DBSetup, establish connection
            d1.DBSetup();
            //SQL Update Statement
            d1.cmd = "Update EmpInfo set First_Name ='" + getFName() + "'," +
                "Last_Name ='" + getLName() + "'," +
                "Street ='" + getStreet() + "'," +
                "City ='" + getCity() + "'," +
                "State_ ='" + getState() + "'," +
                "ZipCode ='" + getZip() + "'," +
                "Email ='" + getEmail() + "'," +
                "NE ='" + getNE() + "'," +
                "SR ='" + getSR() + "'," +
                "HR ='" + getHR() + "'," +
                "SRID = '" + getSRID() + "'," +
                "FullTime ='" + getFuTime() + "'" +
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
        //---------DeleteEmp
        public void deleteEmp()
        {

        }
    }//End Class
}
