using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0920_PM_1st
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 7;
            int y = 3;
            //int result = x / y; // 2
            //double result = (x*1.0) / y; //2.33333... *使用double可以顯示小數
            //double result = x / (y* 1.0); //2.33333...
            //double result = x / Convert.ToDouble(y); //2.33333...
            //double result = ((x * 1000) / (y*1000))/1000; // 0
            double result = ((x/ y )*1000) / 1000; // 2
            button1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            int y = 3;
            //int result = x + y; // 8
            //int result = x - y; // 2
            //int result = x * y; // 15
            //int result = x / y; // 1
            int result = x % y; // 2  取餘數

            button2.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double result = Math.Pow(2, 3); // 2的3次方 ; Math:大約 ; Pow：次方
            button3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // and 0  1    & (交集)
            //  0  0  0
            //  1  0  1

            // or  0  1    | (聯集)
            //  0  0  1
            //  1  1  1
            uint x = 5;  //0101
            uint y = 3;  //0011
            uint result = x & y; // 0001   decimal：1

            uint x = 5;  //0101
            uint y = 3;  //0011
            uint result = x | y; // 0001   decimal：7

            //  ^  0  1    XOR   if (A.sex xor B.sex) { accept register };
            //  0  0  1
            //  1  1  0

            uint result = 6;  //0110
            uint x = 5;       //0101
            result =result ^ x // 3   0011  // 6^5
            result = result ^ x //6   0110  // 3^5          ^為XOR,連兩次XOR會變原值

            // uint result = x << 1  //往左移
        }
    }
}
