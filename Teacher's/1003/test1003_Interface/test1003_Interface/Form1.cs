using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1003_Interface {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Car obj = new Car();
            obj.AddSpeed(); obj.AddSpeed(); obj.AddSpeed();
            button1.Text = obj.Speed.ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            Car obj = new Car();
            Play(obj);  // IDrive i = obj;
        }

        void Play(IDrive i) {
            i.AddSpeed(); i.AddSpeed(); i.AddSpeed();
            this.Text = i.Speed.ToString();
        }

        private void button3_Click(object sender, EventArgs e) {
            Game obj = new Game();
            Play(obj);
        }
    }

    public interface IDrive {
        void AddSpeed();
        int GetSpeed();
        int Speed { set; get; }
    }

    class Machine {

    }

    class Car : Machine, IDrive {
        private int _Speed = 0;
        public int Speed {
            get {
                return this._Speed;
            }

            set {
                this._Speed = value;
            }
        }

        public void AddSpeed() {
            this._Speed += 10;
        }

        public int GetSpeed() {
            return this.Speed;
        }
    }

    class Hobby {

    }

    class Game : Hobby, IDrive {
        private int _Speed = 0;
        public int Speed {
            get {
                return this._Speed;
            }

            set {
                this._Speed = value;
            }
        }

        public void AddSpeed() {
            this._Speed += 100;
        }

        public int GetSpeed() {
            return this.Speed;
        }
    }



}
