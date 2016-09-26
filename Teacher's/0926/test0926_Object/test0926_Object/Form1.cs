using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0926_Object {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            CAnimal obj = new CAnimal();
            obj.Weight = 10;
            button1.Text = obj.Weight.ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            CAnimal obj = new CDog(5, 5000);
            // obj.MakeNoise();
            button2.Text = obj.Weight.ToString();
        }

        private void button3_Click(object sender, EventArgs e) {
            CAnimal obj = new CAnimal(5);
            button3.Text = obj.Weight.ToString();
        }

        private void button4_Click(object sender, EventArgs e) {
            CAnimal obj = new CAnimal();
            try { 
                obj.Weight = -2;
            }
            catch (Exception ex)  {
                this.Text = ex.Message;
            }
            button4.Text = "done";
        }

        private void button5_Click(object sender, EventArgs e) {
            for (int i = 1; i <= 9; i++) { 
                test(i);
            }

            //for (int i = 1; i <= 9; i++) {
            //    try {
            //        test(i);
            //    }
            //    catch {

            //    }
            //}


        }

        void test(int value) {
            try {
                if (value == 4) {
                    throw new Exception("Error!!!");
                }
                listBox1.Items.Add(value);
            }
            catch (Exception ex) {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            CDog obj = new CDog() {
                Weight = 6,
                Price = 60
            };
            //obj.Weight = 5;
            //obj.Price = 500;
            button6.Text = obj.Weight.ToString();

            var objAnonymous = new { firstName = "Jeremy", lastName = "Lin" };
            button6.Text = objAnonymous.firstName;

        }

        private void button8_Click(object sender, EventArgs e) {
            // System.Diagnostics.Process.Start(@"c:\temp\test.txt");
            // System.Diagnostics.Process.Start(@"http://udn.com");
            string sFileName = @"c:\temp\testXXXX.txt";
            try {
                System.Diagnostics.Process.Start(sFileName);
            }
            catch (System.ComponentModel.Win32Exception ex) {
                this.Text = ex.Message;
            }
            catch (System.Exception ex) {
                this.Text = ex.Message;
            }

        }

        private void button7_Click(object sender, EventArgs e) {
            CAnimal obj = new CAnimal();

            // C1: Assign Event Hander
            obj.OnWeightError += Obj_OnWeightError;

            obj.Weight = -1;
        }

        // C2: Write Event Handler
        private void Obj_OnWeightError(object sender, EventArgs e) {
            MessageBox.Show("Weight too low");
        }
    }
    // ------------ end of Form1 --------------

    class CAnimal {
        public CAnimal() {
            this.Weight = 0;
        }
        public CAnimal(int WeightValue) {
            this.Weight = WeightValue;
        }


        // S1: declare event
        public event EventHandler OnWeightError;

        private int _Weight;
        public int Weight {
            set {
                if (value >= 0)
                    _Weight = value;
                else {
                    // Exception ex = new Exception("Weigth too low");
                    // throw ex;

                    // S2: invoke event hander
                    if (this.OnWeightError != null) {
                        this.OnWeightError(this, new EventArgs());
                    }
                }
            }
            get {
                return _Weight;
            }
        }

        public virtual void MakeNoise() {
            MessageBox.Show("Animal: ...");
        }

        //public int iTestPublic = 100;
        //protected int iTestProtected = 200;
        //private int iTestPrivate = 300;
    }
    // ----- end of CAnimal -----

    class CDog : CAnimal {
        public CDog() {
            
        }
        public CDog( int WeightValue, int PriceValue ) : base(WeightValue)  {
            this.Price = PriceValue;
        }

        public int Price { set; get; }
        public override void MakeNoise() {
            base.MakeNoise();
            MessageBox.Show("Dog Bark!!");
        }
    }
    // ----- end of CDog -----



}
