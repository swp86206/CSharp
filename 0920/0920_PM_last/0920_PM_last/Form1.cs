using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0920_PM_last
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

        const decimal __TAX_RATE = 0.05m; //常數，恆常不變，只能在此更改

        private void button2_Click(object sender, EventArgs e)
        {
            int total = 1000;
            decimal afterTaxTotal = total * (1 + __TAX_RATE);
            button2.Text = afterTaxTotal.ToString();
        }

        enum TSeason {   //資料
            Sprisng,
            Summer,
            Autumn,
            Winter

        }   
        private void button3_Click(object sender, EventArgs e)
        {
            TSeason x;
            x = TSeason.Autumn;

            // button3.Text = ((int)x).ToString(); //為自己定義數字
            // button3.Text = x.ToString();
            if (x == TSeason.Autumn) 
                button3.Text = "Yes";
            else 
                button3.Text = "NO";
            
        }
    }
}
