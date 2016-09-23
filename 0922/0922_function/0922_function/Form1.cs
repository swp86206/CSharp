using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0922_function
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //void getTime()  // 沒又打算傳東西;有要傳回來要用string，後面加return

        //{
        //    this.Text
        //}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void showStar(int count)
        {
            string result = "";
            for (int i = 1;i <= count; i++)
            {
                result += "*";
            }
            MessageBox.Show(result);
        }

        void showStar2(int what)
        {
            string result = "";
            for (int i = 1; i <= what; i++)
            {
                result += what;
            }
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showStar2(3);
        }


        //void showStar1(int count)
        //{
        //    string result = "";
        //    for (int i = 1; i <= count; i++)
        //    {
        //        result += "*";
        //    }
        //    MessageBox.Show(result);
        //}
        private void button3_Click(object sender, EventArgs e)
        {
            //int QQ = Convert.ToInt32(TextBox.text);
            //showStar1(QQ);
        }


        //void test(ref data);


        private void button5_Click(object sender, EventArgs e)
        {
            //int x =3 

        }

        void Swap(ref int x, ref int y) // in/out   ref 載入記憶體位置
        {
            int temp = x;
            x = y;
            y = temp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            Swap(ref a, ref b);
            button5.Text = a.ToString();
            button6.Text = b.ToString();

        }

        int Max(int x, int y)
        {
            //int result = x;
            //if (x < y)
            //    result = y;
            int result =(x > y) ? x : y; //成立?_後面值,不成立:_後面值
            return result;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = Max(3,5).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //int.Parse() //Parse 是類別
            string s = textBox1.Text;
            int userKeyinNumber = -1;

            if (int.TryParse(s,out userKeyinNumber)) //out　保留字， 是丟資料出來，要有變數去接，不能用數字　
            {
                button8.Text ="OK," + userKeyinNumber.ToString();
            }
            else
            {
                button8.Text = "not a number," + userKeyinNumber.ToString();
            }
        }

        bool fool()
        {
            this.Text = DateTime.Now.ToString();
            return true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int x = 6;
            //if (x > 100 && fool())  // &&  且
            if (x > 100 & fool())   // &   data1 & data2  位元運算
            {
                button9.Text = "Yes";
            }
            else
            {
                button9.Text = "No";
            }
        }
    }
}
