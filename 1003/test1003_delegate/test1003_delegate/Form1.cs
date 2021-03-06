﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1003_delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Add2 (int x)
        {
            return x + 2;
        }
        int Add10(int y)
        {
            return y + 10;
        }
        delegate int TAddN(int value); //delegate 是一種類別 , delegate是代理人,TAddN是步驟

        private void button1_Click(object sender, EventArgs e)
        {
            // TAddN obj = new TAddN(Add10);
            TAddN p;
            // p = Add2;
            p = Add10;
            button1.Text = p(3).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TAddN p = new TAddN(Add10);
            button2.Text = p.Invoke(80).ToString();
        }
    }
}
