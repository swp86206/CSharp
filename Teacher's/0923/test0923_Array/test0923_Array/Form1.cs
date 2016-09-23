using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace test0923_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iSize = 6;
            int[] numbers = new int[iSize];
            // int[] numbers = new int[6];
            // ___  ___  ___  ___  ___  ___
            // 0    1    2    3    4    5
            // ^numbers
            numbers[5] = 49;
            int x = numbers[5];

            button1.Text = x.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iSize = 6;
            int[] numbers = new int[iSize];
            //numbers[0] = 0;
            //numbers[1] = 1;
            //numbers[2] = 2;
            //numbers[3] = 3;
            //numbers[4] = 4;
            //numbers[5] = 5;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * 10;
            }

            // button2.Text = numbers[3].ToString();
            // button2.Text = numbers.Length.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // int iSize = 6;
            // int[] numbers = new int[iSize];
            int[] numbers = new int[] { 10, 23, 1, 9, 25, 33 };

            button3.Text = numbers[2].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ArrayList dataBag = new ArrayList();
            dataBag.Add(10);
            dataBag.Add(20);
            dataBag.Add(30);

            // find: 30
            // int iFound = dataBag.IndexOf(31);
            // button4.Text = iFound.ToString();
            int iFound = -1;
            for (int i = 0; i < dataBag.Count; i++)
            {
                int iData = Convert.ToInt32(dataBag[i]);
                if (iData == 30)
                {
                    iFound = i;
                    break;
                }
            }
            button4.Text = iFound.ToString();

            // button4.Text = dataBag.Count.ToString();
            // button4.Text = dataBag[0].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hashtable dataBag = new Hashtable();
            dataBag.Add("firstName", "Jeremy");
            dataBag["lastName"] = "Lin";
            dataBag["length"] = 195;

            button5.Text = dataBag["lastName"].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hashtable dataBag = new Hashtable();
            dataBag.Add("firstName", "Jeremy");
            dataBag["lastName"] = "Lin";
            dataBag["length"] = 195;
            foreach ( object data in dataBag.Values )
            {
                listBox1.Items.Add(data.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int iSize = 6;
            int[] numbers = new int[iSize];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * 10;
            }
            foreach (int data in numbers)
            {
                listBox1.Items.Add(data);
            }
            // 124 <==> 129~131
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int data = numbers[i];
            //    listBox1.Items.Add(data);
            //}

        }
    }
}
