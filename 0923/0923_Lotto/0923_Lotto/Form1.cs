using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0923_Lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random dice = new Random();
            int[] Pool = new int[49];

           int LuckyNumber = dice.Next(1, 50);
            listBox1.Items.Add(LuckyNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random dice = new Random () ;
            int[] Pool = new int[49];

            // 把球裝到機器裡
            for (int i = 0; i < 49; i++) 
            {
                Pool[i] = i + 1;
            }

            // 開獎 , 跑六次
            for (int i=0; i<6; i++)
            {
                int luckyIndex = dice.Next(i,49);
                listBox1.Items.Add(luckyIndex);
            }


            //for (int i = 0; i < 49; i++)
            //{
            //    listBox1.Items.Add(Pool[i]);
            //}

        }
    }
}
