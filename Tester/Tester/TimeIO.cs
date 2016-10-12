using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class TimeIO
    {
        //=============Properties===========//
        String id;
        DateTime clockIn;
        DateTime clockOut;

        //=========Constructors============//
        public TimeIO()
        {
            id = "";
            clockIn = new DateTime(0, 0, 0, 0, 0, 0);
            clockOut = new DateTime(0, 0, 0, 0, 0, 0);
        }

        public TimeIO(String i, DateTime ci, DateTime co)
        {
            setId(i);
            setClockIn(ci);
            setClockOut(co);
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

        public String getId() { return id; }
        public DateTime getClockIn() { return clockIn; }
        public DateTime getClockOut() { return clockOut; }

        //==========DB-ACCESS===========//
        //The reason I made this method accept a string _id argument is to make sure that everytime that a new time pair is inserted it is
        //associated with an appropriate employee id. I'm not even sure if we need this, and there might be a different way to do this, 
        //but for now it will work.
        //-Kyle
        public void insertTime(string _id)
        {

        }
        //I just realized that updating the time might be tricky. How we will determine what needs to be updated? 
    }
}
