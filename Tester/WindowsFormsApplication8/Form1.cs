using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void correctBtn_Click(object sender, EventArgs e)
        {
            Authentication a1;
            a1 = new Authentication("01241232","abcdef12");
            a1.display();
        }

        private void incorrectBtn_Click(object sender, EventArgs e)
        {
            Authentication a1;
            a1 = new Authentication("01241232", "abcdef12");
            a1.display();
        }
    }
}
