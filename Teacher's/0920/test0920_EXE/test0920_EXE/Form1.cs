using MyCompany.ToolBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace test0920_EXE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MyCompany.ToolBox.CTest obj = new MyCompany.ToolBox.CTest();
            CTest obj = new CTest();
            button1.Text = obj.getTime();
        }
    }
}
