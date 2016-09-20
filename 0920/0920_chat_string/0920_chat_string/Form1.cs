using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0920_chat_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char ch = 'A'; //字元與字串不同,char 只存一個字元 ,且用單引號
            button1.Text = ch.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char ch = '智'; //字元與整數相通
            int i = ch;
            button3.Text = i.ToString();//26234 八進位(十進位?)  *電腦用此數字記下該字
            button3.Text = i.ToString("x");//667a 十六進位
            //徐5f90/建5efa/合5408
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // char ch = '智'; //字元與整數相通
           // char ch = '\u667a'; //  \u 指定尋找該字
            int i = 0x667a; //打算用16進位表示字
            char ch = (char)i; //需再告知i為char

            button4.Text = ch.ToString();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //string s = "錢達智"; //字串
            string s = "\u9322\u9054\u667a";
            //string s = "\u5f90\u5efa\u5408";

            char ch = s[2];

            button5.Text = ch.ToString();
            //button5.Text = s.ToString();
        }
    }
}
