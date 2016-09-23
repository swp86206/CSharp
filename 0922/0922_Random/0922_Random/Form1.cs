using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0922_Random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        //A
        int answer =-1 ;  //兩個在共用,所以宣告在外面

        void init()
        {
            settingAnswer();
            listBox1.Items.Clear();
        }

        void settingAnswer() //副程式function
        {
            Random obj = new Random();
            int answer = obj.Next(0, 10);
            listBox1.Items.Add(answer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (answer == -1)
            //{
            //    settingAnswer();
            //}
            int useKeyin = Convert.ToInt32( textBox1.Text);
            if (useKeyin > answer)
            {
                listBox1.Items.Add("Lower will be better");
            }
            else
            {
                if (useKeyin > answer)
                {
                    listBox1.Items.Add("Higer please");
                }
                else
                {
                    listBox1.Items.Add("Correct");
                    settingAnswer();
                }
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int useKeyin = Convert.ToInt32(textBox1.Text);
            if (useKeyin > answer)
            {
                listBox1.Items.Add("Lower will be better");
            }
            else if (useKeyin > answer)
                {
                    listBox1.Items.Add("Higer please");
                }
                else
                {
                    listBox1.Items.Add("Correct");
                    settingAnswer();
                }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int useKeyin = Convert.ToInt32(textBox1.Text);
            if (useKeyin > answer)
            {
                listBox1.Items.Add("Lower will be better");
            }
            if (useKeyin > answer)
            {
                listBox1.Items.Add("Higer please");
            }
            if (useKeyin == answer)
            {
                listBox1.Items.Add("Correct");               
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            settingAnswer();
        }
        private void settingAnswer() {

        }
    }
}
