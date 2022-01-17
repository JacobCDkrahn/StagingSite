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

namespace WindowsFormsApp3
{
   
    public partial class Form1 : Form
    {

        public static String userName;
        public static String conn;
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IS3KOKH\SQLEXPRESS; Database= Northwind; User ID=" +  textBox1.Text + "; PASSWORD=" + textBox2.Text+";");
            try {
                
                con.Open();
                this.Hide();
                conn = @"Data Source=DESKTOP-IS3KOKH\SQLEXPRESS;User ID=" + textBox1.Text + "; PASSWORD=" + textBox2.Text + ";";
                userName = textBox1.Text;
                new Form2().Show();
            }

            catch {
                MessageBox.Show("Invalid username or password");
            }

         



           

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        public String textboxText() {
            return textBox1.Text;
        }
    }
}
