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

        //Correct UN/PW Button Click
        private void btnCorrect_Click(object sender, EventArgs e)
        {
            //instantiate Authentication 
            Authentication a1;
            a1 = new Authentication("900254455", "123456");
            //establish connection
            a1.SelectDB();
        }

        //Incorrect UN/PW Button Click
        private void btnIncorrect_Click(object sender, EventArgs e)
        {
            //instatiate Authentication Object
            Authentication a1;
            a1 = new Authentication("Wrong", "Also Wrong");
            //establish Connection
            a1.SelectDB();
        }
    }
}
