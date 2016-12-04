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
            t1 = new TimeIO("900254666", new DateTime(2011, 2, 5, 4, 56, 00), new DateTime(2011, 2, 5, 6, 56, 00), "Doctor", 123, false, false);
            t1.Display();
            t1.insertTime();
            t1.selectTime("900254666");
        }

        //======TimeSheet Test=====//
        private void BtnTimeSheet_Click(object sender, EventArgs e)
        {
            TimeSheet ts1 = new TimeSheet();
            ts1.timeSheetSelect("900255666");
            ts1.display();

        }

        //====
        private void btnInsertTime_Click(object sender, EventArgs e)
        {
            TimeIO t1;
            t1 = new TimeIO("900254666", new DateTime(2011, 2, 1, 2, 56, 00), new DateTime(2011, 2, 3, 3, 56, 00), "Lunch", 000, false, false);
            t1.insertTime();
            t1.Display();
        }

        private void btnUpEmp_Click(object sender, EventArgs e)
        {
            Employee e2;
            e2 = new Employee("900254666", "Ryu", "Hoshi", "Hadoken!", "Shryuken!", "Jp", "22882", "Street.Fighter@cap.com", true, true, false, "900123123", false);
            e2.updateEmp();
        }

        private void btnDelTimeIO_Click(object sender, EventArgs e)
        {
            TimeIO t1;
            t1 = new TimeIO("900254666", new DateTime(2011, 2, 1, 2, 56, 00), new DateTime(2011, 2, 3, 3, 56, 00), "Lunch", 23, true, false);
            t1.deleteTime();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpTimeIO_Click(object sender, EventArgs e)
        {
            TimeIO t1;
            t1 = new TimeIO("900254666", new DateTime(2011, 2, 1, 2, 56, 00), new DateTime(2011, 2, 3, 3, 56, 00), "Lunch", 9, false, false);
            t1.updateTime();
        }

        private void buttonSpan_Click(object sender, EventArgs e)
        {
            TimeIO t1;
            t1 = new TimeIO();
            t1.selectHours("900255666", new DateTime(2014, 5, 5, 0, 0, 0), new DateTime(2014, 5, 9, 23, 59, 59));
            Console.WriteLine(t1.getTotal());
        }

        private void buttonSR_Click(object sender, EventArgs e)
        {
            Supervisor s1 = new Supervisor();
            s1.selectEmps("900254456");
            s1.display();
        }

        private void buttonOT_Click(object sender, EventArgs e)
        {
            Supervisor s1 = new Supervisor();
            s1.selectEmps("900254456");
            s1.selectOvertime(new DateTime(2014, 5, 5, 0, 0, 0), new DateTime(2014, 5, 9, 23, 59, 59));
            s1.display();
        }

        private void buttonHROT_Click(object sender, EventArgs e)
        {
            HR h1 = new HR();
            h1.selectEmps();
            h1.selectOvertime(new DateTime(2014, 5, 5, 0, 0, 0), new DateTime(2014, 5, 9, 23, 59, 59));
            h1.display();
        }
    }//End Class
}
