using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0920_nullableVariables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // int x;
            // int y = null;
            int? x = null;

            button1.Text = "*" + Convert.ToString(x) + "*";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? x = null;

            button2.Text = "*" + x.ToString();
        }
    }
}
