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

        int answer = -1;  //兩個在共用,所以宣告在外面

        private void Form1_Load(object sender, EventArgs e)
        {
            init(); //準備好時,呼叫這個副程式
        }
        //A
        

        void init()
        {
            settingAnswer(); //設定初始化
            listBox1.Items.Clear(); //清空
        }

        void settingAnswer() //副程式function
        {
            Random obj = new Random();
            answer = obj.Next(0, 10); //代表0~9的隨機數字
            this.Text = answer.ToString(); //顯示在表單上方
            //listBox1.Items.Add(answer);
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
                if (useKeyin < answer)
                {
                    listBox1.Items.Add("Highter please");
                }
                else
                {
                    listBox1.Items.Add("Correct");
                   settingAnswer(); //重新設定答案
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
            else if (useKeyin < answer)
                {
                    listBox1.Items.Add("Higer please");
                }
                else
                {
                    listBox1.Items.Add("Correct");
                   // settingAnswer();
                }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int useKeyin = Convert.ToInt32(textBox1.Text);
            if (useKeyin > answer)
            {
                listBox1.Items.Add("Lower will be better");
            }
            if (useKeyin < answer)
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
        //private void settingAnswer() {

        //}

       
    }
}
