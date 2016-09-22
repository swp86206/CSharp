using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0922_Function
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void showStar()
        {
            showStar(5, "*");
        }

        void showStar(int count)
        {
            showStar(count, "*");
        }

        void showStar(string what)
        {
            showStar(5, what);
        }
        void showStar(int count, string what)
        {
            string result = "";
            for (int i = 1; i <= count; i++)
            {
                result += what;
            }
            MessageBox.Show(result);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            showStar("$");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showStar(3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showStar(2, "^");
        }

        void test(ref int data)  // reference
        {
            data = 6;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = 3;
            test(ref x);
            button4.Text = x.ToString();
        }

        void Swap(ref int x, ref int y)  // in/out
        {
            int temp = x;
            x = y;
            y = temp;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            Swap(ref a, ref b);
            button4.Text = a.ToString();
            button5.Text = b.ToString();
        }

        int Max(int x, int y)
        {
            //int result = x;
            //if (x < y)
            //    result = y;
            int result = (x > y) ? x : y;
            return result;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = Max(3, 5).ToString();
        }

        int parseInt(char ch)
        {
            return parseInt(ch.ToString());
        }

        int parseInt(string s)
        {
            int result = 0;
            int userKeyinNumber = -1;
            if (int.TryParse(s, out userKeyinNumber))
                result = userKeyinNumber;
            return result;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = parseInt(textBox1.Text).ToString();

        }

        bool foo()
        {
            this.Text = DateTime.Now.ToString();
            return true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int x = 6;
            // if (x > 100 && foo() )  // &&   且
            if (x > 100 & foo())       // &    data1 & data2   位元運算
            {
                button8.Text = "Yes";
            }
            else
            {
                button8.Text = "No";
            }

        }
    }
}
