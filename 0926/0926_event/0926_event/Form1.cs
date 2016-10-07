using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0926_event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Click += Button2_Click;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            button2.Text = "OK";

        }

        private void DoClick(object sender, EventArgs e)
        {
            // 兩個按鈕,同一事件處理函式, 兩種轉換方式
              Button btn = (Button)sender; //指定型別轉換方法      
          //  Button btn = sender as Button; // 用as 將其視為Button

               if (sender is Button)  
                btn = sender as Button;

                btn.Text = DateTime.Now.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
