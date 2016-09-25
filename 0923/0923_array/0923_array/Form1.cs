using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0923_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iSize = 6; //可以改大小空間
           // int i = 0;
            int[] numbers = new int[iSize];
            // int[] numbers = new int[6]; //配置有6個整數的地方(空間),編號是0~5,numbers指的是一組
            //numbers[1] = 49;// 跳一格的位置(編號1號的位置),傳進去49
            numbers[5] = 49;
            int x = numbers[5]; //取出編號5的數

            button1.Text = x.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iSize = 6; 
            int[] numbers = new int[iSize];
            //numbers[0] = 0;
            //numbers[1] = 1;
            //numbers[2] = 2;
            //numbers[3] = 3;
            //numbers[4] = 4;
            //numbers[5] = 5;
            //for (int i =0; i <iSize; i++) //若用<= iSize 要減1
            //{
            //    numbers[i] = i * 10;
            //}
            for (int i = 0; i < numbers.Length; i++) //除了iSize也可換成Length
            {
                numbers[0] = i * 10;
            }
            //button2.Text = numbers[3].ToString();
            button2.Text = numbers.Length.ToString(); //測量陣列長度
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int iSize = 6;
            //int[] numbers = new int[iSize];
            int[] numbers = new int[] { 10, 23, 1, 9, 25, 33 }; //新陣列,設初值
            /*int[] numbers = new int[6] { 10, 23, 1, 9, 25, 33 };*/ //new int[6] 要寫剛剛好的數字  int 是空間大小
            button3.Text = numbers[2].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ArrayList dataBag = new ArrayList();
            dataBag.Add(20);  //透過Add加東西進去
            dataBag.Add("Chien");
            dataBag.RemoveAt((0)); //把編號0號去掉
            //button4.Text = dataBag.Count.ToString();  // 2 ,加了兩項  
            button4.Text = dataBag[0].ToString(); //把編號0號取出
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hashtable dataBag = new Hashtable(); //Hashtable:一組資料裡面都是文字   ''字典物件''
            dataBag.Add("firstName","Jeremy");
            dataBag["lastName"] = "Lin"; // "lastName" 是 Key
            dataBag["length"] = 195;
            /***************用if迴圈去繞****************/
            // 用新語法 foreach

            button5.Text = dataBag["lastName"].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ArrayList dataBag = new ArrayList();
            dataBag.Add(10);
            dataBag.Add(20);
            dataBag.Add(30);
            // find:30

            // int iFound = dataBag.IndexOf(30);
            //int iFound = dataBag.IndexOf(31); //答案-1,找不到

            //以下是用迴圈去繞 !!

            int iFound = -1;
            for (int i = 0; i < dataBag.Count; i++)
            {
                int iData = Convert.ToInt32(dataBag[i]);
                if (iData == 30)
                {
                    iFound = i;
                    break;
                }
            }


            button6.Text = iFound.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hashtable dataBag = new Hashtable(); 
            dataBag.Add("firstName", "Jeremy");
            dataBag["lastName"] = "Lin";
            dataBag["length"] = 195;
            foreach (object data in dataBag.Values) //把值一個一個取出來
            {
                listBox1.Items.Add(data.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int iSize = 6;
            int[] numbers = new int[iSize];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * 10;
            }
            foreach (int data in numbers)  // 語法是in 要被
            {
                listBox1.Items.Add(data);
            }

            // 133行 <==> 139~141  精簡語法
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int data = numbers[i] ;
            //    listBox1.Items.Add(data);
            //}


        }
    }
}
