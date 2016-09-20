using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0920
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
            x = Convert.ToInt32(122.45);

            x = (int)(124.5 + 0.5);//125
            this.Text = x.ToString(); 




            button1.Text =Math.Round(122.5,0,MidpointRounding.AwayFromZero).ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 2;
            int y = 6;
            int temp;
            temp = x; //x先到暫存區
            x = y; // x變成y
            y = temp; //y變成暫存區(x)的內容

            this.Text = x.ToString();
            button2.Text = y.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           float x =(float)123.5;
           // float x = 123.5f; //未加f,則預設為double

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
            decimal x = 0.0001m; //未寫m則預設為double,只有小數點四位,專門處理錢
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
