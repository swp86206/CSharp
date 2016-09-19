using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0919_Controls_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = textBox1.Text;
            listBox1.Items.Add(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove("AAA"); //listBox1.Items.RemoveAt(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(2,"CC");
            listBox1.Items.RemoveAt(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items[2]="FF";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //listBox1.SelectedIndex= -1, 使用者未選擇
            //button5.Text = listBox1.SelectedIndex.ToString();
          //  button5.Text = listBox1.SelectedItem.ToString();
            var x = listBox1.SelectedItem;
            if (x == null)
            {
                button5.Text = "unknow";
            }
            else
                button5.Text= listBox1.SelectedItem.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //var s = listBox1.SelectedItem.ToString();
            //listBox1.Items.Remove(  s  );
            if (listBox1.SelectedIndex >= 0) {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);


            } 

        }
    }
}
