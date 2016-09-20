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

namespace _0920_PM2
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 150000;
            string result;
            result = string.Format("{0}", x); // "{0}"  x中編號0的數值
            // result = string.Format("{0:C}", x);
            result = string.Format(CultureInfo.GetCultureInfo("en-GB"),"{0:C2}",x);  // ("en-GB") 是 ("who-where")

            button2.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int x;
            //int y = null; //不可以這樣寫

            int? x = null;

            button3.Text = "*" + x.ToString() + "*";
        }
    }
}
