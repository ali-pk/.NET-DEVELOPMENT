using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp420
{
    public partial class Form1 : Form
    {
        public static string username;
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ok\Documents\databaseez.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
            Connection();
        }
        public SqlConnection Connection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            return con;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("select * from info where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'", con);
            SqlDataReader s = cmd.ExecuteReader();
            if (s.Read())
            {
                username = textBox1.Text;
                Form3 F3 = new Form3();
                F3.ShowDialog();

            }
            else
            {
                MessageBox.Show("username/password is wrong!");
            }
            textBox1.Clear();
            textBox2.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
