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
    }
}
