using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0926_UsingEvents {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            button2.Click += Button2_Click;
        }

        private void Button2_Click(object sender, EventArgs e) {
            button2.Text = "OK";
        }

        private void DoClick(object sender, EventArgs e) {
            Button btn = null;
            // btn = (Button) sender;
            if (sender is Button)
                btn = sender as Button;

            btn.Text = DateTime.Now.ToString();
        }
    }
}
