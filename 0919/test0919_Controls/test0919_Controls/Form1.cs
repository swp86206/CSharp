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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clos(object sender, FormClosingEventArgs e)
        {
           // if (e.CloseReason == CloseReason)

            if (checkBox1.Checked) //if (checkBox1.Checked == true)
                    e.Cancel = false;
            else
            e.Cancel = true; //取消關閉這個動作
        }
    }
}
