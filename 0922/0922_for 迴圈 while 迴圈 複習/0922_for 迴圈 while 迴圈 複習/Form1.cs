using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0922_for_迴圈_while_迴圈_複習
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 9)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (i=1; i <= 9; i++)
            {
                listBox1.Items.Add(i);
            }
            listBox1.Items.Add("leave loop");
            listBox1.Items.Add(i);

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            for (int i = 1; i <= 9; i++)
            {
                listBox1.Items.Add(i);
            }
            listBox1.Items.Add("leave loop");
            //listBox1.Items.Add(i);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                i++;
                listBox1.Items.Add(i);
            } while (i<9);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 9)
            {
                if (i == 4)
                {
                    break; // jump to X
                }
                listBox1.Items.Add(i);
                i++;
            }
            //X
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 9)
            {
                if (i == 4)
                {
                    continue; // 還是跑一遍，4跳過  jump to x
                }
                listBox1.Items.Add(i);
                i++;
            } //x
        }
    }
}
