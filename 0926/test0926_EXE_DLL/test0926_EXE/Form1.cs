using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test0926_DLL.TimeSpace;

namespace test0926_EXE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CTest obj = new CTest();
            //test0926_DLL.CTest obj = new test0926_DLL.CTest();
            
            button1.Text = obj.GetTime();
        }
    }
}
