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

namespace test1003_Command {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e) {  // System.Data.SqlClient
            SqlConnection cn = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database=LabDB;Integrated Security=True");
            cn.Open();

            SqlCommand cmd = new SqlCommand("select * from labTable", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                listBox1.Items.Add(dr["data"]);
            }

            button1.Text = "OK";
        }

        private void button2_Click(object sender, EventArgs e) {
            SqlConnection cn = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database=LabDB;Integrated Security=True");
            cn.Open();

            SqlCommand cmd = new SqlCommand("update labTable set data = '111' where id = 1", cn);
            cmd.ExecuteNonQuery();
            
        }
    }
}
