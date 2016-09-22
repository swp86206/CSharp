using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0919_ListBox
{
    public partial class MainForm : Form
    {
        public MainForm()
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
            listBox1.Items.RemoveAt(1);
            // listBox1.Items.Remove("C");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(1, "AA");
            listBox1.Items.RemoveAt(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items[0] = "AAA";
            // listBox1.Items.Count
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // listBox1.SelectedIndex = -1, when user un-selected.
            // button5.Text = listBox1.SelectedIndex.ToString();
            // button5.Text = listBox1.SelectedItem.ToString();
            var x = listBox1.SelectedItem;
            if (x == null)
                button5.Text = "unknown";
            else
                button5.Text = x.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

            //if (listBox1.SelectedItem != null)
            //{
            //    listBox1.Items.Remove(listBox1.SelectedItem);
            //}

        }
    }
}
