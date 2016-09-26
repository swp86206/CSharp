using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace re_0923_lottory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random dice = new Random();
            for (int i = 1; i <= 6; i++)
            {
                int LuckyNumber = dice.Next(1, 50);
                listBox1.Items.Add(LuckyNumber);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] Pool = new int[49];
            //for (int i = 1; i <= 49; i++)
            //{
                
            //}

            for (int i = 0; i < 49; i++)
            {
                Pool[i] = i + 1;
                listBox1.Items.Add(Pool[i]);
            }

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random dice = new Random();

            for (int i = 0; i < 6; i++) //跑6次
            {
               //listBox1.Items.Add(i);
                
                int luckyIndex = dice.Next(i, 49);
                listBox1.Items.Add(luckyIndex);//開獎的編號,不是開獎號碼
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random dice = new Random();
            int[] pool = new int[49];

            //把球放進機器
            for (int i = 0; i < 49; i++)
            {
                pool[i] = i + 1;               
            }

            //準備開獎號碼
            for (int i = 0; i < 6; i++) //跑6次
            {               
                int luckyIndex = dice.Next(i, 49);
                int temp = pool[luckyIndex];//幸運號取出暫存
                pool[luckyIndex] = pool[i]; //幸運號位置換掉編號數字
                pool[i] = temp; //該編號數再換成幸運號
               // listBox1.Items.Add(luckyIndex);//開獎的編號,不是開獎號碼
            }
            /****顯示報告有誤!!*****
            for (int i = 0; i < 6; i++)
            {
                int luckyIndex = dice.Next(i, 49);
                listBox1.Items.Add(luckyIndex);
            }
            */
            for (int i = 0; i < 6; i++)
            {
                
                listBox1.Items.Add(pool[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random dice = new Random();
            int[] pool = new int[49];

            //把球放進機器
            for (int i = 0; i < 49; i++)
            {
                pool[i] = i + 1;
            }

            //準備開獎號碼
            for (int i = 0; i < 6; i++) //跑6次
            {
                int luckyIndex = dice.Next(i, 49);
                int temp = pool[luckyIndex];//幸運號取出暫存
                pool[luckyIndex] = pool[i]; //幸運號位置換掉編號數字
                pool[i] = temp; //該編號數再換成幸運號
                                // listBox1.Items.Add(luckyIndex);//開獎的編號,不是開獎號碼

                for (int x = 0; x < 6; x++)
                {                   
                    listBox1.Items.Add(pool[x]);
                }
                listBox1.Items.Add("-------");
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random dice = new Random();

            int[] pool = new int[49]; //陣列配置宣告好

            //把球放進機器
            for (int i = 0; i < 49; i++)
            {
                pool[i] = i + 1;
            }

            //準備開獎號碼  
            for (int i = 0; i < 6; i++) //寫迴圈跑6次
            {
                int luckyIndex = dice.Next(i, 49); 
                /*****把幸運號與前面做對調****/
                int temp = pool[luckyIndex];//幸運號取出暫存
                pool[luckyIndex] = pool[i]; //幸運號位置換掉編號數字
                pool[i] = temp; //該編號數再換成幸運號
                                // listBox1.Items.Add(luckyIndex);//開獎的編號,不是開獎號碼
            }
            //  Array.Sort()  //排序
            listBox1.Items.Clear();
            for (int i = 0; i < 6; i++)
            {

                string number = string.Format("{0:d2}", pool[i]); //設定想要的格式
                listBox1.Items.Add(number);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random dice = new Random();

            int[] pool = new int[49]; //陣列配置宣告好

            //把球放進機器
            for (int i = 0; i < 49; i++)
            {
                pool[i] = i + 1;
            }

            //準備開獎號碼  
            for (int i = 0; i < 6; i++) //寫迴圈跑6次
            {
                int luckyIndex = dice.Next(i, 49);
                /*****把幸運號與前面做對調****/
                int temp = pool[luckyIndex];//幸運號取出暫存
                pool[luckyIndex] = pool[i]; //幸運號位置換掉編號數字
                pool[i] = temp; //該編號數再換成幸運號
                                // listBox1.Items.Add(luckyIndex);//開獎的編號,不是開獎號碼
            }

            Array.Sort(pool, 0, 6);  //代表下面 /******/ 的一整串

            /***********************
            int[] lucktNumbers = new int[6];

            Array.Copy(pool, 0, lucktNumbers, 0, 6); //把陣列copy到lucktNumbers 內
            //for(int i =0; i < 6; i++)
            //{
            //    lucktNumbers[i] = pool[i];
            //}

            Array.Sort(lucktNumbers); //排序
            ************************/
            
            /*** 報告幸運號 ***/
            listBox1.Items.Clear();
            for (int i = 0; i < 6; i++)
            {

                string number = string.Format("{0:d2}", lucktNumbers[i]); //設定想要的格式
                listBox1.Items.Add(number);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Random dice = new Random();

            int[] pool = new int[49]; //陣列配置宣告好

            //把球放進機器
            LoadBallsIntoMachine(pool); //編輯-->重購-->擷取方法

            //準備開獎號碼  
            DrawSixLuckyNumbers(dice, pool);

            SortLuckyNumbers(pool);

            ReportResult(pool);
        }

        private void ReportResult(int[] pool)
        {
            /*** 報告幸運號 ***/
            listBox1.Items.Clear();
            for (int i = 0; i < 6; i++)
            {

                string number = string.Format("{0:d2}", pool[i]); //設定想要的格式
                listBox1.Items.Add(number);
            }
        }

        private static void SortLuckyNumbers(int[] pool)
        {
            Array.Sort(pool, 0, 6);  //代表下面 /******/ 的一整串

            /***********************
            int[] lucktNumbers = new int[6];

            Array.Copy(pool, 0, lucktNumbers, 0, 6); //把陣列copy到lucktNumbers 內
            //for(int i =0; i < 6; i++)
            //{
            //    lucktNumbers[i] = pool[i];
            //}

            Array.Sort(lucktNumbers); //排序
            ************************/
        }

        private static void DrawSixLuckyNumbers(Random dice, int[] pool)
        {
            for (int i = 0; i < 6; i++) //寫迴圈跑6次
            {
                int luckyIndex = dice.Next(i, 49);
                /*****把幸運號與前面做對調****/
                int temp = pool[luckyIndex];//幸運號取出暫存
                pool[luckyIndex] = pool[i]; //幸運號位置換掉編號數字
                pool[i] = temp; //該編號數再換成幸運號
                                // listBox1.Items.Add(luckyIndex);//開獎的編號,不是開獎號碼
            }
        }

        private static void LoadBallsIntoMachine(int[] pool)
        {
            for (int i = 0; i < 49; i++)
            {
                pool[i] = i + 1;
            }
        }
    }
    
}
