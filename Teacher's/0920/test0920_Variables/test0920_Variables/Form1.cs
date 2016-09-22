using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0920_Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // type variableName = initValue;
            int x = 543;

            // x = 123.9;  // wrong
            // x = (int)124.9;  // 124
            // x = Convert.ToInt32(122.5); // 122
            x = Convert.ToInt32(123.5); // 124  四捨六入五成雙
            // 123.0
            // 123456789
            // 1234
            //     ^1234
            x = (int)(124.5 + 0.5); // 125
            this.Text = x.ToString();
            // 123:
            button1.Text = Math.Round(122.5, 0, MidpointRounding.AwayFromZero).ToString();

        }

        void swap(int x, int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 2;
            int y = 6;
            swap(x, y);
            this.Text = x.ToString();
            button2.Text =  y.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // float x = (float)12.5;
            // float x = 123.5f;
            double x = 125.5;

            button3.Text = x.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x = 0.0001;
            int i = 0;
            double result = 0;
            for (i = 1; i <= 10000; i++)
            {
                result = result + x;
            }
            this.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal x = 0.0001m;
            int i = 0;
            decimal result = 0;
            for (i = 1; i <= 10000; i++)
            {
                result = result + x;
            }
            this.Text = result.ToString();
        }
    }
}
