using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0923_Lottery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random dice = new Random();
            for (int i = 1; i <= 6; i++)
            {
                int LuckyNumber = dice.Next(1, 50);
                listBox1.Items.Add(LuckyNumber);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] Pool = new int[49];

            // Load balls into machine
            for (int i = 0; i < 49; i++)
            {
                Pool[i] = i + 1;
            }


            for (int i = 0; i < 49; i++)
            {
                listBox1.Items.Add(Pool[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random dice = new Random();
            int[] Pool = new int[49];

            // Load balls into machine
            for (int i = 0; i < 49; i++)
            {
                Pool[i] = i + 1;
            }

            // draw lucky numbers
            // 1 2 3 4 5 6 7 8 9
            //     ^
            // 3 2 1 4 5 6 7 8 9
            //   --------^------
            // 3 6 1 4 5 2 7 8 9
            //     ----------^--
            // 3 6 8 4 5 2 7 1 9
            // ^^^^^


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random dice = new Random();
            int[] pool = new int[49];

            // Load balls into machine
            for (int i = 0; i < 49; i++)
            {
                pool[i] = i + 1;
            }

            // draw lucky numbers
            for (int i = 0; i < 6; i++)
            {
                int luckyIndex = dice.Next(i, 49);
                // 0 <--> 8
                // 1 <--> 49
                // 2 <--> 30
                // ...
                int temp = pool[luckyIndex];
                pool[luckyIndex] = pool[i];
                pool[i] = temp;
            }

            for (int i = 0; i < 6; i++)
            {
                listBox1.Items.Add(pool[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random dice = new Random();
            int[] pool = new int[49];

            // Load balls into machine
            for (int i = 0; i < 49; i++)
            {
                pool[i] = i + 1;
            }

            // draw lucky numbers
            for (int i = 0; i < 6; i++)
            {
                int luckyIndex = dice.Next(i, 49);
                int temp = pool[luckyIndex];
                pool[luckyIndex] = pool[i];
                pool[i] = temp;
            }

            // report lucky numbers
            listBox1.Items.Clear();
            for (int i = 0; i < 6; i++)
            {
                string number = string.Format("{0:d2}", pool[i]);
                listBox1.Items.Add(number);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random dice = new Random();
            int[] pool = new int[49];

            // Load balls into machine
            for (int i = 0; i < 49; i++)
            {
                pool[i] = i + 1;
            }

            // draw lucky numbers
            for (int i = 0; i < 6; i++)
            {
                int luckyIndex = dice.Next(i, 49);
                int temp = pool[luckyIndex];
                pool[luckyIndex] = pool[i];
                pool[i] = temp;
            }

            Array.Sort(pool, 0, 6);
            //int[] luckyNumbers = new int[6];
            //Array.Copy(pool, 0, luckyNumbers, 0, 6);
            ////for ( int i = 0; i < 6; i++)
            ////{
            ////    luckyNumbers[i] = pool[i];
            ////}
            //Array.Sort(luckyNumbers);

            // report lucky numbers
            listBox1.Items.Clear();
            for (int i = 0; i < 6; i++)
            {
                string number = string.Format("{0:d2}", luckyNumbers[i]);
                listBox1.Items.Add(number);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random dice = new Random();
            int[] pool = new int[49];

            LoadBallsIntoMachine(pool);

            DrawSixLuckyNumbers(dice, pool);

            SortLuckyNumbers(pool);

            ReportResult(pool);
        }

        private void ReportResult(int[] pool)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 6; i++)
            {
                string number = string.Format("{0:d2}", pool[i]);
                listBox1.Items.Add(number);
            }
        }

        private static void SortLuckyNumbers(int[] pool)
        {
            Array.Sort(pool, 0, 6);
            //int[] luckyNumbers = new int[6];
            //Array.Copy(pool, 0, luckyNumbers, 0, 6);
            ////for ( int i = 0; i < 6; i++)
            ////{
            ////    luckyNumbers[i] = pool[i];
            ////}
            //Array.Sort(luckyNumbers);
        }

        private static void DrawSixLuckyNumbers(Random dice, int[] pool)
        {
            for (int i = 0; i < 6; i++)
            {
                int luckyIndex = dice.Next(i, 49);
                int temp = pool[luckyIndex];
                pool[luckyIndex] = pool[i];
                pool[i] = temp;
            }
        }

        private static void LoadBallsIntoMachine(int[] pool)
        {
            for (int i = 0; i < 49; i++)
            {
                pool[i] = i + 1;
            }
        }
    }
}
