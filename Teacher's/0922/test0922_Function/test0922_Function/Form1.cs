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

        void showStar()  //另建沒有任何參數的版本
        {
            showStar(5, "*"); //此版本固定傳5這個參數進去
        }

        void showStar(int count)
        {
            //string result = "";
            //for (int i = 1; i <= count; i++)
            //{
            //    result += "*";
            //}
            //MessageBox.Show(result);
            showStar(count, "*");////同樣的程式碼不建議重複寫，用轉介方式故呼叫較完整的版本
        }

        void showStar(string what)
        {
            //string result = "";
            //for (int i = 1; i <= 5; i++)
            //{
            //    result += what;
            //}
            //MessageBox.Show(result);
            showStar(5, what);  //同樣的程式碼不建議重複寫，用轉介方式故呼叫較完整的版本
        }
        void showStar(int count, string what) //兩個以上參數用逗號分隔開
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
            showStar(2, "^"); //也可以自己另外做第四個版本(字串在前,數字在後)
            //showStar();會有四個版本可以選擇

        }
        

        void test(ref int data)  // reference
        {
            data = 6;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = 3;
            test(ref x); //把x 在哪哩，找出來
            button4.Text = x.ToString();
        }

        void Swap(ref int x, ref int y)  // ref既當作輸入也當作輸出,視為in/out的參數
            //想改參數值，寫程式的要加ref，呼叫的也要加ref
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
            int result = (x > y) ? x : y; //x有大於y嗎? 有就x,沒有就y
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
            if (int.TryParse(s, out userKeyinNumber)) //out 專門丟資料出來，要用一個變數去接，所以後面不能是數字
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
            // if (x > 100 && foo() )  // &&   且　第一條件符合，才會再進一步
            if (x > 100 & foo())       // &    data1 & data2   因要做位元運算，所以兩份資料都到齊
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
