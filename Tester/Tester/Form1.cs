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

        //Correct Button Click
        private void btnCorrect_Click(object sender, EventArgs e)
        {
            //instantiate Authentication 
            Authentication a1;
            a1 = new Authentication("900254455", "123456");
            a1.DBSetup();
            a1.SelectDB();
        }

        private void btnIncorrect_Click(object sender, EventArgs e)
        {
            //instatiate Authentication Object
            Authentication a1;
            a1 = new Authentication("Wrong", "Also Wrong");
            a1.DBSetup();
            a1.SelectDB();
        }
    }
}
