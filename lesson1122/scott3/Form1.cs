using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scott3
{
    public partial class Form1 : Form
    {
        static MySqlConnection conn = null;
        private MySqlConnection GetConnection()
        {
            string connectionString = "server=localhost;database=scott;uid=root;pwd=cs1234;";
            if (conn == null) conn = new MySqlConnection(connectionString);
            return conn;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string sql = "select * from emp";
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "emp");
            if (ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "insert into emp(empNo, ename, sal ) values (" + noTxt.Text + ", '" + nameTxt.Text + "', "+salTxt.Text+")";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("saved!!");
        }
    }
}