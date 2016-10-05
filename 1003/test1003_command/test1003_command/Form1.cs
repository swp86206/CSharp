using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test1003_command
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //System.Data.SqlClient
        {
            SqlConnection cn = new SqlConnection(@"data source=(localdb)\MSSQLLocalDB;initial catalog=LabDB;integrated security=True;MultipleActiveResultSets=True"); //把資料庫掛進來

            // data source=(localdb)\MSSQLLocalDB;initial catalog=LabDB;integrated security=True;MultipleActiveResultSets=True

            cn.Open();  //新增連線 

            SqlCommand cmd = new SqlCommand("select * from labTable",cn);  //command 為告知資料庫
            SqlDataReader dr = cmd.ExecuteReader(); //讀資料  ExecuteReader 執行上面"select * from labTable" 並傳回值


            // 一再讀資料
            while (dr.Read()) { 
                listBox1.Items.Add(dr["data"]);
            };

            //listBox1.Items.Add(dr[0]);
            //listBox1.Items.Add(dr[1]);
            //listBox1.Items.Add(dr[0]);



            button1.Text = "OK";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"data source=(localdb)\MSSQLLocalDB;initial catalog=LabDB;integrated security=True;MultipleActiveResultSets=True"); //把資料庫掛進來
            cn.Open();

            SqlCommand cmd = new SqlCommand("update labTable set data = '111' where id = '1'", cn); //command 為告知資料庫要執行動做了!
            cmd.ExecuteNonQuery();   //ExecuteNonQuery 執行上面"update labTable set data = '111' where id = '1'" 程式, 並傳回值  ExecuteNonQuery 不可用 select

            button2.Text = "OK";

        }
    }
}
