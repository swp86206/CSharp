using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0922_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int answer = -1;

        private void Form1_Load(object sender, EventArgs e)
        {
            settingAnswer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userKeyin = Convert.ToInt32(textBox1.Text);
            if (userKeyin > answer)
            {
                listBox1.Items.Add("Lower will be better.");
            }
            else
            {
                if (userKeyin < answer)
                {
                    listBox1.Items.Add("Higer please.");
                }
                else
                {
                    listBox1.Items.Add("Correct!");
                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int userKeyin = Convert.ToInt32(textBox1.Text);
            if (userKeyin > answer)
            {
                listBox1.Items.Add("Lower will be better.");
            }
            else if (userKeyin < answer)
            {
                listBox1.Items.Add("Higer please.");
            }
            else
            {
                listBox1.Items.Add("Correct!");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            int userKeyin = Convert.ToInt32(textBox1.Text);
            if (userKeyin > answer)
            {
                listBox1.Items.Add("Lower will be better.");
            }
            if (userKeyin < answer)
            {
                listBox1.Items.Add("Higer please.");
            }
            if (userKeyin == answer)
            {
                listBox1.Items.Add("Correct!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            settingAnswer();
        }

        private void settingAnswer()
        {
            Random obj = new Random();
            answer = obj.Next(0, 10);
            this.Text = answer.ToString();
        }
    }
}
