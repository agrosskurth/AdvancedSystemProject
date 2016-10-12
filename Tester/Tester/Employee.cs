﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Employee
    {
        //==========Properties===========//
        bool SR, HR, NE;
        String id, fName, lName, street, city, state, zip, email, SRID;
        DBConnect d1 = new DBConnect();

        public Employee()
        {
            d1.DBSetup();
            SR = false;
            HR = false;
            NE = false;
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

        public Employee(bool s, bool h, bool n, String i, String fn, String ln, String str, String c, String sta, String z, String e, String sid)
        {
            setSR(s);
            setHR(h);
            setNE(n);
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

        public void Display()
        {
            Console.WriteLine(getSR());
            Console.WriteLine(getHR());
            Console.WriteLine(getNE());
            Console.WriteLine(getId());
        }

        public void setSR(bool s) { SR = s; }
        public void setHR(bool h) { HR = h; }
        public void setNE(bool n) { NE = n; }
        public void setId(String i) { id = i; }
        public void setFName(String fn) { fName = fn; }
        public void setLName(String ln) { lName = ln; }
        public void setStreet(String str) { street = str; }
        public void setCity(String c) { city = c; }
        public void setState(String sta) { state = sta; }
        public void setZip(String z) { zip = z; }
        public void setEmail(String e) { email = e; }
        public void setSRID(String sid) { SRID = sid; }

        public bool getSR() { return SR; }
        public bool getHR() { return HR; }
        public bool getNE() { return NE; }
        public String getId() { return id; }
        public String getFName() { return fName; }
        public String getLame() { return lName; }
        public String getStreet() { return street; }
        public String getCity() { return city; }
        public String getState() { return state; }
        public String getZip() { return zip; }
        public String getEmail() { return email; }
        public String getSRID() { return SRID; }

    }
}
