using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1003_event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public class WeightEventArgs : EventArgs //寫一個類別
        {
            //三個成員
            public string Reason;   
            public int WeightValue; 
            public bool Handled; //是否改過

            public WeightEventArgs()
            {
                Reason = "";
                WeightValue = 0;
                Handled = false;
            }

            public WeightEventArgs(string why, int value)
            {
                Reason = why;
                WeightValue = value;
                Handled = false;
            }

        }

        public delegate void WeightEventHandler(Object sender, WeightEventArgs e);

        public class CAnimal
        {

            private int _Weight = 0;


            // A. 宣告事件
            public event WeightEventHandler WeightError;
            // public event EventHandler WeightTooLow;

            public int Weight
            {
                get
                {
                    return _Weight;
                }

                set
                {
                    if (value > 0)
                        _Weight = value;
                    else
                    {
                        // B. 呼叫 Client 端的事件處理函式
                        // Invoke event (raise an event), calling EventHander
                        if (this.WeightError != null)
                        {
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

}
