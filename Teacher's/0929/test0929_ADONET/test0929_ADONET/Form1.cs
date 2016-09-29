using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0929_ADONET {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            System.IO.Directory.CreateDirectory(@"c:\temp");
        }

        private void button1_Click(object sender, EventArgs e) {
            da.Fill(ds);
        }

        private void button2_Click(object sender, EventArgs e) {
            da.Update(ds);
        }

        private void button3_Click(object sender, EventArgs e) {
            ds.WriteXml(@"c:\temp\test.xml", XmlWriteMode.DiffGram);
        }

        private void button4_Click(object sender, EventArgs e) {
            ds.ReadXml(@"c:\temp\test.xml");
        }

        private void button5_Click(object sender, EventArgs e) {
            int iRow = this.bindingSource1.Position;
            textBox2.Text = ds.LabTable[iRow].data;
        }

        private void bindingSource1_PositionChanged(object sender, EventArgs e) {
            int iRow = this.bindingSource1.Position;
            textBox2.Text = ds.LabTable[iRow].data;
        }
    }
}
