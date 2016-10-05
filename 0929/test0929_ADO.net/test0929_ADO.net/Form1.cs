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
            System.IO.Directory.CreateDirectory(@"c:\temp");
            //再C曹建構 temp 的資料夾
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            //資料配接器(da),呼叫Fill方法,把資料一筆一筆填進資料集裡(ds)去

            da.Fill(ds);
        }

        private void Uptade_Click(object sender, EventArgs e)
        {
            da.Update(ds);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ds.WriteXml(@"c:\temp\test.xml", XmlWriteMode.DiffGram);
            //把資料寫進C曹temp資料夾裡的test.xml這個檔案
            //  XmlWriteMode.DiffGram : 差異變化,新舊資料都要保留

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.ReadXml(@"c:\temp\test.xml");
            //讀剛剛那檔案的資料
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int iRow = this.bindingSource1.Position;
            button3.Text = iRow.ToString();
            textBox2.Text = ds.LabTable[iRow].data;

        }

        

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            int iRow = this.bindingSource1.Position;
            textBox2.Text = ds.LabTable[iRow].data;
        }
    }
}
