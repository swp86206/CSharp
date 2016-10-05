using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0926_Object
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CAnimal obj = new CAnimal();// new CAnimal() 這個空間 obj是個記憶體準備指向 --> ,後面這個空間
                                        //obj.MakeNoise();

            //obj.Weight = 10;
            //obj.Weight = -10; //變數直接公開，會有負數不合情形發生
            //button1.Text = obj.Weight.ToString();

            //obj.SetWeight(10);
            //obj.SetWeight (10);
            //button1.Text = obj.GetWeight.ToString();

            obj.Weight = -12;
            button1.Text = obj.Weight.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CDog obj = new CDog();
            //obj.MakeNoise();  //狗叫
            CAnimal obj = new CDog();
            obj.MakeNoise(); //動物叫 , 父階加上virtual ,子階加上override ,變狗叫 
            //this.Text=obj. //只可以看到public

            /**********************/


        }

        private void button3_Click(object sender, EventArgs e)
        {
            CAnimal obj = new CAnimal(); //會自己選擇使用哪一版本 (); -->1000  (5); --> 5  //()內有設定值
            button3.Text = obj.Weight.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CAnimal obj = new CAnimal();
            try
            {
                obj.Weight = -2;
            }
            catch (Exception ex)
            {
                this.Text = ex.Message;
                //this.Text = DateTime.Now.ToString();
            }
            button4.Text = "done";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i=1; 1<=9; i++)
            {
                //try
                //{
                    test(i);
               // }
                //catch { }
            }
        }

        //try{}
        //catch{}

        void test(int value)
        {
            //try
           // {
               // if (value == 4)
              //  {
                    //throw new Exception("Error!!!");
              //  }
                listBox1.Items.Add(value);
            //}
            //catch(Exception ex)
           // {
                //listBox1.Items.Add(ex.Message);
            //}
       }
           
        private void button6_Click(object sender, EventArgs e)
        {
            /*
            CDog obj = new CDog() { Weight=6,Price=60}; //建立物件當下，順勢給各屬性的屬性值
            //obj.Weight = 5;
            //obj.Price = 500;
            button6.Text = obj.Weight.ToString();
            */

            var obj = new { firstName = "Jeremy", lastName = "Lin" };
            button6.Text = obj.firstName;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // System.Diagnostics.Process.Start(@"C:\temp\test.txt");
            // System.Diagnostics.Process.Start(@"htp://udn.com");
            string sFileName = @"C:\temp\testXXXX.txt";
            try
            {
                System.Diagnostics.Process.Start(sFileName);
            }
            catch(System.ComponentModel.Win32Exception ex)
            {
                this.Text = ex.Message;
            }
            catch (System.Exception ex)
            {
                this.Text = ex.Message;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
    //----------- end of Form1  -------------
    
    class CAnimal //動物出來要解釋其功能
    {

        /* button3使用*/
        //建立與類別同名的副程式,無須再指定string 或 int
        public CAnimal() { this.Weight = 1000; }
        public CAnimal(int WeightValue) { this.Weight = WeightValue; }





        /*  -------------- 這是資料(屬性) ---------------  */
        // public int Weight; //要public 才可以給人使用  

        //防呆使用_Weight 或 mWeight 或 weight
        // public int _Weight;
        //為使變數更正確,使用先藏起來再檢查的方式

        /*  public int Weight { set; get; } //簡單用法   */  

        /******  {set; get; 的應用}  ******/
        private int _Weight; //private 只有此類別可以使用,做檢查的動作
        public int Weight //上面呼叫還是使用public的這個Weight
        {
            set // button1 的Weight值傳到這,即下面value 的值
            {
                if (value >= 0)
                    _Weight = value; //經上述if 判斷後,設定出 _Weight 的值
                else
                {
                    Exception ex = new Exception("Weight too low"); //記錄錯誤發生,代表某種狀況的紀錄
                    throw ex;
                }
            }
            get
            {
                return _Weight; //傳回 _Weight值
            }
        }



        /************變數會有負值問題***********/
        /****************
          private int _Weight; //設一變數,藏起來
          
            //透過一組方法間接取用 
         
        public int GetWeight()
        {
            return this._Weight;   //把資料讀出去
        }

        public void SetWeight(int value) //修改資料,呼叫此方法
        {
            if (value > 0)
            {
                this._Weight=value;
            }                
        }
        ****************/

        ///*------------- 這是功能 ------------*/
        //public void MakeNoise() //他有聲音的功能, 與此相關的功能Method(方法)  //public 要寫，其他才可以叫用
        //{
        //    MessageBox.Show("Animal: ....");
        //}


        /*------------- button使用 ------------*/
        public virtual void MakeNoise() // 建立虛擬(virtual),表示子階可能會改寫
        {
            MessageBox.Show("Animal: ....");
           //this. //可以看到 public,protect,private
        }

        public int iTestPublic = 100; //父 子 button2 顯示
        protected int iTestProtected = 200; //父 子
        private int iTestPrivate = 300; //父
        
       
    }
    // -----------  end of CAnimal ----------

    class CDog : CAnimal //繼承父階的屬性
    {
        /*************** Q: 如何使子階呼叫父階******************/
        public CDog() { }
        
        
        public CDog(int WeightValue,int PriceValue):base(WeightValue)
            { this.Price = PriceValue; }


        public int Price { set; get; }
        /******************************************************/


        public override void MakeNoise() //父階私有的,子階還是拿不到  (override)改寫父階
        {
            base.MakeNoise(); //呼叫父階
            MessageBox.Show("Dog Bark !");
            this.MakeNoise();
            //this. //可以看到 public,protect
        }
    }

}
