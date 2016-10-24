using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //===Correct Button Click===//
        private void btnCorrect_Click(object sender, EventArgs e)
        {
            //instantiate Authentication 
            Authentication a1;
            DBConnect d1 = new DBConnect();
            a1 = new Authentication("900254455", "123456");
            d1.DBSetup();
            a1.SelectDB();
        }
        //==Inccorect Button Click==//
        private void btnIncorrect_Click(object sender, EventArgs e)
        {
            //instatiate Authentication Object
            Authentication a1;
            a1 = new Authentication("Wrong", "Also Wrong");
            DBConnect d1;
            d1 = new DBConnect();
            d1.DBSetup();
            a1.SelectDB();
        }
        //=======Em-Select==========//
        private void btnSelectEmployee_Click(object sender, EventArgs e)
        {
            Employee e1;
            e1 = new Employee();
            e1.selectEmp("900254455");
            e1.Display();
        }
        //=======Em-Insert==========//
        private void btnInsertEmployee_Click_1(object sender, EventArgs e)
        {
            Employee e1;
            e1 = new Employee("900254666", "Felipe", "Gava", "123 Here St", "Nowhere", "MX", "12321", "Gava.Juice@hotmail.com", false, false, false, "900254455", true);
            e1.insertEmp();           
            e1.Display();
        }

        //===========Time==========//
        private void btnTime_Click(object sender, EventArgs e)
        {
            TimeIO t1;
            //DateTime ci;
            //ci = new DateTime(2011, 2, 1, 2, 56, 00);
            //DateTime co;
            //co = new DateTime(2011, 2, 3, 3, 56, 00);
            //t1 = new TimeIO("900254555", ci, co);
            //t1.Display();

            t1 = new TimeIO();
            t1.selectTime("900254455");
        }

        //======TimeSheet Test=====//
        private void BtnTimeSheet_Click(object sender, EventArgs e)
        {
            Timesheet ts1 = new Timesheet();
            ts1.addTimeIO(new TimeIO("900254455", new DateTime(2016, 10, 24, 8, 00, 00), new DateTime(2016, 10, 24, 1, 24, 00)));
            ts1.addTimeIO(new TimeIO("900254455", new DateTime(2016, 10, 24, 1, 55, 00), new DateTime(2016, 10, 24, 5, 24, 00)));
            ts1.addTimeIO(new TimeIO("900254455", new DateTime(2016, 10, 25, 8, 20, 00), new DateTime(2016, 10, 25, 3, 00, 00)));

            ts1.display();

        }

        private void btnInsertTime_Click(object sender, EventArgs e)
        {
            TimeIO t1;
            t1.insertTime = new TimeIO("900254555", new DateTime(2011, 2, 1, 2, 56, 00), new DateTime(2011, 2, 3, 3, 56, 00));
            t1.Display();
        }
    }//End Class
}
