using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0920_constr_enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 1000;
            decimal afterTaxTotal = total * (1 + 0.05m);
            button1.Text = afterTaxTotal.ToString();
        }

        const decimal __TAX_RATE = 0.05m;

        private void button2_Click(object sender, EventArgs e)
        {
            int total = 1000;
            decimal afterTaxTotal = total * (1 + __TAX_RATE);
            button2.Text = afterTaxTotal.ToString();
        }

        enum TSeason
        {
            Spring = 1,
            Summer = 2,
            Autumn = 4,
            Winter = 8
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TSeason x;
            x = TSeason.Autumn;

            // button3.Text = ((int)x).ToString();
            // button3.Text = x.ToString();
            if (x == TSeason.Autumn)
                button3.Text = "Yes";
            else
                button3.Text = "No";

            //double data = 3.14;
            //Math.Round(data, 2, MidpointRounding.AwayFromZero)

        }
    }
}
