using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1003_Event {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            CAnimal obj = new CAnimal();
            obj.WeightError += Obj_WeightError;
            obj.Weight = -3;
            button1.Text = obj.Weight.ToString();
        }

        private void Obj_WeightError(object sender, WeightEventArgs e) {
            e.WeightValue = -1 * e.WeightValue;
            e.Handled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = !checkBox1.Checked;
        }
    }

    public class WeightEventArgs : EventArgs {
        public string Reason;
        public int WeightValue;
        public bool Handled;

        public WeightEventArgs() {
            Reason = "";
            WeightValue = 0;
            Handled = false;
        }

        public WeightEventArgs(string why, int value) {
            Reason = why;
            WeightValue = value;
            Handled = false;
        }

    }

    public delegate void WeightEventHandler(Object sender, WeightEventArgs e);

    public class CAnimal {

        private int _Weight = 0;


        // A. 宣告事件
        public event WeightEventHandler WeightError;
        // public event EventHandler WeightTooLow;

        public int Weight {
            get {
                return _Weight;
            }

            set {
                if (value > 0)
                    _Weight = value;
                else {
                    // B. 呼叫 Client 端的事件處理函式
                    // Invoke event (raise an event), calling EventHander
                    if (this.WeightError != null) {
                        WeightEventArgs e = new WeightEventArgs("Weight too low", value);
                        this.WeightError.Invoke(this, e);
                        if (e.Handled)
                            _Weight = e.WeightValue;
                    }
                }
            }
        }

    }



}
