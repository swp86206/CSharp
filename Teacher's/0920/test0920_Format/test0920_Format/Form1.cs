using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0920_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 2001;
            // (10, 20)
            string result;
            result = "(" + x.ToString() + ", " + y.ToString() + ")";

            // result = string.Format("({0}, {1})", x, y);
            // result = string.Format("({0:D3}, {1:D3})", x, y);
            // result = string.Format("({0:N2}, {1:N2})", x, y);
            // result = string.Format("({0:N2}, Y={1:###,###.0})", x, y);
            result = string.Format("({0:N2}, Y={1:000,000.0})", x, y);

            button1.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Int32 x = 150000;
            string result;
            result = string.Format("{0}", x);
            // result = string.Format("{0:C}", x);
            result = string.Format(CultureInfo.GetCultureInfo("en-US"),
                "{0:C2}", x);
            button2.Text = result;
        }
    }
}
