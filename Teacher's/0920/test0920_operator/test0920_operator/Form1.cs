using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0920_operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 7;
            int y = 3;
            // int result = x / y;  // 2
            double result = x / Convert.ToDouble(y);

            button1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            int y = 3;
            // int result = x + y;  // 8
            // int result = x - y;  // 2
            // int result = x * y;  // 15
            // int result = x / y;  // 1
            int result = x % y;  // 2

            button2.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double result = Math.Pow(2, 3);
            button3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //   &   0   1    AND
            //   0   0   0
            //   1   0   1

            //   |   0   1    OR
            //   0   0   1
            //   1   1   1

            //uint x = 5;            // 0101
            //uint y = 3;            // 0011
            //uint result = x & y;   // 0001   decimal: 1

            //uint x = 5;              // 0101
            //uint y = 3;              // 0011
            //uint result = x | y;     // 0111   decimal: 7

            //   ^   0   1    XOR    if (A.sex xor B.sex) { accept register };
            //   0   0   1
            //   1   1   0
            uint result = 6;      // 0110
            uint x = 5;           // 0101
            result = result ^ x;  // 0011   3
            //                    // 0101
            result = result ^ x;  // 0110

            button4.Text = result.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            uint sport   = 1;   // 0001
            uint music   = 2;   // 0010
            uint reading = 4;   // 0100

            uint hobby = 0;
            hobby = hobby + sport;
            hobby = hobby + reading;
            hobby = hobby + music;  // 7      0111
            hobby = hobby - music;  // 5      0101

            if ((hobby & music) != 0)      // 0010
            {
                button5.Text = "You like music";
            }
            else
                button5.Text = "You do not like music";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uint x = 4;     // 00100
            // x = x << 1;  // 01000
            // x = x << 2;  // 10000
            x = x >> 1;     // 00010
            button6.Text = x.ToString();
        }
    }
}
