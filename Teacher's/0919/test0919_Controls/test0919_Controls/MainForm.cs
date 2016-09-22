using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0919_Controls
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = textBox2.Text;
        }

        private void MyClosingHandler(object sender, FormClosingEventArgs e)
        {
            if (checkBox1.Checked)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
