using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0920_datatype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //value type 堆疊區
            int x = 30;
            int y;
            y = x;
            x = 100;
            button1.Text = y.ToString(); //y=30 不受x=100影響

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CPoint pt = new CPoint {x =10,y=20}; //以CPoint類別 為藍圖創造 物件記憶體(Object//CPoint實體),pt 是物件參考(記載記憶體資料的位置) //課本第二章 2-14
            CPoint pt2;

            pt2 = pt;

            pt.x = 200; //point
            button2.Text = pt2.x.ToString();
        }
        // 定義一個類別
        class CPoint
        {
            public int x;
            public int y;
        }
    }
}
