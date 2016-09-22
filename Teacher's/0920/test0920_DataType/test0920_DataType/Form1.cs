using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0920_DataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // value type
            int x = 30;
            int y;
            y = x;
            x = 100;
            button1.Text = y.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CPoint pt = new CPoint { x = 10, y = 20 };
            CPoint pt2;

            pt2 = pt;

            pt.x = 200;  // point

            button2.Text = pt2.x.ToString();
        }
    }  // end of Form1

    class CPoint
    {
        public int x;
        public int y;
    }



}
