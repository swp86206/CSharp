using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0929_ADO.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            //資料配接器(da),呼叫Fill方法,把資料填進去
        
            da.Fill(ds);
        }

        private void Uptade_Click(object sender, EventArgs e)
        {
            da.Update(ds);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
