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

namespace test1121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HomeLable_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void WorkLable_Click(object sender, EventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string connectionString = null;
            MySqlConnection conn;
            connectionString = "server=localhost;database=YICMS;uid=root;pwd=cs1234;";
            conn = new MySqlConnection(connectionString);
            string sql = "select * from Customer";
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
            adpt.Fill(ds, "Customer");
            if (ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            MySqlConnection conn;
            connectionString = "server=localhost;database=YICMS;uid=root;pwd=cs1234;";
            conn = new MySqlConnection(connectionString);
            string sql = "insert into Customer(FirstName, LastName, EmailAddress, HomeAddress, WorkAddress) values ('"
                + FirstTxt.Text + "', '" + LastTxt.Text + "', '" + EmailTxt.Text + "', '" + HomeTxt.Text + "', '" + WorkTxt.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("saved!!");
        }
    }
}