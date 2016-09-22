using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0920_char_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char ch = 'A';

            button1.Text = ch.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char ch = '錢';

            button2.Text = ch.ToString();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            char ch = '智';
            int i = ch;
            button3.Text = i.ToString();  // 26234
            button3.Text = i.ToString("x");  // 667a
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // char ch = '智';
            // char ch = '\u667a';
            // int i = 26234;
            int i = 0x667a;
            char ch = (char)i;
            button4.Text = ch.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // string s = "錢達智";
            string s = "\u9322\u9054\u667a";

            char ch = s[2];

            button5.Text = ch.ToString();

        }



    }
}
