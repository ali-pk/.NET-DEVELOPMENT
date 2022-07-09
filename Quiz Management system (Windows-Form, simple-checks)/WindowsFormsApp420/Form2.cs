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
    public partial class Form2 : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ok\Documents\databaseez.mdf;Integrated Security=True;Connect Timeout=30");
        public Form2()
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
            SqlCommand cmd = new SqlCommand("INSERT INTO info VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "',0)", con);
            int a = cmd.ExecuteNonQuery();
            MessageBox.Show("Congrates! Account Created Successfully.");
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
