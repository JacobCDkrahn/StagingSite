using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Form1.conn))
                {
                    con.Open();

                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Northwind.dbo." + comboBox1.Text, con);
                    DataTable tbl = new DataTable();
                    sda.Fill(tbl);
                    dataGridView1.DataSource = tbl;
                    SqlCommand count = new SqlCommand("SELECT COUNT(*) FROM Northwind.dbo." + comboBox1.Text, con);
                    label7.Text = " " + (int)count.ExecuteScalar();
                }
            }
            catch
            {
                MessageBox.Show("You dont have access to this table.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(Form1.conn))
                {
                    con.Open();

                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Northwind.dbo." + comboBox2.Text, con);
                    DataTable tbl = new DataTable();
                    sda.Fill(tbl);
                    dataGridView2.DataSource = tbl;
                    SqlCommand count = new SqlCommand("SELECT COUNT(*) FROM Northwind.dbo." + comboBox2.Text, con);
                    label8.Text =" " +(int)count.ExecuteScalar();
                }
            }
            catch
            {
                MessageBox.Show("You dont have access to this table.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
